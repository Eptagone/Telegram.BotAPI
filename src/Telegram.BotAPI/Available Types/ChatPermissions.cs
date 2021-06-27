// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Describes actions that a non-administrator user is allowed to take in a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatPermissions : IEquatable<ChatPermissions>
    {
        ///<summary>Optional. True, if the user is allowed to send text messages, contacts, locations and venues.</summary>
        [JsonPropertyName(PropertyNames.CanSendMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendMessages { get; set; }
        ///<summary>Optional. True, if the user is allowed to send audios, documents, photos, videos, video notes and voice notes, implies can_send_messages.</summary>
        [JsonPropertyName(PropertyNames.CanSendMediaMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendMediaMessages { get; set; }
        ///<summary>Optional. True, if the user is allowed to send polls, implies can_send_messages.</summary>
        [JsonPropertyName(PropertyNames.CanSendPolls)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendPolls { get; set; }
        ///<summary>Optional. True, if the user is allowed to send animations, games, stickers and use inline bots, implies can_send_media_messages.</summary>
        [JsonPropertyName(PropertyNames.CanSendOtherMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendOtherMessages { get; set; }
        ///<summary>Optional. True, if the user is allowed to add web page previews to their messages, implies can_send_media_messages.</summary>
        [JsonPropertyName(PropertyNames.CanAddWebPagePreviews)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanAddWebPagePreviews { get; set; }
        ///<summary>Optional. True, if the user is allowed to change the chat title, photo and other settings. Ignored in public supergroups.</summary>
        [JsonPropertyName(PropertyNames.CanChangeInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanChangeInfo { get; set; }
        ///<summary>Optional. True, if the user is allowed to invite new users to the chat.</summary>
        [JsonPropertyName(PropertyNames.CanInviteUsers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanInviteUsers { get; set; }
        ///<summary>Optional. True, if the user is allowed to pin messages. Ignored in public supergroups.</summary>
        [JsonPropertyName(PropertyNames.CanPinMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPinMessages { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ChatPermissions);
        }

        public bool Equals(ChatPermissions other)
        {
            return other != null &&
                   CanSendMessages == other.CanSendMessages &&
                   CanSendMediaMessages == other.CanSendMediaMessages &&
                   CanSendPolls == other.CanSendPolls &&
                   CanSendOtherMessages == other.CanSendOtherMessages &&
                   CanAddWebPagePreviews == other.CanAddWebPagePreviews &&
                   CanChangeInfo == other.CanChangeInfo &&
                   CanInviteUsers == other.CanInviteUsers &&
                   CanPinMessages == other.CanPinMessages;
        }

        public override int GetHashCode()
        {
            int hashCode = 766192183;
            hashCode = hashCode * -1521134295 + CanSendMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSendMediaMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSendPolls.GetHashCode();
            hashCode = hashCode * -1521134295 + CanSendOtherMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + CanAddWebPagePreviews.GetHashCode();
            hashCode = hashCode * -1521134295 + CanChangeInfo.GetHashCode();
            hashCode = hashCode * -1521134295 + CanInviteUsers.GetHashCode();
            hashCode = hashCode * -1521134295 + CanPinMessages.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ChatPermissions left, ChatPermissions right)
        {
            return EqualityComparer<ChatPermissions>.Default.Equals(left, right);
        }

        public static bool operator !=(ChatPermissions left, ChatPermissions right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
