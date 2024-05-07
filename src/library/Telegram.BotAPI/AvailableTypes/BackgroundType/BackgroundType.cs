// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the type of a background. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="BackgroundTypeFill"/></description></item>
/// <item><description><see cref="BackgroundTypeWallpaper"/></description></item>
/// <item><description><see cref="BackgroundTypePattern"/></description></item>
/// <item><description><see cref="BackgroundTypeChatTheme"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(BackgroundTypeConverter))]
public abstract class BackgroundType
{
    /// <summary>
    /// Type of the background
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
