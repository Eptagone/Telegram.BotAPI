// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A hashtag.
/// </summary>
public class RichTextHashtag : RichText
{
    /// <summary>
    /// Type of the rich text, always “hashtag”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "hashtag";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The hashtag
    /// </summary>
    [JsonPropertyName(PropertyNames.Hashtag)]
    public string Hashtag { get; set; } = null!;
}
