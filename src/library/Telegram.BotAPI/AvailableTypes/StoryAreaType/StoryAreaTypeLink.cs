// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a story area pointing to an HTTP or tg:// link. Currently, a story can have up to 3 link areas.
/// </summary>
public class StoryAreaTypeLink : StoryAreaType
{
    /// <summary>
    /// Type of the area, always “link”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "link";

    /// <summary>
    /// HTTP or tg:// URL to be opened when the area is clicked
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; } = null!;
}
