// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A text paragraph, corresponding to the HTML tag <em>&lt;p&gt;</em>.
/// </summary>
public class InputRichBlockParagraph : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “paragraph”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "paragraph";

    /// <summary>
    /// Text of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;
}
