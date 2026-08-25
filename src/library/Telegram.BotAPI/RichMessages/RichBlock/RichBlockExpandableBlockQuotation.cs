// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block quotation, corresponding to the HTML tag <em>&lt;blockquote&gt;</em> with custom attribute <em>"collapsed"</em>.
/// </summary>
public class RichBlockExpandableBlockQuotation : RichBlock
{
    /// <summary>
    /// Type of the block, always “expandable_blockquote”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "expandable_blockquote";

    /// <summary>
    /// Content of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// Optional. Credit of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Credit)]
    public RichText? Credit { get; set; }
}
