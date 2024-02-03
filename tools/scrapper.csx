#nullable enable
#r "nuget: AngleSharp, 1.1.0"
#load "constants.csx"
#load "models.csx"

using System.Collections;
using System.Net.Http;
using System.Text.RegularExpressions;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Io;

/// <summary>
/// Scrapes the Bot API Definitions from the Telegram Bot API Documentation.
/// </summary>
/// <returns>The Bot API Definitions.</returns>
static async Task<BotApiDefinitions> ScrapBotApiDefinitions()
{
    using var client = new HttpClient();
    WriteLine("Fetching from {0}", ScriptConstants.TELEGRAM_BOT_API_DOCS_URL);
    var response = await client.GetAsync(ScriptConstants.TELEGRAM_BOT_API_DOCS_URL);
    var content = await response.Content.ReadAsStreamAsync();
    WriteLine("Parsing HTML...");
    var parser = new HtmlParser();
    // Prepare AngleSharp
    var document = parser.ParseDocument(content);

    // Define initial variables
    string? sectionName = null;
    var types = new List<TelegramType>();
    var methods = new List<TelegramMethod>();
    var typeGroups = new List<TelegramTypeGroup>();

    // Get the element with id "dev_page_content" which contains the documentation of all typess and methods
    var devPageContent =
        document.GetElementById("dev_page_content")
        ?? throw new Exception("Could not find element with id \"dev_page_content\"");

    // Define the initial section
    var element = devPageContent.Children.FirstOrDefault(c =>
        c.TagName.Equals(TagNames.H3, StringComparison.OrdinalIgnoreCase)
    );

    while (element is not null)
    {
        // Define a namespace for this section
        sectionName = element.TextContent;
        element = element.NextElementSibling;
        while (
            element is not null
            && !element.TagName.Equals(TagNames.H3, StringComparison.OrdinalIgnoreCase)
        )
        {
            if (
                element.TagName.Equals(TagNames.H4, StringComparison.OrdinalIgnoreCase)
                && !string.IsNullOrEmpty(element.TextContent)
            )
            {
                //* If the value contains spaces, ignore it
                if (element.TextContent.Contains(" "))
                {
                    element = element.NextElementSibling;
                    continue;
                }

                //* If the value starts with uppercase, it's a type
                if (char.IsUpper(element.TextContent.First()))
                {
                    var typeOrGroupName = element.TextContent;
                    ICollection<string> typeOrGroupDescription = [];
                    var typeProperties = new List<TelegramTypeProperty>();
                    ICollection<string> groupTypes = [];

                    do
                    {
                        element = element.NextElementSibling;

                        if (
                            element?.TagName.Equals(TagNames.P, StringComparison.OrdinalIgnoreCase)
                            == true
                        )
                        {
                            typeOrGroupDescription.Add(element.InnerHtml);
                        }
                        else if (
                            element?.TagName.Equals(TagNames.Ul, StringComparison.OrdinalIgnoreCase)
                            == true
                        )
                        {
                            // Read each type from ul
                            foreach (var li in element.Children)
                            {
                                // If the type name doesn't contain spaces, it's a type reference
                                if (!li.TextContent.Contains(" "))
                                {
                                    groupTypes.Add(li.TextContent);
                                }
                            }
                        }
                        else if (
                            element?.TagName.Equals(
                                TagNames.Table,
                                StringComparison.OrdinalIgnoreCase
                            ) == true
                        )
                        {
                            // Read each parameter from tbody
                            var tbody =
                                element.Children.FirstOrDefault(c =>
                                    c.TagName.Equals(
                                        TagNames.Tbody,
                                        StringComparison.OrdinalIgnoreCase
                                    )
                                ) ?? throw new Exception("Could not find tbody element in table");
                            foreach (var tr in tbody.Children)
                            {
                                var propertyName = tr.Children[0].TextContent;
                                var propType = tr.Children[1]
                                    .TextContent.Replace(" or", ",")
                                    .Replace(" and", ",");
                                var arrayLevels = (ushort)Regex.Matches(propType, "Array of").Count;
                                for (var i = 0; i < arrayLevels; i++)
                                {
                                    propType = propType.Replace("Array of ", string.Empty);
                                }
                                IEnumerable<string> propertyTypes = propType
                                    .Split(",")
                                    .Select(t => t.Trim());
                                string description = tr.Children[2].InnerHtml;
                                var required = !tr.Children[2].TextContent.StartsWith("Optional");

                                // If a parameter is exclusive with another, the description will contain something like those options:
                                // - Required if <em>another parameter</em> is not specified
                                // - Required if <em>another parameter</em> and <em>another parameter</em> are not specified
                                var exclusiveWith = new List<string>();

                                // Match "Required if <em>another parameter</em> is not specified"
                                var match = Regex.Match(
                                    description,
                                    @"Required if .*? (?:(?:are)|(?:is)) not specified"
                                );
                                if (match.Success)
                                {
                                    // Extract all the parameters from the match
                                    var parameters = Regex
                                        .Matches(match.Value, @"<em>(?<param>[\w_]*)</em>")
                                        .Select(m => m.Groups["param"].Value);
                                    exclusiveWith.AddRange(parameters);
                                }

                                typeProperties.Add(
                                    new TelegramTypeProperty(
                                        propertyName,
                                        [description],
                                        required,
                                        propertyTypes,
                                        arrayLevels
                                    )
                                );
                            }
                            break;
                        }
                    } while (element != null && element is not IHtmlHeadingElement);

                    // If there are at least one property, add the type name to the list
                    if (
                        typeProperties.Count > 0
                        || typeOrGroupDescription.Any(d =>
                            d.Contains("urrently holds no information")
                        )
                    )
                    {
                        types.Add(
                            new TelegramType(
                                sectionName,
                                typeOrGroupName,
                                typeOrGroupDescription,
                                typeProperties
                            )
                        );
                    }
                    // Check if this type is part of a group
                    else if (groupTypes.Count > 0)
                    {
                        typeGroups.Add(
                            new TelegramTypeGroup(
                                sectionName,
                                typeOrGroupName,
                                typeOrGroupDescription,
                                groupTypes
                            )
                        );
                    }
                }
                //* Otherwise, it's a method
                else
                {
                    var methodName = element.TextContent;
                    ICollection<string> methodDescription = [];
                    var methodParameters = new List<TelegramMethodParameter>();
                    var methodReturnTypes = new List<TelegramReturnType>();

                    do
                    {
                        element = element.NextElementSibling;

                        if (
                            element?.TagName.Equals(TagNames.P, StringComparison.OrdinalIgnoreCase)
                            == true
                        )
                        {
                            methodDescription.Add(element.InnerHtml);
                        }
                        else if (
                            element?.TagName.Equals(
                                TagNames.Table,
                                StringComparison.OrdinalIgnoreCase
                            ) == true
                        )
                        {
                            // Read each parameter from tbody
                            var tbody =
                                element.Children.FirstOrDefault(c =>
                                    c.TagName.Equals(
                                        TagNames.Tbody,
                                        StringComparison.OrdinalIgnoreCase
                                    )
                                ) ?? throw new Exception("Could not find tbody element in table");
                            foreach (var tr in tbody.Children)
                            {
                                var paramName = tr.Children[0].TextContent;
                                var paramType = tr.Children[1]
                                    .TextContent.Replace(" or", ",")
                                    .Replace(" and", ",");
                                var arrayLevels = (ushort)
                                    Regex.Matches(paramType, "Array of").Count;
                                for (var i = 0; i < arrayLevels; i++)
                                {
                                    paramType = paramType.Replace("Array of ", string.Empty);
                                }
                                IEnumerable<string> parameterTypes = paramType
                                    .Split(",")
                                    .Select(t => t.Trim());
                                var required = tr.Children[2].TextContent == "Yes";
                                var description = tr.Children[3].InnerHtml;

                                // If a parameter is exclusive with another, the description will contain something like those options:
                                // - Required if <em>another parameter</em> is not specified
                                // - Required if <em>another parameter</em> and <em>another parameter</em> are not specified
                                var exclusiveWith = new List<string>();

                                // Match "Required if <em>another parameter</em> is not specified"
                                var match = Regex.Match(
                                    description,
                                    @"Required if .*? (?:(?:are)|(?:is)) not specified"
                                );
                                if (match.Success)
                                {
                                    // Extract all the parameters from the match
                                    var parameters = Regex
                                        .Matches(match.Value, @"<em>(?<param>[\w_]*)</em>")
                                        .Select(m => m.Groups["param"].Value);
                                    exclusiveWith.AddRange(parameters);
                                }

                                methodParameters.Add(
                                    new TelegramMethodParameter(
                                        paramName,
                                        [description],
                                        required,
                                        parameterTypes,
                                        arrayLevels,
                                        exclusiveWith
                                    )
                                );
                            }
                            break;
                        }
                    } while (element != null && element is not IHtmlHeadingElement);

                    // Add the return types to the list
                    methodReturnTypes.AddRange(
                        ExtractReturnTypesFromDescription(string.Join('\n', methodDescription))
                    );

                    // Add the method name to the list
                    methods.Add(
                        new TelegramMethod(
                            sectionName,
                            methodName,
                            methodDescription,
                            methodParameters,
                            methodReturnTypes
                        )
                    );
                }
            }
            else
            {
                element = element.NextElementSibling;
            }
        }
    }

    //* Add aditional groups
    typeGroups.Add(
        new TelegramTypeGroup(
            "Available types",
            "ReplyMarkup",
            new string[]
            {
                "Additional interface options. A JSON-serialized object for an <a href=\"/bots/features#inline-keyboards\">inline keyboard</a>, <a href=\"/bots/features#keyboards\">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user."
            },
            new string[]
            {
                "InlineKeyboardMarkup",
                "ReplyKeyboardMarkup",
                "ReplyKeyboardRemove",
                "ForceReply"
            }
        )
    );

    WriteLine(
        "Found {0} methods, {1} types and {2} type groups",
        methods.Count(),
        types.Count(),
        typeGroups.Count()
    );

    return new BotApiDefinitions(types, methods, typeGroups);
}

