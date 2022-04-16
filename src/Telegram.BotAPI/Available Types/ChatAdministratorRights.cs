// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Represents the rights of an administrator in a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatAdministratorRights
    {
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
    }
}
