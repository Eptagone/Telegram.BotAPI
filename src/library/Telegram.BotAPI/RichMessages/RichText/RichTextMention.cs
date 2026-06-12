// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A mention by a username.
/// </summary>
public class RichTextMention : RichText
{
    /// <summary>
    /// Type of the rich text, always “mention”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "mention";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The username
    /// </summary>
    [JsonPropertyName(PropertyNames.Username)]
    public string Username { get; set; } = null!;
}
