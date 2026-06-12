// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A bot command.
/// </summary>
public class RichTextBotCommand : RichText
{
    /// <summary>
    /// Type of the rich text, always “bot_command”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "bot_command";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The bot command
    /// </summary>
    [JsonPropertyName(PropertyNames.BotCommand)]
    public string BotCommand { get; set; } = null!;
}
