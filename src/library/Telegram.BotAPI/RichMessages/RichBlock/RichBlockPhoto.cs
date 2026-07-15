// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a photo, corresponding to the HTML tag <em>&lt;img&gt;</em>.
/// </summary>
public class RichBlockPhoto : RichBlock
{
    /// <summary>
    /// Type of the block, always “photo”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "photo";

    /// <summary>
    /// Available sizes of the photo
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public IEnumerable<PhotoSize> Photo { get; set; } = null!;

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
