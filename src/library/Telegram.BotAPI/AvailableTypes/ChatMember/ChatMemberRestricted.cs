// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a <a href="https://core.telegram.org/bots/api#chatmember">chat member</a> that is under certain restrictions in the chat. Supergroups only.
/// </summary>
public class ChatMemberRestricted : ChatMember
{
    /// <summary>
    /// The member's status in the chat, always “restricted”
    /// </summary>
    [JsonPropertyName(PropertyNames.Status)]
    public override string Status => "restricted";

    /// <summary>
    /// <em>True</em>, if the user is a member of the chat at the moment of the request
    /// </summary>
    [JsonPropertyName(PropertyNames.IsMember)]
    public bool IsMember { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send text messages, contacts, giveaways, giveaway winners, invoices, locations and venues
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendMessages)]
    public bool CanSendMessages { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send audios
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendAudios)]
    public bool CanSendAudios { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send documents
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendDocuments)]
    public bool CanSendDocuments { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send photos
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendPhotos)]
    public bool CanSendPhotos { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send videos
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendVideos)]
    public bool CanSendVideos { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send video notes
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendVideoNotes)]
    public bool CanSendVideoNotes { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send voice notes
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendVoiceNotes)]
    public bool CanSendVoiceNotes { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send polls
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendPolls)]
    public bool CanSendPolls { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to send animations, games, stickers and use inline bots
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendOtherMessages)]
    public bool CanSendOtherMessages { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to add web page previews to their messages
    /// </summary>
    [JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
    public bool CanAddWebPagePreviews { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to change the chat title, photo and other settings
    /// </summary>
    [JsonPropertyName(PropertyNames.CanChangeInfo)]
    public bool CanChangeInfo { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to invite new users to the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.CanInviteUsers)]
    public bool CanInviteUsers { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to pin messages
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPinMessages)]
    public bool CanPinMessages { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to create forum topics
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageTopics)]
    public bool CanManageTopics { get; set; }

    /// <summary>
    /// Date when restrictions will be lifted for this user; Unix time. If 0, then the user is restricted forever
    /// </summary>
    [JsonPropertyName(PropertyNames.UntilDate)]
    public int UntilDate { get; set; }
}
