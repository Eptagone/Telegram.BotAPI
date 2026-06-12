// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with an animation, corresponding to the HTML tag <em>&lt;video&gt;</em>.
/// </summary>
public class RichBlockAnimation : RichBlock
{
    /// <summary>
    /// Type of the block, always “animation”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "animation";

    /// <summary>
    /// The animation
    /// </summary>
    [JsonPropertyName(PropertyNames.Animation)]
    public Animation Animation { get; set; } = null!;

    /// <summary>
    /// Optional. <em>True</em>, if the media preview is covered by a spoiler animation
    /// </summary>
    [JsonPropertyName(PropertyNames.HasSpoiler)]
    public bool? HasSpoiler { get; set; }

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
