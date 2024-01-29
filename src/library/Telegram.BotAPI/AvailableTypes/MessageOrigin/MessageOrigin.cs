// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the origin of a message. It can be one of
/// <list type="bullet">
/// <item><description><see cref="MessageOriginUser"/></description></item>
/// <item><description><see cref="MessageOriginHiddenUser"/></description></item>
/// <item><description><see cref="MessageOriginChat"/></description></item>
/// <item><description><see cref="MessageOriginChannel"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(MessageOriginConverter))]
public abstract class MessageOrigin
{
    /// <summary>
    /// Type of the message origin
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }

    /// <summary>
    /// Date the message was sent originally in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }
}
