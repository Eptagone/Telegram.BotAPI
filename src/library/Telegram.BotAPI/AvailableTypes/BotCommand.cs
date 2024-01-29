// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a bot command.
/// </summary>
public class BotCommand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BotCommand"/> class.
    /// </summary>
    /// <param name="command">Text of the command; 1-32 characters. Can contain only lowercase English letters, digits and underscores.</param>
    /// <param name="description">Description of the command; 1-256 characters.</param>
    public BotCommand(string command, string description)
    {
        this.Command = command ?? throw new ArgumentNullException(nameof(command));
        this.Description = description ?? throw new ArgumentNullException(nameof(description));
    }

    /// <summary>
    /// Text of the command; 1-32 characters. Can contain only lowercase English letters, digits and underscores.
    /// </summary>
    [JsonPropertyName(PropertyNames.Command)]
    public string Command { get; set; }

    /// <summary>
    /// Description of the command; 1-256 characters.
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string Description { get; set; }
}
