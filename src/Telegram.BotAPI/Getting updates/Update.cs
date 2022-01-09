// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.GettingUpdates
{
    /// <summary>This object represents an incoming update. 
    /// At most one of the optional parameters can be present in any given update.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Update : IEquatable<Update>
    {
        ///<summary>The update‘s unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you’re using Webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order. If there are no new updates for at least a week, then identifier of the next update will be chosen randomly instead of sequentially.</summary>
        [JsonPropertyName(PropertyNames.UpdateId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int UpdateId { get; set; }
        ///<summary>Optional. New incoming message of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName(PropertyNames.Message)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Message { get; set; }
        ///<summary>Optional. New version of a message that is known to the bot and was edited.</summary>
        [JsonPropertyName(PropertyNames.EditedMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message EditedMessage { get; set; }
        ///<summary>Optional. New incoming channel post of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName(PropertyNames.ChannelPost)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message ChannelPost { get; set; }
        ///<summary>Optional. New version of a channel post that is known to the bot and was edited.</summary>
        [JsonPropertyName(PropertyNames.EditedChannelPost)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message EditedChannelPost { get; set; }
        ///<summary>Optional. New incoming inline query.</summary>
        [JsonPropertyName(PropertyNames.InlineQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineQuery InlineQuery { get; set; }
        ///<summary>Optional. The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        [JsonPropertyName(PropertyNames.ChosenInlineResult)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChosenInlineResult ChosenInlineResult { get; set; }
        ///<summary>Optional. New incoming callback query.</summary>
        [JsonPropertyName(PropertyNames.CallbackQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CallbackQuery CallbackQuery { get; set; }
        ///<summary>Optional. New incoming shipping query. Only for invoices with flexible price.</summary>
        [JsonPropertyName(PropertyNames.ShippingQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingQuery ShippingQuery { get; set; }
        ///<summary>Optional. New incoming pre-checkout query. Contains full information about checkout.</summary>
        [JsonPropertyName(PropertyNames.PreCheckoutQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PreCheckoutQuery PreCheckoutQuery { get; set; }
        ///<summary>Optional. New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        [JsonPropertyName(PropertyNames.Poll)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Poll Poll { get; set; }
        ///<summary>Optional. A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.</summary>
        [JsonPropertyName(PropertyNames.PollAnswer)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PollAnswer PollAnswer { get; set; }
        ///<summary>Optional. The bot's chat member status was updated in a chat. For private chats, this update is received only when the bot is blocked or unblocked by the user.</summary>
        [JsonPropertyName(PropertyNames.MyChatMember)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatMemberUpdated MyChatMember { get; set; }
        ///<summary>Optional. A chat member's status was updated in a chat. The bot must be an administrator in the chat and must explicitly specify “chat_member” in the list of allowed_updates to receive these updates.</summary>
        [JsonPropertyName(PropertyNames.ChatMember)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatMemberUpdated ChatMember { get; set; }
        ///<summary>Optional. A request to join the chat has been sent. The bot must have the can_invite_users administrator right in the chat to receive these updates.</summary>
        [JsonPropertyName(PropertyNames.ChatJoinRequest)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatJoinRequest ChatJoinRequest { get; set; }

        /// <summary>Update type.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public UpdateType Type
        {
            get
            {
                if (Message != default)
                {
                    return UpdateType.Message;
                }
                else if (EditedMessage != default)
                {
                    return UpdateType.EditedMessage;
                }
                else if (ChannelPost != default)
                {
                    return UpdateType.ChannelPost;
                }
                else if (EditedChannelPost != default)
                {
                    return UpdateType.EditedChannelPost;
                }
                else if (InlineQuery != default)
                {
                    return UpdateType.InlineQuery;
                }
                else if (ChosenInlineResult != default)
                {
                    return UpdateType.ChosenInlineResult;
                }
                else if (CallbackQuery != default)
                {
                    return UpdateType.CallbackQuery;
                }
                else if (ShippingQuery != default)
                {
                    return UpdateType.ShippingQuery;
                }
                else if (PreCheckoutQuery != default)
                {
                    return UpdateType.PreCheckoutQuery;
                }
                else if (Poll != default)
                {
                    return UpdateType.Poll;
                }
                else if (PollAnswer != default)
                {
                    return UpdateType.PollAnswer;
                }
                else if (MyChatMember != default)
                {
                    return UpdateType.MyChatMember;
                }
                else if (ChatMember != default)
                {
                    return UpdateType.ChatMember;
                }
                else if (ChatJoinRequest != default)
                {
                    return UpdateType.ChatMember;
                }
                else
                {
                    return UpdateType.Unknown;
                }
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Update);
        }

        public bool Equals(Update other)
        {
            return other != null &&
                   UpdateId == other.UpdateId &&
                   EqualityComparer<Message>.Default.Equals(Message, other.Message) &&
                   EqualityComparer<Message>.Default.Equals(EditedMessage, other.EditedMessage) &&
                   EqualityComparer<Message>.Default.Equals(ChannelPost, other.ChannelPost) &&
                   EqualityComparer<Message>.Default.Equals(EditedChannelPost, other.EditedChannelPost) &&
                   EqualityComparer<InlineQuery>.Default.Equals(InlineQuery, other.InlineQuery) &&
                   EqualityComparer<ChosenInlineResult>.Default.Equals(ChosenInlineResult, other.ChosenInlineResult) &&
                   EqualityComparer<CallbackQuery>.Default.Equals(CallbackQuery, other.CallbackQuery) &&
                   EqualityComparer<ShippingQuery>.Default.Equals(ShippingQuery, other.ShippingQuery) &&
                   EqualityComparer<PreCheckoutQuery>.Default.Equals(PreCheckoutQuery, other.PreCheckoutQuery) &&
                   EqualityComparer<Poll>.Default.Equals(Poll, other.Poll) &&
                   EqualityComparer<PollAnswer>.Default.Equals(PollAnswer, other.PollAnswer) &&
                   EqualityComparer<ChatMemberUpdated>.Default.Equals(MyChatMember, other.MyChatMember) &&
                   EqualityComparer<ChatMemberUpdated>.Default.Equals(ChatMember, other.ChatMember) &&
                   EqualityComparer<ChatJoinRequest>.Default.Equals(ChatJoinRequest, other.ChatJoinRequest) &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            int hashCode = 990428338;
            hashCode = hashCode * -1521134295 + UpdateId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(Message);
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(EditedMessage);
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(ChannelPost);
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(EditedChannelPost);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineQuery>.Default.GetHashCode(InlineQuery);
            hashCode = hashCode * -1521134295 + EqualityComparer<ChosenInlineResult>.Default.GetHashCode(ChosenInlineResult);
            hashCode = hashCode * -1521134295 + EqualityComparer<CallbackQuery>.Default.GetHashCode(CallbackQuery);
            hashCode = hashCode * -1521134295 + EqualityComparer<ShippingQuery>.Default.GetHashCode(ShippingQuery);
            hashCode = hashCode * -1521134295 + EqualityComparer<PreCheckoutQuery>.Default.GetHashCode(PreCheckoutQuery);
            hashCode = hashCode * -1521134295 + EqualityComparer<Poll>.Default.GetHashCode(Poll);
            hashCode = hashCode * -1521134295 + EqualityComparer<PollAnswer>.Default.GetHashCode(PollAnswer);
            hashCode = hashCode * -1521134295 + EqualityComparer<ChatMemberUpdated>.Default.GetHashCode(MyChatMember);
            hashCode = hashCode * -1521134295 + EqualityComparer<ChatMemberUpdated>.Default.GetHashCode(ChatMember);
            hashCode = hashCode * -1521134295 + EqualityComparer<ChatJoinRequest>.Default.GetHashCode(ChatJoinRequest);
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Update left, Update right)
        {
            return EqualityComparer<Update>.Default.Equals(left, right);
        }

        public static bool operator !=(Update left, Update right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}