// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about a user boosting a chat.
/// </summary>
public class ChatBoostAdded
{
    /// <summary>
    /// Number of boosts added by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.BoostCount)]
    public int BoostCount { get; set; }
}
