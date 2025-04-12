// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a story area pointing to a location. Currently, a story can have up to 10 location areas.
/// </summary>
public class StoryAreaTypeLocation : StoryAreaType
{
    /// <summary>
    /// Type of the area, always “location”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "location";

    /// <summary>
    /// Location latitude in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    public float Latitude { get; set; }

    /// <summary>
    /// Location longitude in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Longitude)]
    public float Longitude { get; set; }

    /// <summary>
    /// Optional. Address of the location
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public LocationAddress? Address { get; set; }
}
