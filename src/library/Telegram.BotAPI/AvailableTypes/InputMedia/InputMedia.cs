// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the content of a media message to be sent. It should be one of
/// <list type="bullet">
/// <item><description><see cref="InputMediaAnimation"/></description></item>
/// <item><description><see cref="InputMediaAudio"/></description></item>
/// <item><description><see cref="InputMediaDocument"/></description></item>
/// <item><description><see cref="InputMediaLivePhoto"/></description></item>
/// <item><description><see cref="InputMediaPhoto"/></description></item>
/// <item><description><see cref="InputMediaVideo"/></description></item>
/// <item><description><see cref="InputMediaLocation"/></description></item>
/// <item><description><see cref="InputMediaVenue"/></description></item>
/// <item><description><see cref="InputMediaSticker"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputMediaConverter))]
public abstract class InputMedia
{
    /// <summary>
    /// Type of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
