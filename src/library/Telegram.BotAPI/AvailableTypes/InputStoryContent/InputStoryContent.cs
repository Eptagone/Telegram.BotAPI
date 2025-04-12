// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the content of a story to post. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="InputStoryContentPhoto"/></description></item>
/// <item><description><see cref="InputStoryContentVideo"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputStoryContentConverter))]
public abstract class InputStoryContent
{
    /// <summary>
    /// Type of the content
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; set; }
}
