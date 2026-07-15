// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A slideshow, corresponding to the custom HTML tag <em>&lt;tg-slideshow&gt;</em>.
/// </summary>
public class InputRichBlockSlideshow : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “slideshow”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "slideshow";

    /// <summary>
    /// Elements of the slideshow
    /// </summary>
    [JsonPropertyName(PropertyNames.Blocks)]
    public IEnumerable<InputRichBlock> Blocks { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
