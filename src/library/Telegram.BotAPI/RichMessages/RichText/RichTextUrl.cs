// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A text with a link.
/// </summary>
public class RichTextUrl : RichText
{
    /// <summary>
    /// Type of the rich text, always “url”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "url";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// URL of the link
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; } = null!;
}
