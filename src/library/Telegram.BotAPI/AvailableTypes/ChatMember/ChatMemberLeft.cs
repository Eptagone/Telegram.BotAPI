// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a <a href="https://core.telegram.org/bots/api#chatmember">chat member</a> that isn't currently a member of the chat, but may join it themselves.
/// </summary>
public class ChatMemberLeft : ChatMember
{
    /// <summary>
    /// The member's status in the chat, always “left”
    /// </summary>
    [JsonPropertyName(PropertyNames.Status)]
    public override string Status => "left";
}
