#nullable enable
#r "nuget: Humanizer.Core, 2.14.1"
#load "constants.csx"
#load "models.csx"

using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using AngleSharp.Common;
using Humanizer;
using Microsoft.VisualBasic;

/// <summary>
/// Generates class definitions for all the models in the Telegram Bot API.
/// </summary>
/// <param name="definitions">The definitions of the Telegram Bot API.</param>
/// <returns>The class definitions for all the models in the Telegram Bot API.</returns>
static IEnumerable<ClassDefinition> MapTypesIntoClasses(this BotApiDefinitions definitions)
{
    ICollection<ClassDefinition> baseClasses = [];
    ICollection<ClassDefinition> classes = [];

    // Generate the base classes for each type group
    foreach (var telegramTypeGroup in definitions.TypeGroups)
    {
        var @namespace = string.Format(
            "{0}.{1}",
            ScriptConstants.PROJECT_NAME,
            telegramTypeGroup.SectionName.Pascalize()
        );
        var className = telegramTypeGroup.Name;
        var classDescription = new List<string>(telegramTypeGroup.Description);
        ICollection<ClassPropertyDefinition> properties = [];
        List<string> usings = [];

        classDescription.Add("<list type=\"bullet\">");
        classDescription.AddRange(
            telegramTypeGroup.Types.Select(model =>
                $"<item><description><see cref=\"{model}\"/></description></item>"
            )
        );
        classDescription.Add("</list>");

        // Get the types that belong to this group
        var types = definitions.Types.Where(t => telegramTypeGroup.Types.Contains(t.Name));

        // Find all the properties that are common to all the types in this group
        var commonPropertyGroups = types
            .SelectMany(t => t.Properties)
            .GroupBy(p => p.Name)
            .Where(g =>
                g.Count() == types.Count() && g.Select(p => p.IsRequired).Distinct().Count() == 1
            );

        // Generate the properties for the base class
        foreach (var propGroup in commonPropertyGroups)
        {
            var name = propGroup.Key.Pascalize();
            var firstDescription = propGroup.First().Description;
            var description = propGroup.All(p => p.Description.SequenceEqual(firstDescription))
                ? firstDescription
                : new List<string>();
            var isAbstract = !description.Any();

            // If the description is empty, try to remove the sentence of each description that is different.
            if (!description.Any())
            {
                var sentences = propGroup.First().Description;
                description = sentences.Where(s =>
                    propGroup.All(p => p.Description.Any(d => d == s))
                );
            }
            // If the description is still empty, split the description by a comma and remove the sentence of each description that is different.
            if (!description.Any())
            {
                var splittedSentences = propGroup.First().Description.Select(d => d.Split(','));
                description = splittedSentences.Select(sp =>
                    string.Join(
                        ',',
                        sp.Where(s => propGroup.All(p => p.Description.Any(d => d.Contains(s))))
                    )
                );
            }
            // If the description is still empty, throw an exception. A description is required.
            if (!description.Any())
            {
                throw new Exception(
                    $"Could not find a common description for property {propGroup.Key} in group {telegramTypeGroup.Name}"
                );
            }

            var typeNames = propGroup
                .SelectMany(p => p.Types)
                .Distinct()
                .Select(tn => AdjustTypeName(tn, propGroup.Key, telegramTypeGroup.Name));

            // Add usings for each type.
            var references = definitions
                .Types.Where(t => typeNames.Contains(t.Name))
                .Select(t => t.SectionName)
                .Select(s => string.Format("{0}.{1}", ScriptConstants.PROJECT_NAME, s.Pascalize()));
            usings.AddRange(references);

            typeNames = typeNames
                .Select(t =>
                    BuildType(t, propGroup.First().ArrayLevels, propGroup.Key)
                        .Replace(ScriptConstants.INPUT_FILE_TYPE_NAME, "string")
                )
                .Distinct();

            var parsedDescription = ParseDocReferences(description, definitions);
            usings.AddRange(ExtractUsingsFromParsedDoc(parsedDescription, definitions));

            var property = new ClassPropertyDefinition(
                name,
                parsedDescription,
                typeNames,
                propGroup.First().IsRequired,
                isAbstract,
                propGroup.All(p =>
                    !string.IsNullOrEmpty(ExtractConstValueFromDescription(p.Description))
                )
            );
            properties.Add(property);
        }

        var parsedDocs = ParseDocReferences(classDescription, definitions);
        usings.AddRange(ExtractUsingsFromParsedDoc(parsedDocs, definitions));

        // Generate the base class
        var baseClass = new ClassDefinition(
            className,
            parsedDocs,
            @namespace,
            Path.Combine(telegramTypeGroup.SectionName.Pascalize(), className, $"{className}.cs"),
            properties,
            new List<ClassMethodDefinition>(),
            ClassModelType.BaseModel,
            usings.Distinct()
        );

        baseClasses.Add(baseClass);
        yield return baseClass;
    }

    // Generate the classes for each type
    foreach (var telegramType in definitions.Types)
    {
        var @namespace = string.Format(
            "{0}.{1}",
            ScriptConstants.PROJECT_NAME,
            telegramType.SectionName.Pascalize()
        );
        var className = telegramType.Name;
        var classDescription = telegramType.Description;
        ICollection<ClassPropertyDefinition> properties = [];
        List<string> usings = [];

        // Generate the properties for the class
        foreach (var prop in telegramType.Properties)
        {
            var name = prop.Name.Pascalize();
            var description = prop.Description;
            var typeNames = prop.Types.Select(tn =>
                BuildType(tn, prop.ArrayLevels, prop.Name, telegramType.Name)
                    .Replace(ScriptConstants.INPUT_FILE_TYPE_NAME, "string")
            );

            // Add usings for each type.
            var references = definitions
                .Types.Where(t => prop.Types.Contains(t.Name))
                .Select(t => t.SectionName)
                .Select(s => string.Format("{0}.{1}", ScriptConstants.PROJECT_NAME, s.Pascalize()));
            usings.AddRange(references);

            string? value = null;

            if (prop.IsRequired)
            {
                value = ExtractConstValueFromDescription(description);
                if (value is null && prop.Types.Count() == 1 && prop.Types.First() == "True")
                {
                    value = "true";
                }
            }

            var parsedPropDescription = ParseDocReferences(description, definitions);
            usings.AddRange(ExtractUsingsFromParsedDoc(parsedPropDescription, definitions));

            var property = new ClassPropertyDefinition(
                name,
                parsedPropDescription,
                typeNames,
                prop.IsRequired,
                Value: value
            );
            properties.Add(property);
        }

        // Get the base class if any
        var baseTypeName = definitions.TypeGroups.FirstOrDefault(g =>
            g.Types.Contains(telegramType.Name)
        );
        var baseClass =
            baseTypeName != null ? baseClasses.First(c => c.Name == baseTypeName.Name) : null;

        var parsedDocs = ParseDocReferences(classDescription, definitions);
        usings.AddRange(ExtractUsingsFromParsedDoc(parsedDocs, definitions));

        string path;
        // Make an exception for the Chat and ChatFullInfo classes
        if (className == "Chat" || className == "ChatFullInfo")
        {
            path = Path.Combine(
                telegramType.SectionName.Pascalize(),
                Path.Combine("Chat", $"{className}.cs")
            );
            if (className == "ChatFullInfo")
            {
                // Make ChatFullInfo inherit from Chat
                baseClass = classes.First(c => c.Name == "Chat");
            }
        }
        else
        {
            path = Path.Combine(
                telegramType.SectionName.Pascalize(),
                baseClass is null
                    ? $"{className}.cs"
                    : Path.Combine(baseClass.Name, $"{className}.cs")
            );
        }

        // Generate the class
        var classDefinition = new ClassDefinition(
            className,
            parsedDocs,
            @namespace,
            path,
            properties,
            new List<ClassMethodDefinition>(),
            IsModelLikeArgs(className, definitions)
                ? ClassModelType.ModelWithConstructor
                : ClassModelType.Model,
            usings.Distinct(),
            baseClass
        );

        classes.Add(classDefinition);
        yield return classDefinition;
    }
}

