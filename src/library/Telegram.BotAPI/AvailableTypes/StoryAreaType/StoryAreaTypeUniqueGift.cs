// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a story area pointing to a unique gift. Currently, a story can have at most 1 unique gift area.
/// </summary>
public class StoryAreaTypeUniqueGift : StoryAreaType
{
    /// <summary>
    /// Type of the area, always “unique_gift”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "unique_gift";

    /// <summary>
    /// Unique name of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;
}
