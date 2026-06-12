// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// An expandable block for details disclosure, corresponding to the HTML tag <em>&lt;details&gt;</em>.
/// </summary>
public class RichBlockDetails : RichBlock
{
    /// <summary>
    /// Type of the block, always “details”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "details";

    /// <summary>
    /// Always shown summary of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Summary)]
    public RichText Summary { get; set; } = null!;

    /// <summary>
    /// Content of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Blocks)]
    public IEnumerable<RichBlock> Blocks { get; set; } = null!;

    /// <summary>
    /// Optional. <em>True</em>, if the content of the block is visible by default
    /// </summary>
    [JsonPropertyName(PropertyNames.IsOpen)]
    public bool? IsOpen { get; set; }
}