/// <summary>
/// Generates class definitions for all the methods in the Telegram Bot API.
/// </summary>
/// <remarks>
/// The class definitions represents classes with extension methods for each method in the Telegram Bot API. There are also classes for the arguments of each method with complex arguments.
/// </remarks>
/// <param name="definitions">The definitions of the Telegram Bot API.</param>
/// <returns>The class definitions for all the methods in the Telegram Bot API.</returns>
static IEnumerable<ClassDefinition> MapMethodsIntoClasses(this BotApiDefinitions definitions)
{
    var filesParameter = new ClassMethodParameterDefinition(
        "files",
        ["The files to upload."],
        "IDictionary<string, InputFile>?",
        false
    );

    foreach (var telegramMethod in definitions.Methods)
    {
        var @namespace = string.Format(
            "{0}.{1}",
            ScriptConstants.PROJECT_NAME,
            telegramMethod.SectionName.Pascalize()
        );
        var methodName = telegramMethod.Name.Pascalize();
        var methodDescription = new List<string>(telegramMethod.Description);
        var methods = new List<ClassMethodDefinition>();
        var usings = new List<string>();

        if (
            telegramMethod.Parameters.Any(p =>
                p.Types.Any(t => t == ScriptConstants.INPUT_FILE_TYPE_NAME)
            )
        )
        {
            usings.Add($"{ScriptConstants.PROJECT_NAME}.AvailableTypes");
        }
        var paramTypeNames = telegramMethod
            .Parameters.SelectMany(p => p.Types)
            .GroupTypes(definitions.TypeGroups)
            .Distinct();
        // Add usings for each type.
        var paramReferences = definitions
            .Types.Where(t => paramTypeNames.Contains(t.Name))
            .Select(t => t.SectionName)
            .Concat(
                definitions
                    .TypeGroups.Where(g => paramTypeNames.Contains(g.Name))
                    .Select(g => g.SectionName)
            )
            .Select(s => string.Format("{0}.{1}", ScriptConstants.PROJECT_NAME, s.Pascalize()));
        usings.AddRange(paramReferences);

        // Check if the method has any complex arguments
        var hasAttachments = telegramMethod.Parameters.Any(p =>
            p.Types.Any(t => HasAttachments(t, definitions))
        );
        var hasComplexArguments =
            telegramMethod.Parameters.Any(p =>
                p.ArrayLevels > 0 || p.Types.Any(t => char.IsUpper(AdjustTypeName(t, p.Name)[0]))
            )
            || telegramMethod.Parameters.Count() > 4;
        // If the method has complex arguments, generate a class for the arguments and a method that receives the arguments class
        if (hasComplexArguments)
        {
            var className = $"{methodName}Args";
            var classDescription = $"Represents the arguments of the \"{methodName}\" method.";
            var properties = new List<ClassPropertyDefinition>();
            var argsUsings = new List<string>(usings);

            // Generate the properties for the class
            foreach (var param in telegramMethod.Parameters)
            {
                var name = param.Name.Pascalize();
                var description = param.Description;
                var typeNames = param.Types.Select(tn => AdjustTypeName(tn, param.Name));

                // If there are any property of type InputFile, make sure `hasAttachments` is true.
                if (typeNames.Any(t => HasAttachments(t, definitions)))
                {
                    hasAttachments = true;
                }

                var parsedPropdescription = ParseDocReferences(description, definitions);
                argsUsings.AddRange(ExtractUsingsFromParsedDoc(parsedPropdescription, definitions));

                var property = new ClassPropertyDefinition(
                    name,
                    parsedPropdescription,
                    typeNames.Select(t => BuildType(t, param.ArrayLevels, param.Name)),
                    param.IsRequired
                );
                properties.Add(property);
            }

            var classDefinition = new ClassDefinition(
                className,
                new List<string>() { classDescription },
                @namespace,
                Path.Combine(telegramMethod.SectionName.Pascalize(), "Args", $"{className}.cs"),
                properties,
                new List<ClassMethodDefinition>(),
                hasAttachments
                    ? ClassModelType.MethodArgumentsWithAttachments
                    : ClassModelType.MethodArguments,
                argsUsings.Distinct()
            );

            yield return classDefinition;

            var returnType = telegramMethod.ReturnTypes.Count() > 1 ? "TResult" : null;
            if (returnType is null)
            {
                var firstResultType = telegramMethod.ReturnTypes.First();
                returnType = BuildType(firstResultType.Type, firstResultType.ArrayLevels);
            }

            var argumentsParameter = new ClassMethodParameterDefinition(
                "args",
                [$"The arguments for the \"{methodName}\" method."],
                className,
                true
            );

            var parsedDocs = ParseDocReferences(methodDescription, definitions);
            argsUsings.AddRange(ExtractUsingsFromParsedDoc(parsedDocs, definitions));

            // Add a method
            var method = new ClassMethodDefinition(
                methodName,
                parsedDocs,
                [argumentsParameter],
                returnType
            );
            methods.Add(method);
        }

        // Create method for all the possible return types and all the possible parameters
        foreach (var returnTypeDef in telegramMethod.ReturnTypes)
        {
            var requiredTelegramParameters = telegramMethod.Parameters.Where(p =>
                p.IsRequired || returnTypeDef.DependentParameters.Contains(p.Name)
            );
            var optionalTelegramParameters = telegramMethod.Parameters.Where(p =>
                !p.IsRequired
                && requiredTelegramParameters.All(rp =>
                    !p.IsExclusiveWith.Contains(rp.Name)
                    && !requiredTelegramParameters.Any(rp => rp.Name == p.Name)
                )
            );

            // Create all the possible combinations of required parameters
            var requiredParametersCombinations = requiredTelegramParameters.Select(p =>
                p.Types.GroupTypes(definitions.TypeGroups)
                    .Select(t => new ClassMethodParameterDefinition(
                        p.Name.Camelize(),
                        ParseDocReferences(p.Description, definitions),
                        BuildType(t, p.ArrayLevels, p.Name),
                        true
                    ))
            );
            if (requiredParametersCombinations.Any())
            {
                // Apply cartesian product
                requiredParametersCombinations = requiredParametersCombinations.Aggregate(
                    (IEnumerable<IEnumerable<ClassMethodParameterDefinition>>)
                        new[] { Enumerable.Empty<ClassMethodParameterDefinition>() },
                    (acc, cur) => from a in acc from b in cur select a.Concat(new[] { b })
                );
            }
            // Create all the possible combinations of optional parameters
            var optionalParametersCombinations = optionalTelegramParameters.Select(p =>
                p.Types.GroupTypes(definitions.TypeGroups)
                    .Select(t => new ClassMethodParameterDefinition(
                        p.Name.Camelize(),
                        ParseDocReferences(p.Description, definitions),
                        BuildType(t, p.ArrayLevels, p.Name),
                        false
                    ))
            );
            if (optionalParametersCombinations.Any())
            {
                // Apply cartesian product
                optionalParametersCombinations = optionalParametersCombinations.Aggregate(
                    (IEnumerable<IEnumerable<ClassMethodParameterDefinition>>)
                        new[] { Enumerable.Empty<ClassMethodParameterDefinition>() },
                    (acc, cur) => from a in acc from b in cur select a.Concat(new[] { b })
                );
            }

            IEnumerable<IEnumerable<ClassMethodParameterDefinition>> parametersCombinations = [];

            // Create all the possible combinations of required and optional parameters
            // Optional parameters cannot have more than one combination, so if that is the case, use the required parameters combinations to restrict the optional parameters combinations.
            if (optionalParametersCombinations.Count() > 1)
            {
                // Search which required parameter can be used to restrict the optional parameters combinations
                var requiredParameter =
                    requiredTelegramParameters
                        .Reverse()
                        .FirstOrDefault(p =>
                            p.Types.GroupTypes(definitions.TypeGroups).Count()
                                % optionalParametersCombinations.Count()
                                == 0
                            || optionalParametersCombinations.Count()
                                % p.Types.GroupTypes(definitions.TypeGroups).Count()
                                == 0
                        )
                    ?? throw new Exception(
                        $"Could not find a required parameter with the same count of types as the optional parameters in method {telegramMethod.Name}. There are no ways to restrict the optional parameters combinations."
                    );

                var buffer = new List<IEnumerable<ClassMethodParameterDefinition>>();
                var discriminatingTypeNames = requiredParameter
                    .Types.GroupTypes(definitions.TypeGroups)
                    .Select(
                        (t, i) =>
                            (
                                Index: i,
                                Type: BuildType(
                                    t,
                                    requiredParameter.ArrayLevels,
                                    requiredParameter.Name
                                )
                            )
                    );
                foreach (var rp in requiredParametersCombinations)
                {
                    var currentType = rp.First(p =>
                        p.Name == requiredParameter.Name.Camelize()
                    ).Type;
                    var index = discriminatingTypeNames.First(t => t.Type == currentType).Index;
                    buffer.Add(rp.Concat(optionalParametersCombinations.GetItemByIndex(index)));
                }

                // Create all the possible combinations of required and optional parameters
                parametersCombinations = buffer;
            }
            else
            {
                if (requiredParametersCombinations.Count() == 0)
                {
                    parametersCombinations = optionalParametersCombinations;
                }
                else if (optionalParametersCombinations.Count() == 0)
                {
                    parametersCombinations = requiredParametersCombinations;
                }
                else
                {
                    parametersCombinations = requiredParametersCombinations.SelectMany(
                        _ => optionalParametersCombinations,
                        IEnumerable<ClassMethodParameterDefinition> (r, o) => r.Concat(o)
                    );
                }
            }

            var returnType = BuildType(returnTypeDef.Type, returnTypeDef.ArrayLevels);

            if (parametersCombinations.Any())
            {
                var parsedDocs = ParseDocReferences(methodDescription, definitions);
                var references = ExtractUsingsFromParsedDoc(
                    parsedDocs.Concat(
                        ParseDocReferences(
                            parametersCombinations.SelectMany(c =>
                                c.SelectMany(p => p.Description)
                            ),
                            definitions
                        )
                    ),
                    definitions
                );
                usings.AddRange(references);
                // If the method has attachments, add the files parameter to the combinations
                if (hasAttachments)
                {
                    parametersCombinations = parametersCombinations.Select(p =>
                        p.Any(x =>
                        {
                            // Check if the parameter is a string where the value can be a reference to an attachment
                            if (
                                x.Type == "string"
                                && x.Description.Any(d => d.Contains("attach://"))
                            )
                            {
                                return true;
                            }
                            // Check if the parameter is a list where the primary type is a model with an attachment.
                            var typeName = x.Type.Split('<').Last().Split('>').First();
                            // If the type is InputFile, there is no need to add the files parameter for this combination.
                            if (typeName == ScriptConstants.INPUT_FILE_TYPE_NAME)
                            {
                                return false;
                            }
                            return definitions.Types.Any(t =>
                                t.Name == typeName
                                && t.Properties.Any(p =>
                                    p.Types.Any(t => HasAttachments(t, definitions))
                                )
                            );
                        })
                            ? p.Concat([filesParameter])
                            : p
                    );
                }
                // For each combination, create a sync and an async method
                foreach (var parameters in parametersCombinations)
                {
                    var method = new ClassMethodDefinition(
                        methodName,
                        parsedDocs,
                        parameters,
                        returnType
                    );
                    methods.Add(method);
                }
            }
            else
            {
                var method = new ClassMethodDefinition(
                    methodName,
                    ParseDocReferences(methodDescription, definitions),
                    new List<ClassMethodParameterDefinition>(),
                    returnType
                );
                methods.Add(method);
            }
        }

        // Define the class name and description
        var methodClassName = string.Format(
            "{0}Extensions",
            telegramMethod.SectionName.Pascalize()
        );
        var methodClassDescription = "Extension methods for the Telegram Bot API.";

        if (telegramMethod.Parameters.Any(p => p.Types.Any(t => HasAttachments(t, definitions))))
        {
            usings.Add($"{ScriptConstants.PROJECT_NAME}.AvailableTypes");
        }

        // Add usings for each return type
        foreach (var rt in telegramMethod.ReturnTypes)
        {
            var references = definitions
                .Types.Where(t => t.Name == rt.Type)
                .Select(t => t.SectionName)
                .Concat(
                    definitions.TypeGroups.Where(g => g.Name == rt.Type).Select(g => g.SectionName)
                )
                .Distinct()
                .Select(s => string.Format("{0}.{1}", ScriptConstants.PROJECT_NAME, s.Pascalize()));

            usings.AddRange(references);
        }

        // Create the extension methods class
        var methodClassDefinition = new ClassDefinition(
            methodClassName,
            new List<string>() { methodClassDescription },
            @namespace,
            Path.Combine(telegramMethod.SectionName.Pascalize(), $"{telegramMethod.Name}.cs"),
            Enumerable.Empty<ClassPropertyDefinition>(),
            methods,
            ClassModelType.ExtensionMethods,
            usings.Distinct()
        );
        yield return methodClassDefinition;
    }
}

