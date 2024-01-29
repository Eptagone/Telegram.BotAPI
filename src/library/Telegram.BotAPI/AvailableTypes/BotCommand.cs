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
    /// Text of the command; 1-32 characters. Can contain only lowercase English letters, digits and underscores.
    /// </summary>
    [JsonPropertyName(PropertyNames.Command)]
    public string Command { get; set; } = null!;

    /// <summary>
    /// Description of the command; 1-256 characters.
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string Description { get; set; } = null!;
}
