// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a <a href="https://core.telegram.org/bots/api#chatmember">chat member</a> that owns the chat and has all administrator privileges.
/// </summary>
public class ChatMemberOwner : ChatMember
{
    /// <summary>
    /// The member's status in the chat, always “creator”
    /// </summary>
    [JsonPropertyName(PropertyNames.Status)]
    public override string Status => "creator";

    /// <summary>
    /// <em>True</em>, if the user's presence in the chat is hidden
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAnonymous)]
    public bool IsAnonymous { get; set; }

    /// <summary>
    /// Optional. Custom title for this user
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomTitle)]
    public string? CustomTitle { get; set; }
}