/// <summary>
/// Generates class definitions for all the constants in the Telegram Bot API.
/// </summary>
/// <param name="definitions">The definitions of the Telegram Bot API.</param>
/// <returns>The class definitions for all the constants in the Telegram Bot API.</returns>
static IEnumerable<ClassDefinition> MapConstantsIntoClasses(this BotApiDefinitions definitions)
{
    var groups = new[]
    {
        new
        {
            ClassName = "PropertyNames",
            Description = "Defines all the property names used by models and methods in the Telegram Bot API.",
            Values = definitions.PropertyNames.Order()
        },
        new
        {
            ClassName = "MethodNames",
            Description = "Defines all the method names used by methods in the Telegram Bot API.",
            Values = definitions.MethodNames.Order()
        },
    };

    foreach (var g in groups)
    {
        var @namespace = ScriptConstants.PROJECT_NAME;
        var fileName = $"{g.ClassName}.cs";
        yield return new ClassDefinition(
            g.ClassName,
            [g.Description],
            @namespace,
            fileName,
            g.Values.Select(v => new ClassPropertyDefinition(
                v.Pascalize(),
                [],
                ["string"],
                true,
                Value: v
            )),
            [],
            ClassModelType.Constants,
            []
        );
    }
}

#region Utilities
/// <summary>
/// Check if the type or any of its properties has an attachment.
/// </summary>
/// <param name="typeName">The name of the type.</param>
/// <param name="definitions">The definitions of the Telegram Bot API.</param>
static bool HasAttachments(string typeName, BotApiDefinitions definitions)
{
    if (char.IsLower(typeName[0]))
    {
        return false;
    }
    if (typeName == ScriptConstants.INPUT_FILE_TYPE_NAME)
    {
        return true;
    }

    // Check if the type has any property of type InputFile
    var type = definitions.Types.FirstOrDefault(t => t.Name == typeName);
    if (type != null)
    {
        return type.Properties.Any(p => p.Description.Any(s => s.Contains("attach://")))
            || type.Properties.SelectMany(p => p.Types)
                .Select(t => AdjustTypeName(t))
                .Any(t =>
                    t == ScriptConstants.INPUT_FILE_TYPE_NAME || HasAttachments(t, definitions)
                );
    }

    // If the type is a group, check if any of the types in the group has an attachment
    var group = definitions.TypeGroups.FirstOrDefault(g => g.Name == typeName);
    return group != null && group.Types.Any(t => HasAttachments(t, definitions));
}

