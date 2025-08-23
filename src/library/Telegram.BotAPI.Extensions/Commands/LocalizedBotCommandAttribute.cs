// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Extensions.Commands;

/// <summary>
/// Defines a translation for a Telegram bot command.
/// </summary>
/// <param name="languageCode">Language code.</param>
/// <param name="description">Command description.</param>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public sealed class LocalizedBotCommandAttribute(string languageCode, string description)
    : Attribute
{
    /// <summary>
    /// Language code.
    /// </summary>
    public string LanguageCode { get; } = languageCode;

    /// <summary>
    /// Command name.
    /// </summary>
    public string? Command { get; }

    /// <summary>
    /// Command description.
    /// </summary>
    public string Description { get; } = description;

    /// <summary>
    /// Initializes a new instance of the <see cref="LocalizedBotCommandAttribute"/> class.
    /// </summary>
    /// <param name="languageCode">Language code.</param>
    /// <param name="command">Command name.</param>
    /// <param name="description">Command description.</param>
    /// <exception cref="ArgumentException"></exception>
    public LocalizedBotCommandAttribute(string languageCode, string command, string description)
        : this(languageCode, description)
    {
        if (command.Length < 1 || command.Length > 32)
        {
            throw new ArgumentException(
                "Command name must be between 1 and 32 characters.",
                nameof(command)
            );
        }
    }
}
