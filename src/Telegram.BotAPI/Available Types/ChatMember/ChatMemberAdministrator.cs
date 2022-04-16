// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable enable

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents a chat member that has some additional privileges.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatMemberAdministrator : ChatMember, IEquatable<ChatMemberAdministrator?>
    {
        ///	<summary>
		///	The member's status in the chat, always “administrator”.
		/// </summary>
        [JsonPropertyName(PropertyNames.Status)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Status => ChatMemberStatus.Administrator;
        /// <summary>
        /// True, if the bot is allowed to edit administrator privileges of that user
        /// </summary>
        [JsonPropertyName(PropertyNames.CanBeEdited)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanBeEdited { get; set; }
        /// <summary>
        /// True, if the user's presence in the chat is hidden
        /// </summary>
        [JsonPropertyName(PropertyNames.IsAnonymous)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAnonymous { get; set; }
        /// <summary>
        /// True, if the administrator can access the chat event log, chat statistics, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege
        /// </summary>
        [JsonPropertyName(PropertyNames.CanManageChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanManageChat { get; set; }
        /// <summary>
        /// True, if the administrator can delete messages of other users
        /// </summary>
        [JsonPropertyName(PropertyNames.CanDeleteMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanDeleteMessages { get; set; }
        /// <summary>
        /// True, if the administrator can manage voice chats.<br/>
        /// [Advice]: This field has been replaced by CanManageVideoChats and will be removed in future releases.
        /// </summary>
        [JsonPropertyName(PropertyNames.CanManageVideoChats)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Obsolete("This field has been replaced by CanManageVideoChats and will be removed in future releases.")]
        public bool? CanManageVoiceChats { get; set; }
        /// <summary>
        /// True, if the administrator can manage video chats
        /// </summary>
        [JsonPropertyName(PropertyNames.CanManageVideoChats)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanManageVideoChats { get; set; }
        /// <summary>
        /// True, if the administrator can restrict, ban or unban chat members
        /// </summary>
        [JsonPropertyName(PropertyNames.CanRestrictMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanRestrictMembers { get; set; }
        /// <summary>
        /// True, if the administrator can add new administrators with a subset of their own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by the user)
        /// </summary>
        [JsonPropertyName(PropertyNames.CanPromoteMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanPromoteMembers { get; set; }
        /// <summary>
        /// True, if the user is allowed to change the chat title, photo and other settings
        /// </summary>
        [JsonPropertyName(PropertyNames.CanChangeInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanChangeInfo { get; set; }
        /// <summary>
        /// True, if the user is allowed to invite new users to the chat
        /// </summary>
        [JsonPropertyName(PropertyNames.CanInviteUsers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanInviteUsers { get; set; }
        /// <summary>
        /// Optional. True, if the administrator can post in the channel; channels only
        /// </summary>
        [JsonPropertyName(PropertyNames.CanPostMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPostMessages { get; set; }
        /// <summary>
        /// Optional. True, if the administrator can edit messages of other users and can pin messages; channels only
        /// </summary>
        [JsonPropertyName(PropertyNames.CanEditMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanEditMessages { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to pin messages; groups and supergroups only
        /// </summary>
        [JsonPropertyName(PropertyNames.CanPinMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPinMessages { get; set; }
        /// <summary>
        /// Optional. Custom title for this user
        /// </summary>
        [JsonPropertyName(PropertyNames.CustomTitle)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? CustomTitle { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object? obj)
        {
            return Equals(obj as ChatMemberAdministrator);
        }

        public bool Equals(ChatMemberAdministrator? other)
        {
            return other != null &&
                   Status == other.Status &&
                   EqualityComparer<User>.Default.Equals(User, other.User) &&
                   Status == other.Status &&
                   EqualityComparer<User>.Default.Equals(User, other.User) &&
                   CanBeEdited == other.CanBeEdited &&
                   IsAnonymous == other.IsAnonymous &&
                   CanManageChat == other.CanManageChat &&
                   CanDeleteMessages == other.CanDeleteMessages &&
                   CanManageVideoChats == other.CanManageVideoChats &&
                   CanRestrictMembers == other.CanRestrictMembers &&
                   CanPromoteMembers == other.CanPromoteMembers &&
                   CanChangeInfo == other.CanChangeInfo &&
                   CanInviteUsers == other.CanInviteUsers &&
                   CanPostMessages == other.CanPostMessages &&
                   CanEditMessages == other.CanEditMessages &&
                   CanPinMessages == other.CanPinMessages &&
                   CustomTitle == other.CustomTitle;
        }

        public override int GetHashCode()
        {
            int hashCode = 1405233358;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + CanBeEdited.GetHashCode();
            hashCode = hashCode * -1521134295 + IsAnonymous.GetHashCode();
            hashCode = hashCode * -1521134295 + CanManageChat.GetHashCode();
            hashCode = hashCode * -1521134295 + CanDeleteMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanManageVideoChats.GetHashCode();
            hashCode = hashCode * -1521134295 + CanRestrictMembers.GetHashCode();
            hashCode = hashCode * -1521134295 + CanPromoteMembers.GetHashCode();
            hashCode = hashCode * -1521134295 + CanChangeInfo.GetHashCode();
            hashCode = hashCode * -1521134295 + CanInviteUsers.GetHashCode();
            hashCode = hashCode * -1521134295 + CanPostMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanEditMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanPinMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(CustomTitle);
            return hashCode;
        }

        public static bool operator ==(ChatMemberAdministrator? left, ChatMemberAdministrator? right)
        {
            return EqualityComparer<ChatMemberAdministrator>.Default.Equals(left, right);
        }

        public static bool operator !=(ChatMemberAdministrator? left, ChatMemberAdministrator? right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