/// <summary>
/// If all the type names are in the same group, returns the name of the group. Otherwise, returns the type names.
/// </summary>
/// <param name="typeNames">The type names to simplify.</param>
/// <param name="groups">The type groups.</param>
/// <returns>The simplified type names.</returns>
static IEnumerable<string> GroupTypes(
    this IEnumerable<string> typeNames,
    IEnumerable<TelegramTypeGroup> groups
)
{
    var groupName = typeNames.Any()
        ? groups.FirstOrDefault(g => typeNames.All(t => g.Types.Contains(t)))?.Name
        : null;
    return groupName is null ? typeNames : new[] { groupName };
}

static string BuildType(
    string name,
    ushort arrayLevels,
    string? propName = null,
    string? parentName = null
)
{
    string result = AdjustTypeName(name, propName, parentName);
    for (int i = 0; i < arrayLevels; i++)
    {
        result = $"IEnumerable<{result}>";
    }
    return result;
}

/// <summary>
/// Adjusts the type name to the correct type.
/// </summary>
/// <param name="type">The type name to adjust.</param>
/// <param name="propName">The name of the property.</param>
static string AdjustTypeName(string type, string? propName = null, string? parentName = null)
{
    switch (type)
    {
        case "Int":
        case "Integer":
            if (propName != null)
            {
                if ((new string[] { "chat_id", "user_id", "file_size" }).Any(propName.EndsWith))
                {
                    return "long";
                }
                else if (propName == "id" && parentName != null)
                {
                    if (parentName == "Chat" || parentName == "User")
                    {
                        return "long";
                    }
                }
                // The following properties should never be signed integers but they will be treated as signed integers because CLS compliance.
                // "date", "size", "width", "height", "duration", "quantity", "limit", "amount", "amounts", "period", "radius", "heading"
            }
            return "int";
        case "String":
            return "string";
        case "Float":
        case "Float number":
            return "float";
        case "Boolean":
        case "True":
            return "bool";
    }

    return type;
}