static IEnumerable<TelegramReturnType> ExtractReturnTypesFromDescription(string description)
{
    var sentences = description.Split(". ");
    var sentenceWithReturn = sentences.First(s =>
        s.Contains("is returned") || s.Contains("Returns") || s.Contains("returns")
    );
    // Methods that return more than one type will have a sentence like these:
    // "if the edited message is not an inline message, the edited Message is returned, otherwise True is returned."
    // "if the message is not an inline message, the edited Message is returned, otherwise True is returned."
    var count = Regex.Matches(sentenceWithReturn, "is returned").Count;
    // If true, the method returns only one type
    if (count <= 1)
    {
        if (
            sentenceWithReturn.Contains("<em>True</em> is returned")
            || sentenceWithReturn.Contains("Returns <em>True</em> on success")
        )
        {
            return [new TelegramReturnType("bool", 0, Enumerable.Empty<string>())];
        }

        var arrayLevels = (ushort)Regex.Matches(sentenceWithReturn, "[Aa]rray of").Count;
        // Extract the type from first Anchor element
        var type = Regex
            .Match(sentenceWithReturn, @"<a.*?>(?<type>[\w_]*)</a>")
            .Groups["type"]
            .Value;
        if (string.IsNullOrEmpty(type))
        {
            type = Regex
                .Match(sentenceWithReturn, @"<em>(?<type>[\w_]*)</em>")
                .Groups["type"]
                .Value;
        }
        else if (type.EndsWith('s') && arrayLevels > 0)
        {
            type = type.Remove(type.Length - 1);
        }
        return [new TelegramReturnType(type, arrayLevels, Enumerable.Empty<string>())];
    }
    else if (description.Contains("message is not an inline message, the"))
    {
        return
        [
            new TelegramReturnType("Message", 0, new string[] { "chat_id", "message_id" }),
            new TelegramReturnType("bool", 0, new string[] { "inline_message_id" })
        ];
    }

    throw new Exception("Could not parse return types from description");
}
