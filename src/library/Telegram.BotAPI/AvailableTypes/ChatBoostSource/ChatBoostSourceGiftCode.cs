// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The boost was obtained by the creation of Telegram Premium gift codes to boost a chat. Each such code boosts the chat 4 times for the duration of the corresponding Telegram Premium subscription.
/// </summary>
public class ChatBoostSourceGiftCode : ChatBoostSource
{
    /// <summary>
    /// Source of the boost, always “gift_code”
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "gift_code";

    /// <summary>
    /// User for which the gift code was created
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;
}
