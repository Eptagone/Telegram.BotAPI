// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A collage, corresponding to the custom HTML tag <em>&lt;tg-collage&gt;</em>.
/// </summary>
public class InputRichBlockCollage : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “collage”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "collage";

    /// <summary>
    /// Elements of the collage
    /// </summary>
    [JsonPropertyName(PropertyNames.Blocks)]
    public IEnumerable<InputRichBlock> Blocks { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
