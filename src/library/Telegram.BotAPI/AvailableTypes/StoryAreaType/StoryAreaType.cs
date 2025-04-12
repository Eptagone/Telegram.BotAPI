// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the type of a clickable area on a story. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="StoryAreaTypeLocation"/></description></item>
/// <item><description><see cref="StoryAreaTypeSuggestedReaction"/></description></item>
/// <item><description><see cref="StoryAreaTypeLink"/></description></item>
/// <item><description><see cref="StoryAreaTypeWeather"/></description></item>
/// <item><description><see cref="StoryAreaTypeUniqueGift"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StoryAreaTypeConverter))]
public abstract class StoryAreaType
{
    /// <summary>
    /// Type of the area
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
