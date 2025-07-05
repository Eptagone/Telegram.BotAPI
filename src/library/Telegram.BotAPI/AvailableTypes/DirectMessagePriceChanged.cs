// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a change in the price of direct messages sent to a channel chat.
/// </summary>
public class DirectMessagePriceChanged
{
    /// <summary>
    /// <em>True</em>, if direct messages are enabled for the channel chat; false otherwise
    /// </summary>
    [JsonPropertyName(PropertyNames.AreDirectMessagesEnabled)]
    public bool AreDirectMessagesEnabled { get; set; }

    /// <summary>
    /// Optional. The new number of Telegram Stars that must be paid by users for each direct message sent to the channel. Does not apply to users who have been exempted by administrators. Defaults to 0.
    /// </summary>
    [JsonPropertyName(PropertyNames.DirectMessageStarCount)]
    public int? DirectMessageStarCount { get; set; }
}
