// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents a chat member that is under certain restrictions in the chat. Supergroups only.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatMemberRestricted : IChatMember
    {
        ///<summary>The member's status in the chat, always “restricted”.</summary>
        [JsonPropertyName(PropertyNames.Status)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status => ChatMemberStatus.Restricted;
        ///<summary>Information about the user.</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        ///<summary>True, if the user is a member of the chat at the moment of the request.</summary>
        [JsonPropertyName(PropertyNames.IsMember)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsMember { get; set; }
        ///<summary>True, if the user is allowed to change the chat title, photo and other settings.</summary>
        [JsonPropertyName(PropertyNames.CanChangeInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanChangeInfo { get; set; }
        ///<summary>True, if the user is allowed to invite new users to the chat.</summary>
        [JsonPropertyName(PropertyNames.CanInviteUsers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanInviteUsers { get; set; }
        ///<summary>True, if the user is allowed to pin messages; groups and supergroups only.</summary>
        [JsonPropertyName(PropertyNames.CanPinMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanPinMessages { get; set; }
        ///<summary>True, if the user is allowed to send text messages, contacts, locations and venues.</summary>
        [JsonPropertyName(PropertyNames.CanSendMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendMessages { get; set; }
        ///<summary>True, if the user is allowed to send audios, documents, photos, videos, video notes and voice notes.</summary>
        [JsonPropertyName(PropertyNames.CanSendMediaMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendMediaMessages { get; set; }
        ///<summary>True, if the user is allowed to send polls.</summary>
        [JsonPropertyName(PropertyNames.CanSendPolls)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendPolls { get; set; }
        ///<summary>True, if the user is allowed to send animations, games, stickers and use inline bots.</summary>
        [JsonPropertyName(PropertyNames.CanSendOtherMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSendOtherMessages { get; set; }
        ///<summary>True, if the user is allowed to add web page previews to their messages.</summary>
        [JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanAddWebPagePreviews { get; set; }
        ///<summary>Date when restrictions will be lifted for this user; unix time.</summary>
        [JsonPropertyName(PropertyNames.UntilDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint UntilDate { get; set; }
    }
}
