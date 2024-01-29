// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a message that can be inaccessible to the bot. It can be one of
/// <list type="bullet">
/// <item><description><see cref="Message"/></description></item>
/// <item><description><see cref="InaccessibleMessage"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(MaybeInaccessibleMessageConverter))]
public abstract class MaybeInaccessibleMessage
{
    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public abstract int MessageId { get; set; }

    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public abstract int Date { get; set; }

    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public abstract Chat Chat { get; set; }
}
