// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The boost was obtained by the creation of a Telegram Premium giveaway. This boosts the chat 4 times for the duration of the corresponding Telegram Premium subscription.
/// </summary>
public class ChatBoostSourceGiveaway : ChatBoostSource
{
    /// <summary>
    /// Source of the boost, always “giveaway”
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "giveaway";

    /// <summary>
    /// Identifier of a message in the chat with the giveaway; the message could have been deleted already. May be 0 if the message isn't sent yet.
    /// </summary>
    [JsonPropertyName(PropertyNames.GiveawayMessageId)]
    public int GiveawayMessageId { get; set; }

    /// <summary>
    /// Optional. User that won the prize in the giveaway if any
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User? User { get; set; }

    /// <summary>
    /// Optional. True, if the giveaway was completed, but there was no user to win the prize
    /// </summary>
    [JsonPropertyName(PropertyNames.IsUnclaimed)]
    public bool? IsUnclaimed { get; set; }
}