/// <summary>
/// Extracts the constant value from the description.
/// </summary>
/// <param name="description">The description of the constant.</param>
static string? ExtractConstValueFromDescription(IEnumerable<string> description)
{
    var patterns = new[] { @"always [""“](?<value>.+)[""”]", @"must be <em>(?<value>.+)</em>" };
    foreach (var pattern in patterns)
    {
        var fullDescription = string.Join(' ', description);
        var match = Regex.Match(fullDescription, pattern);
        if (match.Success)
        {
            return match.Groups["value"].Value;
        }
    }
    return null;
}

/// <summary>
/// Checks if the model is used as an argument for a method.
/// </summary>
/// <param name="modelName">The name of the model.</param>
/// <param name="definitions">The definitions of the Telegram Bot API.</param>
/// <returns>True if the model is used as an argument for a method. False otherwise.</returns>
static bool IsModelLikeArgs(string modelName, BotApiDefinitions definitions)
{
    var baseClassNames = new[]
    {
        "InputMedia",
        "ReplyMarkup",
        "InputMessageContent",
        "BotCommandScope",
        "ReactionType"
    };
    var baseClasses = definitions.TypeGroups.Where(g => baseClassNames.Contains(g.Name));
    var @classes = new[]
    {
        "KeyboardButton",
        "KeyboardButtonRequestUsers",
        "KeyboardButtonRequestChat",
        "InlineKeyboardButton",
        "ShippingOption",
        "LabeledPrice",
        "BotCommand",
        "WebAppInfo",
        "LoginUrl",
        "InputPollOption"
    };

    return @classes.Contains(modelName) || baseClasses.Any(g => g.Types.Contains(modelName));
}

