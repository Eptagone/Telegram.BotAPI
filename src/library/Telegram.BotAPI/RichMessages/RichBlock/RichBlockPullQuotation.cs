// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A quotation with centered text, loosely corresponding to the HTML tag <em>&lt;aside&gt;</em>.
/// </summary>
public class RichBlockPullQuotation : RichBlock
{
    /// <summary>
    /// Type of the block, always “pullquote”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "pullquote";

    /// <summary>
    /// Text of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// Optional. Credit of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Credit)]
    public RichText? Credit { get; set; }
}
