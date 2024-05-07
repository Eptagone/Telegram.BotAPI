// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the way a background is filled based on the selected colors. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="BackgroundFillSolid"/></description></item>
/// <item><description><see cref="BackgroundFillGradient"/></description></item>
/// <item><description><see cref="BackgroundFillFreeformGradient"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(BackgroundFillConverter))]
public abstract class BackgroundFill
{
    /// <summary>
    /// Type of the background fill
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
