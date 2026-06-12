// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A list of blocks, corresponding to the HTML tag <em>&lt;ul&gt;</em> or <em>&lt;ol&gt;</em> with multiple nested tags <em>&lt;li&gt;</em>.
/// </summary>
public class RichBlockList : RichBlock
{
    /// <summary>
    /// Type of the block, always “list”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "list";

    /// <summary>
    /// Items of the list
    /// </summary>
    [JsonPropertyName(PropertyNames.Items)]
    public IEnumerable<RichBlockListItem> Items { get; set; } = null!;
}
