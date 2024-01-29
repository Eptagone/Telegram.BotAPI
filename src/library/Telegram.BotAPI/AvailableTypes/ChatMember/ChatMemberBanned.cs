// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a <a href="https://core.telegram.org/bots/api#chatmember">chat member</a> that was banned in the chat and can't return to the chat or view chat messages.
/// </summary>
public class ChatMemberBanned : ChatMember
{
    /// <summary>
    /// The member's status in the chat, always “kicked”
    /// </summary>
    [JsonPropertyName(PropertyNames.Status)]
    public override string Status => "kicked";

    /// <summary>
    /// Date when restrictions will be lifted for this user; Unix time. If 0, then the user is banned forever
    /// </summary>
    [JsonPropertyName(PropertyNames.UntilDate)]
    public int UntilDate { get; set; }
}
