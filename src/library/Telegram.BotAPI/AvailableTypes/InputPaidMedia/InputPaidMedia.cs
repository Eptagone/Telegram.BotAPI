// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the paid media to be sent. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="InputPaidMediaLivePhoto"/></description></item>
/// <item><description><see cref="InputPaidMediaPhoto"/></description></item>
/// <item><description><see cref="InputPaidMediaVideo"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputPaidMediaConverter))]
public abstract class InputPaidMedia
{
    /// <summary>
    /// Type of the media
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }

    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public abstract string Media { get; set; }
}
