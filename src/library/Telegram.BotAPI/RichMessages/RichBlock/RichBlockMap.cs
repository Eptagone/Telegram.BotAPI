// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a map, corresponding to the custom HTML tag <em>&lt;tg-map&gt;</em>.
/// </summary>
public class RichBlockMap : RichBlock
{
    /// <summary>
    /// Type of the block, always “map”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "map";

    /// <summary>
    /// Location of the center of the map
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location Location { get; set; } = null!;

    /// <summary>
    /// Map zoom level; 13-20
    /// </summary>
    [JsonPropertyName(PropertyNames.Zoom)]
    public int Zoom { get; set; }

    /// <summary>
    /// Expected width of the map
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int Width { get; set; }

    /// <summary>
    /// Expected height of the map
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int Height { get; set; }

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
