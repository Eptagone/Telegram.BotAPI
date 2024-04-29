// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents a Telegram bot command.
/// Defines additional properties like aliases and possible translations.
/// </summary>
public interface IExtendedBotCommand
{
    /// <summary>
    /// Gets the name of the command.
    /// </summary>
    string Command { get; }

    /// <summary>
    /// Gets the description of the command.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Gets all names that can be used to call the command.
    /// </summary>
    IEnumerable<string> Aliases { get; }

    /// <summary>
    /// A list of language codes in which the command name and description are available.
    /// </summary>
    IEnumerable<string> LanguageCodes { get; }

    /// <summary>
    /// Gets the translated name of the command.
    /// </summary>
    /// <param name="languageCode">The language code of the command.</param>
    /// <returns>The translated name of the command. If the name is not available in the specified language, null is returned.</returns>
    string? GetTranslatedName(string languageCode);

    /// <summary>
    /// Gets the translated description of the command.
    /// </summary>
    /// <param name="languageCode">The language code of the command.</param>
    /// <returns>The translated description of the command. If the description is not available in the specified language, null is returned.</returns>
    string? GetTranslatedDescription(string languageCode);
}
