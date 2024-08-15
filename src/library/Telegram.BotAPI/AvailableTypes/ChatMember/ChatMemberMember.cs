// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a <a href="https://core.telegram.org/bots/api#chatmember">chat member</a> that has no additional privileges or restrictions.
/// </summary>
public class ChatMemberMember : ChatMember
{
    /// <summary>
    /// The member's status in the chat, always “member”
    /// </summary>
    [JsonPropertyName(PropertyNames.Status)]
    public override string Status => "member";

    /// <summary>
    /// Optional. Date when the user's subscription will expire; Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.UntilDate)]
    public int? UntilDate { get; set; }
}
