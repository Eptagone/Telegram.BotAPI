// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Reflection;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents a Telegram bot command created from a type that represents a bot command.
/// Defines additional properties like aliases and possible translations extracted from the <see cref="TelegramBotCommandAttribute"/> attributes present in the type.
/// </summary>
public class ExtendedBotCommand : IExtendedBotCommand
{
    private const string BOT_COMMAND_SUFFIX = "Command";
    private readonly Dictionary<string, ValueTuple<IEnumerable<string>, string>> specs;

    /// <summary>
    /// Initializes a new instance of the <see cref="ExtendedBotCommand"/> class.
    /// </summary>
    /// <param name="type">A type that represents a bot command.</param>
    public ExtendedBotCommand(Type type)
    {
        var cmdAttrs = type.GetCustomAttributes<TelegramBotCommandAttribute>();
        Dictionary<string, ValueTuple<IEnumerable<string>, string>> specs;
        if (cmdAttrs.Any())
        {
            specs = new();

            foreach (var cmdAttr in cmdAttrs)
            {
                var key = cmdAttr.LanguageCode ?? string.Empty;
                var names = new List<string>();
                var description = cmdAttr.Description;
                if (specs.TryGetValue(key, out (IEnumerable<string>, string) value))
                {
                    names.AddRange(value.Item1);
                    description = value.Item2;
                }
                names.Add(cmdAttr.Command);
                names.AddRange(cmdAttr.Aliases);
                specs[key] = (names, description);
            }
        }
        else
        {
            var commandName = type.Name.EndsWith(
                BOT_COMMAND_SUFFIX,
                StringComparison.InvariantCultureIgnoreCase
            )
                ? type.Name.Substring(0, type.Name.Length - BOT_COMMAND_SUFFIX.Length)
                : type.Name;
            commandName = commandName.ToLowerInvariant();
            specs = new Dictionary<string, ValueTuple<IEnumerable<string>, string>>
            {
                { string.Empty, ([commandName], commandName) }
            };
        }

        this.specs = specs;
    }

    /// <inheritdoc />
    public string Command => this.specs[string.Empty].Item1.First();

    /// <inheritdoc />
    public string Description => this.specs[string.Empty].Item2;

    /// <inheritdoc />
    public IEnumerable<string> Aliases => this.specs.SelectMany(pair => pair.Value.Item1);

    /// <inheritdoc />
    public IEnumerable<string> LanguageCodes =>
        this.specs.Keys.Where(key => !string.IsNullOrEmpty(key));

    /// <inheritdoc />
    public string? GetTranslatedName(string languageCode) =>
        this.GetTranslatedEntry(languageCode)?.Item1.First();

    /// <inheritdoc />
    public string? GetTranslatedDescription(string languageCode) =>
        this.GetTranslatedEntry(languageCode)?.Item2;

    private ValueTuple<IEnumerable<string>, string>? GetTranslatedEntry(string languageCode) =>
        this.specs.TryGetValue(languageCode, out var entry) ? entry : null;
}
