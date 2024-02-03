// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes actions that a non-administrator user is allowed to take in a chat.
/// </summary>
public class ChatPermissions
{
    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send text messages, contacts, giveaways, giveaway winners, invoices, locations and venues
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendMessages)]
    public bool? CanSendMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send audios
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendAudios)]
    public bool? CanSendAudios { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send documents
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendDocuments)]
    public bool? CanSendDocuments { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send photos
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendPhotos)]
    public bool? CanSendPhotos { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send videos
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendVideos)]
    public bool? CanSendVideos { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send video notes
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendVideoNotes)]
    public bool? CanSendVideoNotes { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send voice notes
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendVoiceNotes)]
    public bool? CanSendVoiceNotes { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send polls
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendPolls)]
    public bool? CanSendPolls { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to send animations, games, stickers and use inline bots
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendOtherMessages)]
    public bool? CanSendOtherMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to add web page previews to their messages
    /// </summary>
    [JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
    public bool? CanAddWebPagePreviews { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to change the chat title, photo and other settings. Ignored in public supergroups
    /// </summary>
    [JsonPropertyName(PropertyNames.CanChangeInfo)]
    public bool? CanChangeInfo { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to invite new users to the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.CanInviteUsers)]
    public bool? CanInviteUsers { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to pin messages. Ignored in public supergroups
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPinMessages)]
    public bool? CanPinMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to create forum topics. If omitted defaults to the value of can_pin_messages
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageTopics)]
    public bool? CanManageTopics { get; set; }
}
