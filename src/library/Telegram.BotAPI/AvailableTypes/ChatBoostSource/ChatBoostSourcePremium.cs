// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The boost was obtained by subscribing to Telegram Premium or by gifting a Telegram Premium subscription to another user.
/// </summary>
public class ChatBoostSourcePremium : ChatBoostSource
{
    /// <summary>
    /// Source of the boost, always “premium”
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "premium";

    /// <summary>
    /// User that boosted the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;
}
