// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Attribute to define a command for a bot.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class TelegramBotCommandAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TelegramBotCommandAttribute"/> class.
    /// </summary>
    /// <param name="command">Command name.</param>
    /// <param name="description">Command description.</param>
    /// <param name="aliases">Optional. A list of aliases for the command.</param>
    public TelegramBotCommandAttribute(string command, string description, params string[] aliases)
    {
        if (command.Length < 1 || command.Length > 32)
        {
            throw new ArgumentException(
                "Command name must be between 1 and 32 characters.",
                nameof(command)
            );
        }

        this.Command = command;
        this.Description = description;
        this.Aliases = aliases;
    }

    /// <summary>
    /// Command name.
    /// </summary>
    public string Command { get; }

    /// <summary>
    /// Command description.
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// A list of aliases for the command.
    /// </summary>
    public string[] Aliases { get; }

    /// <summary>
    /// Optional. The language code of the command.
    /// </summary>
    public string? LanguageCode { get; set; }
}
