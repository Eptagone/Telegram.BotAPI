// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Payments;
using Telegram.BotAPI.Stickers;
using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a message.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Message : ICustomizableReplyMarkup<InlineKeyboardMarkup>, IEquatable<Message>
    {
        /// <summary>Unique message identifier inside this chat.</summary>
        [JsonPropertyName(PropertyNames.MessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MessageId { get; set; }
        /// <summary>Optional. Sender, empty for messages sent to channels.</summary>
        [JsonPropertyName(PropertyNames.From)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User From { get; set; }
        /// <summary>Optional. Sender of the message, sent on behalf of a chat. The channel itself for channel messages. The supergroup itself for messages from anonymous group administrators. The linked channel for messages automatically forwarded to the discussion group.</summary>
        [JsonPropertyName(PropertyNames.SenderChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat SenderChat { get; set; }
        /// <summary>Date the message was sent in Unix time.</summary>
        [JsonPropertyName(PropertyNames.Date)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Date { get; set; }
        /// <summary>Conversation the message belongs to.</summary>
        [JsonPropertyName(PropertyNames.Chat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat Chat { get; set; }
        /// <summary>Optional. For forwarded messages, sender of the original message.</summary>
        [JsonPropertyName(PropertyNames.ForwardFrom)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User ForwardFrom { get; set; }
        /// <summary>Optional. For messages forwarded from channels, information about the original channel.</summary>
        [JsonPropertyName(PropertyNames.ForwardFromChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat ForwardFromChat { get; set; }
        /// <summary>Optional. For messages forwarded from channels, identifier of the original message in the channel.</summary>
        [JsonPropertyName(PropertyNames.ForwardFromMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ForwardFromMessageId { get; set; }
        /// <summary>Optional. For messages forwarded from channels, signature of the post author if present.</summary>
        [JsonPropertyName(PropertyNames.ForwardSignature)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ForwardSignature { get; set; }
        /// <summary>Optional. Sender's name for messages forwarded from users who disallow adding a link to their account in forwarded messages.</summary>
        [JsonPropertyName(PropertyNames.ForwardSenderName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ForwardSenderName { get; set; }
        /// <summary>Optional. For forwarded messages, date the original message was sent in Unix time.</summary>
        [JsonPropertyName(PropertyNames.ForwardDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ForwardDate { get; set; }
        /// <summary>Optional. True, if the message is a channel post that was automatically forwarded to the connected discussion group.</summary>
        [JsonPropertyName(PropertyNames.IsAutomaticForward)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAutomaticForward { get; set; }
        ///<summary>Optional. For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.</summary>
        [JsonPropertyName(PropertyNames.ReplyToMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message ReplyToMessage { get; set; }
        ///<summary>Optional. Bot through which the message was sent.</summary>
        [JsonPropertyName(PropertyNames.ViaBot)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User ViaBot { get; set; }
        ///<summary>Optional. Date the message was last edited in Unix time.</summary>
        [JsonPropertyName(PropertyNames.EditDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint EditDate { get; set; }
        ///<summary>Optional. True, if the message can't be forwarded.</summary>
        [JsonPropertyName(PropertyNames.HasProtectedContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HasProtectedContent { get; set; }
        ///<summary>Optional. The unique identifier of a media message group this message belongs to.</summary>
        [JsonPropertyName(PropertyNames.MediaGroupId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MediaGroupId { get; set; }
        ///<summary>Optional. Signature of the post author for messages in channels.</summary>
        [JsonPropertyName(PropertyNames.AuthorSignature)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AuthorSignature { get; set; }
        ///<summary>Optional. For text messages, the actual UTF-8 text of the message, 0-4096 characters.</summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        ///<summary>Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text.</summary>
        [JsonPropertyName(PropertyNames.Entities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] Entities { get; set; }
        ///<summary>Optional. Message is an animation, information about the animation. For backward compatibility, when this field is set, the document field will also be set.</summary>
        [JsonPropertyName(PropertyNames.Animation)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Animation Animation { get; set; }
        ///<summary>Optional. Message is an audio file, information about the file.</summary>
        [JsonPropertyName(PropertyNames.Audio)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Audio Audio { get; set; }
        ///<summary>Optional. Message is a general file, information about the file.</summary>
        [JsonPropertyName(PropertyNames.Document)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Document Document { get; set; }
        ///<summary>Optional. Message is a photo, available sizes of the photo.</summary>
        [JsonPropertyName(PropertyNames.Photo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize[] Photo { get; set; }
        ///<summary>Optional. Message is a sticker, information about the sticker.</summary>
        [JsonPropertyName(PropertyNames.Sticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Sticker Sticker { get; set; }
        ///<summary>Optional. Message is a video, information about the video.</summary>
        [JsonPropertyName(PropertyNames.Video)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Video Video { get; set; }
        ///<summary>Optional. Message is a video note, information about the video message.</summary>
        [JsonPropertyName(PropertyNames.VideoNote)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VideoNote VideoNote { get; set; }
        ///<summary>Optional. Message is a voice message, information about the file.</summary>
        [JsonPropertyName(PropertyNames.Voice)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Voice Voice { get; set; }
        ///<summary>Optional. Caption for the audio, document, photo, video or voice, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption.</summary>
        [JsonPropertyName(PropertyNames.CaptionEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] CaptionEntities { get; set; }
        ///<summary>Optional. Message is a shared contact, information about the contact.</summary>
        [JsonPropertyName(PropertyNames.Contact)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Contact Contact { get; set; }
        ///<summary>Optional. Message is a dice with random value.</summary>
        [JsonPropertyName(PropertyNames.Dice)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dice Dice { get; set; }
        ///<summary>Optional. Message is a game, information about the game.</summary>
        [JsonPropertyName(PropertyNames.Game)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Game Game { get; set; }
        ///<summary>Optional. Message is a native poll, information about the poll.</summary>
        [JsonPropertyName(PropertyNames.Poll)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Poll Poll { get; set; }
        ///<summary>Optional. Message is a venue, information about the venue.</summary>
        [JsonPropertyName(PropertyNames.Venue)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Venue Venue { get; set; }
        ///<summary>Optional. Message is a shared location, information about the location.</summary>
        [JsonPropertyName(PropertyNames.Location)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
        ///<summary>Optional. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members).</summary>
        [JsonPropertyName(PropertyNames.NewChatMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User[] NewChatMembers { get; set; }
        ///<summary>Optional. A member was removed from the group, information about them (this member may be the bot itself).</summary>
        [JsonPropertyName(PropertyNames.LeftChatMember)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User LeftChatMember { get; set; }
        ///<summary>Optional. A chat title was changed to this value.</summary>
        [JsonPropertyName(PropertyNames.NewChatTitle)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NewChatTitle { get; set; }
        ///<summary>Optional. A chat photo was change to this value.</summary>
        [JsonPropertyName(PropertyNames.NewChatPhoto)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize[] NewChatPhoto { get; set; }
        ///<summary>Optional. Service message: the chat photo was deleted.</summary>
        [JsonPropertyName(PropertyNames.DeleteChatPhoto)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DeleteChatPhoto { get; set; }
        ///<summary>Optional. Service message: the group has been created.</summary>
        [JsonPropertyName(PropertyNames.GroupChatCreated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool GroupChatCreated { get; set; }
        ///<summary>Optional. Service message: the supergroup has been created. This field can‘t be received in a message coming through updates, because bot can’t be a member of a supergroup when it is created. It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.</summary>
        [JsonPropertyName(PropertyNames.SupergroupChatCreated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SupergroupChatCreated { get; set; }
        ///<summary>Optional. Service message: the channel has been created. This field can‘t be received in a message coming through updates, because bot can’t be a member of a channel when it is created. It can only be found in reply_to_message if someone replies to a very first message in a channel.</summary>
        [JsonPropertyName(PropertyNames.ChannelChatCreated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ChannelChatCreated { get; set; }
        ///<summary>Optional. Service message: auto-delete timer settings changed in the chat.</summary>
        [JsonPropertyName(PropertyNames.MessageAutoDeleteTimerChanged)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageAutoDeleteTimerChanged MessageAutoDeleteTimerChanged { get; set; }
        ///<summary>Optional. The group has been migrated to a supergroup with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
        [JsonPropertyName(PropertyNames.MigrateToChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MigrateToChatId { get; set; }
        ///<summary>Optional. The supergroup has been migrated from a group with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
        [JsonPropertyName(PropertyNames.MigrateFromChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MigrateFromChatId { get; set; }
        ///<summary>Optional. Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it is itself a reply.</summary>
        [JsonPropertyName(PropertyNames.PinnedMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message PinnedMessage { get; set; }
        ///<summary>Optional. Message is an invoice for a payment, information about the invoice.</summary>
        [JsonPropertyName(PropertyNames.Invoice)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Invoice Invoice { get; set; }
        ///<summary>Optional. Message is a service message about a successful payment, information about the payment.</summary>
        [JsonPropertyName(PropertyNames.SuccessfulPayment)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SuccessfulPayment SuccessfulPayment { get; set; }
        ///<summary>Optional. The domain name of the website on which the user has logged in.</summary>
        [JsonPropertyName(PropertyNames.ConnectedWebsite)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConnectedWebsite { get; set; }
        ///<summary>Optional. Telegram Passport data.</summary>
        [JsonPropertyName(PropertyNames.PassportData)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportData PassportData { get; set; }
        ///<summary>Optional. Service message. A user in the chat triggered another user's proximity alert while sharing Live Location.</summary>
        [JsonPropertyName(PropertyNames.ProximityAlertTriggered)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ProximityAlertTriggered ProximityAlertTriggered { get; set; }
        ///<summary>Optional. Service message: voice chat scheduled.</summary>
        [JsonPropertyName(PropertyNames.VoiceChatScheduled)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VoiceChatScheduled VoiceChatScheduled { get; set; }
        ///<summary>Optional. Service message: voice chat started.</summary>
        [JsonPropertyName(PropertyNames.VoiceChatStarted)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VoiceChatStarted VoiceChatStarted { get; set; }
        ///<summary>Optional. Service message: voice chat ended.</summary>
        [JsonPropertyName(PropertyNames.VoiceChatEnded)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VoiceChatEnded VoiceChatEnded { get; set; }
        ///<summary>Optional. Service message: new participants invited to a voice chat.</summary>
        [JsonPropertyName(PropertyNames.VoiceChatParticipantsInvited)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VoiceChatParticipantsInvited VoiceChatParticipantsInvited { get; set; }

        ///<summary>Optional. Inline keyboard attached to the message. login_url buttons are represented as ordinary url buttons.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Message);
        }

        public bool Equals(Message other)
        {
            return other != null &&
                   MessageId == other.MessageId &&
                   EqualityComparer<User>.Default.Equals(From, other.From) &&
                   EqualityComparer<Chat>.Default.Equals(SenderChat, other.SenderChat) &&
                   Date == other.Date &&
                   EqualityComparer<Chat>.Default.Equals(Chat, other.Chat) &&
                   EqualityComparer<User>.Default.Equals(ForwardFrom, other.ForwardFrom) &&
                   EqualityComparer<Chat>.Default.Equals(ForwardFromChat, other.ForwardFromChat) &&
                   ForwardFromMessageId == other.ForwardFromMessageId &&
                   ForwardSignature == other.ForwardSignature &&
                   ForwardSenderName == other.ForwardSenderName &&
                   ForwardDate == other.ForwardDate &&
                   IsAutomaticForward == other.IsAutomaticForward &&
                   EqualityComparer<Message>.Default.Equals(ReplyToMessage, other.ReplyToMessage) &&
                   EqualityComparer<User>.Default.Equals(ViaBot, other.ViaBot) &&
                   EditDate == other.EditDate &&
                   HasProtectedContent == other.HasProtectedContent &&
                   MediaGroupId == other.MediaGroupId &&
                   AuthorSignature == other.AuthorSignature &&
                   Text == other.Text &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(Entities, other.Entities) &&
                   EqualityComparer<Animation>.Default.Equals(Animation, other.Animation) &&
                   EqualityComparer<Audio>.Default.Equals(Audio, other.Audio) &&
                   EqualityComparer<Document>.Default.Equals(Document, other.Document) &&
                   EqualityComparer<PhotoSize[]>.Default.Equals(Photo, other.Photo) &&
                   EqualityComparer<Sticker>.Default.Equals(Sticker, other.Sticker) &&
                   EqualityComparer<Video>.Default.Equals(Video, other.Video) &&
                   EqualityComparer<VideoNote>.Default.Equals(VideoNote, other.VideoNote) &&
                   EqualityComparer<Voice>.Default.Equals(Voice, other.Voice) &&
                   Caption == other.Caption &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   EqualityComparer<Contact>.Default.Equals(Contact, other.Contact) &&
                   EqualityComparer<Dice>.Default.Equals(Dice, other.Dice) &&
                   EqualityComparer<Game>.Default.Equals(Game, other.Game) &&
                   EqualityComparer<Poll>.Default.Equals(Poll, other.Poll) &&
                   EqualityComparer<Venue>.Default.Equals(Venue, other.Venue) &&
                   EqualityComparer<Location>.Default.Equals(Location, other.Location) &&
                   EqualityComparer<User[]>.Default.Equals(NewChatMembers, other.NewChatMembers) &&
                   EqualityComparer<User>.Default.Equals(LeftChatMember, other.LeftChatMember) &&
                   NewChatTitle == other.NewChatTitle &&
                   EqualityComparer<PhotoSize[]>.Default.Equals(NewChatPhoto, other.NewChatPhoto) &&
                   DeleteChatPhoto == other.DeleteChatPhoto &&
                   GroupChatCreated == other.GroupChatCreated &&
                   SupergroupChatCreated == other.SupergroupChatCreated &&
                   ChannelChatCreated == other.ChannelChatCreated &&
                   EqualityComparer<MessageAutoDeleteTimerChanged>.Default.Equals(MessageAutoDeleteTimerChanged, other.MessageAutoDeleteTimerChanged) &&
                   MigrateToChatId == other.MigrateToChatId &&
                   MigrateFromChatId == other.MigrateFromChatId &&
                   EqualityComparer<Message>.Default.Equals(PinnedMessage, other.PinnedMessage) &&
                   EqualityComparer<Invoice>.Default.Equals(Invoice, other.Invoice) &&
                   EqualityComparer<SuccessfulPayment>.Default.Equals(SuccessfulPayment, other.SuccessfulPayment) &&
                   ConnectedWebsite == other.ConnectedWebsite &&
                   EqualityComparer<PassportData>.Default.Equals(PassportData, other.PassportData) &&
                   EqualityComparer<ProximityAlertTriggered>.Default.Equals(ProximityAlertTriggered, other.ProximityAlertTriggered) &&
                   EqualityComparer<VoiceChatScheduled>.Default.Equals(VoiceChatScheduled, other.VoiceChatScheduled) &&
                   EqualityComparer<VoiceChatStarted>.Default.Equals(VoiceChatStarted, other.VoiceChatStarted) &&
                   EqualityComparer<VoiceChatEnded>.Default.Equals(VoiceChatEnded, other.VoiceChatEnded) &&
                   EqualityComparer<VoiceChatParticipantsInvited>.Default.Equals(VoiceChatParticipantsInvited, other.VoiceChatParticipantsInvited) &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup);
        }

        public override int GetHashCode()
        {
            int hashCode = -606725346;
            hashCode = hashCode * -1521134295 + MessageId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(From);
            hashCode = hashCode * -1521134295 + EqualityComparer<Chat>.Default.GetHashCode(SenderChat);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Chat>.Default.GetHashCode(Chat);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(ForwardFrom);
            hashCode = hashCode * -1521134295 + EqualityComparer<Chat>.Default.GetHashCode(ForwardFromChat);
            hashCode = hashCode * -1521134295 + ForwardFromMessageId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ForwardSignature);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ForwardSenderName);
            hashCode = hashCode * -1521134295 + ForwardDate.GetHashCode();
            hashCode = hashCode * -1521134295 + IsAutomaticForward.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(ReplyToMessage);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(ViaBot);
            hashCode = hashCode * -1521134295 + EditDate.GetHashCode();
            hashCode = hashCode * -1521134295 + HasProtectedContent.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MediaGroupId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AuthorSignature);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(Entities);
            hashCode = hashCode * -1521134295 + EqualityComparer<Animation>.Default.GetHashCode(Animation);
            hashCode = hashCode * -1521134295 + EqualityComparer<Audio>.Default.GetHashCode(Audio);
            hashCode = hashCode * -1521134295 + EqualityComparer<Document>.Default.GetHashCode(Document);
            hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize[]>.Default.GetHashCode(Photo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Sticker>.Default.GetHashCode(Sticker);
            hashCode = hashCode * -1521134295 + EqualityComparer<Video>.Default.GetHashCode(Video);
            hashCode = hashCode * -1521134295 + EqualityComparer<VideoNote>.Default.GetHashCode(VideoNote);
            hashCode = hashCode * -1521134295 + EqualityComparer<Voice>.Default.GetHashCode(Voice);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<Contact>.Default.GetHashCode(Contact);
            hashCode = hashCode * -1521134295 + EqualityComparer<Dice>.Default.GetHashCode(Dice);
            hashCode = hashCode * -1521134295 + EqualityComparer<Game>.Default.GetHashCode(Game);
            hashCode = hashCode * -1521134295 + EqualityComparer<Poll>.Default.GetHashCode(Poll);
            hashCode = hashCode * -1521134295 + EqualityComparer<Venue>.Default.GetHashCode(Venue);
            hashCode = hashCode * -1521134295 + EqualityComparer<Location>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + EqualityComparer<User[]>.Default.GetHashCode(NewChatMembers);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(LeftChatMember);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NewChatTitle);
            hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize[]>.Default.GetHashCode(NewChatPhoto);
            hashCode = hashCode * -1521134295 + DeleteChatPhoto.GetHashCode();
            hashCode = hashCode * -1521134295 + GroupChatCreated.GetHashCode();
            hashCode = hashCode * -1521134295 + SupergroupChatCreated.GetHashCode();
            hashCode = hashCode * -1521134295 + ChannelChatCreated.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageAutoDeleteTimerChanged>.Default.GetHashCode(MessageAutoDeleteTimerChanged);
            hashCode = hashCode * -1521134295 + MigrateToChatId.GetHashCode();
            hashCode = hashCode * -1521134295 + MigrateFromChatId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(PinnedMessage);
            hashCode = hashCode * -1521134295 + EqualityComparer<Invoice>.Default.GetHashCode(Invoice);
            hashCode = hashCode * -1521134295 + EqualityComparer<SuccessfulPayment>.Default.GetHashCode(SuccessfulPayment);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ConnectedWebsite);
            hashCode = hashCode * -1521134295 + EqualityComparer<PassportData>.Default.GetHashCode(PassportData);
            hashCode = hashCode * -1521134295 + EqualityComparer<ProximityAlertTriggered>.Default.GetHashCode(ProximityAlertTriggered);
            hashCode = hashCode * -1521134295 + EqualityComparer<VoiceChatScheduled>.Default.GetHashCode(VoiceChatScheduled);
            hashCode = hashCode * -1521134295 + EqualityComparer<VoiceChatStarted>.Default.GetHashCode(VoiceChatStarted);
            hashCode = hashCode * -1521134295 + EqualityComparer<VoiceChatEnded>.Default.GetHashCode(VoiceChatEnded);
            hashCode = hashCode * -1521134295 + EqualityComparer<VoiceChatParticipantsInvited>.Default.GetHashCode(VoiceChatParticipantsInvited);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            return hashCode;
        }

        public static bool operator ==(Message left, Message right)
        {
            return EqualityComparer<Message>.Default.Equals(left, right);
        }

        public static bool operator !=(Message left, Message right)
        {
            return !(left == right);
        }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
