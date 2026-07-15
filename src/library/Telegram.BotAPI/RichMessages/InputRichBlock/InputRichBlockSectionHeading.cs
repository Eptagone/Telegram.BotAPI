// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A section heading, corresponding to the HTML tags <em>&lt;h1&gt;</em>, <em>&lt;h2&gt;</em>, <em>&lt;h3&gt;</em>, <em>&lt;h4&gt;</em>, <em>&lt;h5&gt;</em>, or <em>&lt;h6&gt;</em>.
/// </summary>
public class InputRichBlockSectionHeading : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “heading”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "heading";

    /// <summary>
    /// Text of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// Relative size of the text font; 1-6, 1 is the largest, 6 is the smallest
    /// </summary>
    [JsonPropertyName(PropertyNames.Size)]
    public int Size { get; set; }
}
