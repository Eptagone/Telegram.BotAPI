// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using System;
using System.Linq;
using System.Reflection;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object contains information about one member of a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatMember
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
        public bool? IsAnonymous { get; set; }
        ///<summary>Optional. Administrators only. True, if the bot is allowed to edit administrator privileges of that user.</summary>
        [JsonPropertyName(PropertyNames.CanBeEdited)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanBeEdited { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can access the chat event log, chat statistics, message statistics in channels, see channel members, see anonymous administrators in supergoups and ignore slow mode. Implied by any other administrator privilege.</summary>
        [JsonPropertyName(PropertyNames.CanManageChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanManageChat { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can post in the channel, channels only.</summary>
        [JsonPropertyName(PropertyNames.CanPostMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPostMessages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can edit messages of other users and can pin messages, channels only.</summary>
        [JsonPropertyName(PropertyNames.CanEditMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanEditMessages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can delete messages of other users.</summary>
        [JsonPropertyName(PropertyNames.CanDeleteMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanDeleteMessages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can manage voice chats.</summary>
        [JsonPropertyName(PropertyNames.CanManageVoiceChats)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanManageVoiceChats { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can restrict, ban or unban chat members.</summary>
        [JsonPropertyName(PropertyNames.CanRestrictMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanRestrictMembers { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by the user).</summary>
        [JsonPropertyName(PropertyNames.CanPromoteMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPromoteMembers { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can change the chat title, photo and other settings.</summary>
        [JsonPropertyName(PropertyNames.CanChangeInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanChangeInfo { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can invite new users to the chat.</summary>
        [JsonPropertyName(PropertyNames.CanInviteUsers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanInviteUsers { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can pin messages, supergroups only.</summary>
        [JsonPropertyName(PropertyNames.CanPinMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPinMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is a member of the chat at the moment of the request.</summary>
        [JsonPropertyName(PropertyNames.IsMember)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsMember { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send text messages, contacts, locations and venues.</summary>
        [JsonPropertyName(PropertyNames.CanSendMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send audios, documents, photos, videos, video notes and voice notes, implies can_send_messages.</summary>
        [JsonPropertyName(PropertyNames.CanSendMediaMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendMediaMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is allowed to send polls.</summary>
        [JsonPropertyName(PropertyNames.CanSendPolls)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendPolls { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send animations, games, stickers and use inline bots, implies can_send_media_messages.</summary>
        [JsonPropertyName(PropertyNames.CanSendOtherMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendOtherMessages { get; set; }
        ///<summary>Optional. Restricted only. True, if user may add web page previews to his messages, implies can_send_media_messages.</summary>
        [JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanAddWebPagePreviews { get; set; }
        ///<summary>Optional. Restricted and kicked only. Date when restrictions will be lifted for this user, unix time.</summary>
        [JsonPropertyName(PropertyNames.UntilDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint UntilDate { get; set; }

        /// <summary>Cast this instance into another chat member subclass.</summary>
        /// <typeparam name="TChatMember"></typeparam>
        /// <returns></returns>
        public TChatMember Cast<TChatMember>()
            where TChatMember : IChatMember
        {
            var chatMember = Activator.CreateInstance<TChatMember>();

            var targetMembers = typeof(TChatMember).GetMembers().Where(m => m.MemberType == MemberTypes.Property);
            var myMembers = typeof(ChatMember).GetMembers().Where(m => m.MemberType == MemberTypes.Property);

            var members = myMembers.Where(p => targetMembers.Any(tp => tp.Name == p.Name));

            foreach (var m in members)
            {
                var targetProperty = typeof(TChatMember).GetProperty(m.Name);
                if (targetProperty.CanWrite)
                {
                    var myProperty = typeof(ChatMember).GetProperty(m.Name);
                    var value = myProperty.GetValue(this);
                    targetProperty.SetValue(chatMember, value);
                }
            }

            return chatMember;
        }
    }
}
