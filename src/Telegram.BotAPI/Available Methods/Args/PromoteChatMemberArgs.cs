// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>PromoteChatMember method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PromoteChatMemberArgs
    {
        /// <summary>
		/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
		/// </summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        /// <summary>
        /// Unique identifier of the target user
        /// </summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long UserId { get; set; }
        /// <summary>
        /// Pass True if the administrator's presence in the chat is hidden
        /// </summary>
        [JsonPropertyName(PropertyNames.IsAnonymous)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsAnonymous { get; set; }
        /// <summary>
        /// Pass True if the administrator can access the chat event log, chat statistics, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege
        /// </summary>
        [JsonPropertyName(PropertyNames.CanManageChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanManageChat { get; set; }
        /// <summary>
        /// Pass True if the administrator can create channel posts, channels only
        /// </summary>
        [JsonPropertyName(PropertyNames.CanPostMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPostMessages { get; set; }
        /// <summary>
        /// Pass True if the administrator can edit messages of other users and can pin messages, channels only
        /// </summary>
        [JsonPropertyName(PropertyNames.CanEditMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanEditMessages { get; set; }
        /// <summary>
        /// Pass True if the administrator can delete messages of other users
        /// </summary>
        [JsonPropertyName(PropertyNames.CanDeleteMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanDeleteMessages { get; set; }
        /// <summary>
        /// Pass True if the administrator can manage video chats
        /// </summary>
        [JsonPropertyName(PropertyNames.CanManageVideoChats)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanManageVideoChats { get; set; }
        /// <summary>
        /// Pass True if the administrator can restrict, ban or unban chat members
        /// </summary>
        [JsonPropertyName(PropertyNames.CanRestrictMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanRestrictMembers { get; set; }
        /// <summary>
        /// Pass True if the administrator can add new administrators with a subset of their own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him)
        /// </summary>
        [JsonPropertyName(PropertyNames.CanPromoteMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPromoteMembers { get; set; }
        /// <summary>
        /// Pass True if the administrator can change chat title, photo and other settings
        /// </summary>
        [JsonPropertyName(PropertyNames.CanChangeInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanChangeInfo { get; set; }
        /// <summary>
        /// Pass True if the administrator can invite new users to the chat
        /// </summary>
        [JsonPropertyName(PropertyNames.CanInviteUsers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanInviteUsers { get; set; }
        /// <summary>
        /// Pass True if the administrator can pin messages, supergroups only
        /// </summary>
        [JsonPropertyName(PropertyNames.CanPinMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPinMessages { get; set; }
        /// <summary>
        /// Pass True if the user is allowed to create, rename, close, and reopen forum topics, supergroups only
        /// </summary>
        [JsonPropertyName(PropertyNames.CanManageTopics)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanManageTopics { get; set; }
    }
}
