// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents changes in the status of a chat member.
/// </summary>
public class ChatMemberUpdated
{
    /// <summary>
    /// Chat the user belongs to
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Performer of the action, which resulted in the change
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User From { get; set; } = null!;

    /// <summary>
    /// Date the change was done in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }

    /// <summary>
    /// Previous information about the chat member
    /// </summary>
    [JsonPropertyName(PropertyNames.OldChatMember)]
    public ChatMember OldChatMember { get; set; } = null!;

    /// <summary>
    /// New information about the chat member
    /// </summary>
    [JsonPropertyName(PropertyNames.NewChatMember)]
    public ChatMember NewChatMember { get; set; } = null!;

    /// <summary>
    /// <em>Optional</em>. Chat invite link, which was used by the user to join the chat; for joining by invite link events only.
    /// </summary>
    [JsonPropertyName(PropertyNames.InviteLink)]
    public ChatInviteLink? InviteLink { get; set; }

    /// <summary>
    /// <em>Optional</em>. True, if the user joined the chat via a chat folder invite link
    /// </summary>
    [JsonPropertyName(PropertyNames.ViaChatFolderInviteLink)]
    public bool? ViaChatFolderInviteLink { get; set; }
}
