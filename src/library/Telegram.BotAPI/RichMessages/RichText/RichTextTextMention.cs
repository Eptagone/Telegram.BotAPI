// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A mention of a Telegram user by their identifier.
/// </summary>
public class RichTextTextMention : RichText
{
    /// <summary>
    /// Type of the rich text, always “text_mention”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "text_mention";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The mentioned user
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;
}
