// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a video, corresponding to the HTML tag <em>&lt;video&gt;</em>.
/// </summary>
public class InputRichBlockVideo : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “video”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "video";

    /// <summary>
    /// The video. Caption is ignored.
    /// </summary>
    [JsonPropertyName(PropertyNames.Video)]
    public InputMediaVideo Video { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
