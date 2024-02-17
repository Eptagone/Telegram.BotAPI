// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a boost added to a chat or changed.
/// </summary>
public class ChatBoostUpdated
{
    /// <summary>
    /// Chat which was boosted
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Information about the chat boost
    /// </summary>
    [JsonPropertyName(PropertyNames.Boost)]
    public ChatBoost Boost { get; set; } = null!;
}