/// <summary>
/// Extracts the usings from the parsed doc.
/// </summary>
/// <param name="description">A parsed description.</param>
/// <param name="definitions">The definitions of the Telegram Bot API.</param>
/// <returns></returns>
static IEnumerable<string> ExtractUsingsFromParsedDoc(
    IEnumerable<string> description,
    BotApiDefinitions definitions
)
{
    var pattern = @"<see cref=""(?<type>[^""]+)""/>";
    var references = new List<string>();
    foreach (var d in description)
    {
        var matches = Regex.Matches(d, pattern);
        foreach (var m in matches.Cast<Match>())
        {
            var typeName = m.Groups["type"].Value;
            var group = definitions.TypeGroups.FirstOrDefault(g => g.Name == typeName);
            var type = definitions.Types.FirstOrDefault(t => t.Name == typeName);
            if (group != null || type != null)
            {
                var @using = string.Format(
                    "{0}.{1}",
                    ScriptConstants.PROJECT_NAME,
                    type?.SectionName.Pascalize() ?? group?.SectionName.Pascalize()
                );
                references.Add(@using);
            }
        }
    }

    return references.Distinct();
}

/// <summary>
/// Parses the references in the description.
/// </summary>
/// <param name="description">The description to parse.</param>
/// <param name="definitions">The definitions of the Telegram Bot API.</param>
/// <returns>The parsed description.</returns>
static IEnumerable<string> ParseDocReferences(
    IEnumerable<string> description,
    BotApiDefinitions definitions
)
{
    var anchorPattern = @"<a href=""(?<url>[^""]+)"">(?:<em>)?(?<text>[^<>]+)(?:</em>)?</a>";
    var emojiPattern = @"<img class=""emoji""[^<>]+alt=""(?<emoji>[^""]+)"">";
    var newDescription = description
        .Where(d => !string.IsNullOrEmpty(d))
        .Select(d =>
        {
            d = d.Replace("<br>", "<br />");
            d = d.Replace("<code>", "<em>");
            d = d.Replace("</code>", "</em>");
            d = d.Replace("<em>Optional</em>", "Optional");
            var matches = Regex.Matches(d, anchorPattern);

            foreach (var m in matches.Cast<Match>())
            {
                var url = m.Groups["url"].Value;
                var text = m.Groups["text"].Value;

                if (url.StartsWith("/"))
                {
                    url = $"{ScriptConstants.TELEGRAM_CORE_WEBSITE_URL}{url}";
                    // Replace the href for the new url
                    d = d.Replace(m.Value, $"<a href=\"{url}\">{text}</a>");
                }
                else if (url.StartsWith("#"))
                {
                    // Check if the reference is a type
                    var typeName =
                        definitions.Types.FirstOrDefault(t => t.Name == text)?.Name
                        ?? definitions.TypeGroups.FirstOrDefault(g => g.Name == text)?.Name;
                    if (typeName != null)
                    {
                        // Replace the anchor for a `see` tag
                        d = d.Replace(m.Value, $"<see cref=\"{typeName}\"/>");
                    }
                    else
                    {
                        url = $"{ScriptConstants.TELEGRAM_BOT_API_DOCS_URL}{url}";
                        // Replace the href for the new url
                        d = d.Replace(m.Value, $"<a href=\"{url}\">{text}</a>");
                    }
                }
            }

            matches = Regex.Matches(d, emojiPattern);
            foreach (var m in matches.Cast<Match>())
            {
                var emoji = m.Groups["emoji"].Value;
                d = d.Replace(m.Value, emoji);
            }

            return d;
        });

    if (!newDescription.Any())
    {
        newDescription = ["No description available"];
    }

    return newDescription;
}

#endregion
