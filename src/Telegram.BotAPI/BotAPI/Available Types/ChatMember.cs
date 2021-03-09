// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object contains information about one member of a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatMember : IEquatable<ChatMember>

    // : ChatPermissions // #NOTE: Can inherit ChatPermissions class
    {
        ///<summary>Information about the user.</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        ///<summary>The member's status in the chat. Can be “creator”, “administrator”, “member”, “restricted”, “left” or “kicked”.</summary>
        [JsonPropertyName(PropertyNames.Status)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        ///<summary>Optional. Owner and administrators only. Custom title for this user.</summary>
        [JsonPropertyName(PropertyNames.CustomTitle)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CustomTitle { get; set; }
        ///<summary>Optional. Owner and administrators only. True, if the user's presence in the chat is hidden.</summary>
        [JsonPropertyName(PropertyNames.IsAnonymous)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAnonymous { get; set; }
        ///<summary>Optional. Administrators only. True, if the bot is allowed to edit administrator privileges of that user.</summary>
        [JsonPropertyName(PropertyNames.CanBeEdited)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanBeEdited { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can access the chat event log, chat statistics, message statistics in channels, see channel members, see anonymous administrators in supergoups and ignore slow mode. Implied by any other administrator privilege.</summary>
        [JsonPropertyName(PropertyNames.CanManageChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanManageChat { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can post in the channel, channels only.</summary>
        [JsonPropertyName(PropertyNames.CanPostMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanPostMessages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can edit messages of other users and can pin messages, channels only.</summary>
        [JsonPropertyName(PropertyNames.CanEditMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanEditMessages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can delete messages of other users.</summary>
        [JsonPropertyName(PropertyNames.CanDeleteMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanDeleteMessages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can manage voice chats.</summary>
        [JsonPropertyName(PropertyNames.CanManageVoiceChats)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanManageVoiceChats { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can restrict, ban or unban chat members.</summary>
        [JsonPropertyName(PropertyNames.CanRestrictMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanRestrictMembers { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by the user).</summary>
        [JsonPropertyName(PropertyNames.CanPromoteMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanPromoteMembers { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can change the chat title, photo and other settings.</summary>
        [JsonPropertyName(PropertyNames.CanChangeInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanChangeInfo { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can invite new users to the chat.</summary>
        [JsonPropertyName(PropertyNames.CanInviteUsers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanInviteUsers { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can pin messages, supergroups only.</summary>
        [JsonPropertyName(PropertyNames.CanPinMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanPinMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is a member of the chat at the moment of the request.</summary>
        [JsonPropertyName(PropertyNames.IsMember)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsMember { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send text messages, contacts, locations and venues.</summary>
        [JsonPropertyName(PropertyNames.CanSendMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send audios, documents, photos, videos, video notes and voice notes, implies can_send_messages.</summary>
        [JsonPropertyName(PropertyNames.CanSendMediaMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendMediaMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is allowed to send polls.</summary>
        [JsonPropertyName(PropertyNames.CanSendPolls)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendPolls { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send animations, games, stickers and use inline bots, implies can_send_media_messages.</summary>
        [JsonPropertyName(PropertyNames.CanSendOtherMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendOtherMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if user may add web page previews to his messages, implies can_send_media_messages.</summary>
        [JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanAddWebPagePreviews { get; set; }
        ///<summary>Optional. Restricted and kicked only. Date when restrictions will be lifted for this user, unix time.</summary>
        [JsonPropertyName(PropertyNames.UntilDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint UntilDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ChatMember);
        }

        public bool Equals(ChatMember other)
        {
            return other != null &&
                   EqualityComparer<User>.Default.Equals(User, other.User) &&
                   Status == other.Status &&
                   CustomTitle == other.CustomTitle &&
                   IsAnonymous == other.IsAnonymous &&
                   CanBeEdited == other.CanBeEdited &&
                   CanManageChat == other.CanManageChat &&
                   CanPostMessages == other.CanPostMessages &&
                   CanEditMessages == other.CanEditMessages &&
                   CanDeleteMessages == other.CanDeleteMessages &&
                   CanManageVoiceChats == other.CanManageVoiceChats &&
                   CanRestrictMembers == other.CanRestrictMembers &&
                   CanPromoteMembers == other.CanPromoteMembers &&
                   CanChangeInfo == other.CanChangeInfo &&
                   CanInviteUsers == other.CanInviteUsers &&
                   CanPinMessages == other.CanPinMessages &&
                   IsMember == other.IsMember &&
                   CanSendMessages == other.CanSendMessages &&
                   CanSendMediaMessages == other.CanSendMediaMessages &&
                   CanSendPolls == other.CanSendPolls &&
                   CanSendOtherMessages == other.CanSendOtherMessages &&
                   CanAddWebPagePreviews == other.CanAddWebPagePreviews &&
                   UntilDate == other.UntilDate;
        }

        public override int GetHashCode()
        {
            int hashCode = 1446341596;
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomTitle);
            hashCode = hashCode * -1521134295 + IsAnonymous.GetHashCode();
            hashCode = hashCode * -1521134295 + CanBeEdited.GetHashCode();
            hashCode = hashCode * -1521134295 + CanManageChat.GetHashCode();
            hashCode = hashCode * -1521134295 + CanPostMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanEditMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanDeleteMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanManageVoiceChats.GetHashCode();
            hashCode = hashCode * -1521134295 + CanRestrictMembers.GetHashCode();
            hashCode = hashCode * -1521134295 + CanPromoteMembers.GetHashCode();
            hashCode = hashCode * -1521134295 + CanChangeInfo.GetHashCode();
            hashCode = hashCode * -1521134295 + CanInviteUsers.GetHashCode();
            hashCode = hashCode * -1521134295 + CanPinMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + IsMember.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSendMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSendMediaMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSendPolls.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSendOtherMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanAddWebPagePreviews.GetHashCode();
            hashCode = hashCode * -1521134295 + UntilDate.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ChatMember left, ChatMember right)
        {
            return EqualityComparer<ChatMember>.Default.Equals(left, right);
        }

        public static bool operator !=(ChatMember left, ChatMember right)
        {
            return !(left == right);
        }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
    ///<summary>The member's status in the chat. Can be “creator”, “administrator”, “member”, “restricted”, “left” or “kicked”.</summary>
    public static class ChatMemberStatus
    {
        ///<summary>Creator.</summary>
        public const string Creator = "creator";
        ///<summary>Administrator.</summary>
        public const string Administrator = "administrator";
        ///<summary>Member.</summary>
        public const string Member = "member";
        ///<summary>Restricted.</summary>
        public const string Restricted = "restricted";
        ///<summary>Left.</summary>
        public const string Left = "left";
        ///<summary>Kicked.</summary>
        public const string Kicked = "kicked";
    }
}