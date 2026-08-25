// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a map, corresponding to the custom HTML tag <em>&lt;tg-map&gt;</em>. The map's width and height must not exceed 10000 in total. The width and height ratio must be at most 20.
/// </summary>
public class InputRichBlockMap : InputRichBlock
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
    /// Optional. Map zoom level; 0-24
    /// </summary>
    [JsonPropertyName(PropertyNames.Zoom)]
    public int? Zoom { get; set; }

    /// <summary>
    /// Optional. Map width; 0-10000
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int? Width { get; set; }

    /// <summary>
    /// Optional. Map height; 0-10000
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int? Height { get; set; }

    /// <summary>
    /// Optional. Caption of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public RichBlockCaption? Caption { get; set; }
}
