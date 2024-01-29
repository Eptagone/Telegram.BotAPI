// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a list of boosts added to a chat by a user.
/// </summary>
public class UserChatBoosts
{
    /// <summary>
    /// The list of boosts added to the chat by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.Boosts)]
    public IEnumerable<ChatBoost> Boosts { get; set; } = null!;
}
