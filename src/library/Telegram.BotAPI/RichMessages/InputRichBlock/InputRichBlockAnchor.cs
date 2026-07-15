// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with an anchor, corresponding to the HTML tag <em>&lt;a&gt;</em> with the attribute <em>name</em>.
/// </summary>
public class InputRichBlockAnchor : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “anchor”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "anchor";

    /// <summary>
    /// The name of the anchor
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;
}
