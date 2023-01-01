// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Payments;
using Telegram.BotAPI.Stickers;
using Telegram.BotAPI.TelegramPassport;


namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a message.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class Message : ICustomizableReplyMarkup<InlineKeyboardMarkup>, IEquatable<Message?>
	{
		/// <summary>
		/// Unique message identifier inside this chat
		/// </summary>
		[JsonPropertyName(PropertyNames.MessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int MessageId { get; set; }
		/// <summary>
		/// Date the message was sent in Unix time
		/// </summary>
		[JsonPropertyName(PropertyNames.Date)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Date { get; set; }
		/// <summary>
		/// Conversation the message belongs to
		/// </summary>
		[JsonPropertyName(PropertyNames.Chat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Chat Chat { get; set; }
		/// <summary>
		/// Optional. Unique identifier of a message thread to which the message belongs; for supergroups only
		/// </summary>
		[JsonPropertyName(PropertyNames.MessageThreadId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int? MessageThreadId { get; set; }
		/// <summary>
		/// Optional. Sender of the message; empty for messages sent to channels. For backward compatibility, the field contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
		/// </summary>
		[JsonPropertyName(PropertyNames.From)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User? From { get; set; }
		/// <summary>
		/// Optional. Sender of the message, sent on behalf of a chat. For example, the channel itself for channel posts, the supergroup itself for messages from anonymous group administrators, the linked channel for messages automatically forwarded to the discussion group. For backward compatibility, the field from contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
		/// </summary>
		[JsonPropertyName(PropertyNames.SenderChat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Chat? SenderChat { get; set; }
		/// <summary>
		/// Optional. For forwarded messages, sender of the original message
		/// </summary>
		[JsonPropertyName(PropertyNames.ForwardFrom)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User? ForwardFrom { get; set; }
		/// <summary>
		/// Optional. For messages forwarded from channels or from anonymous administrators, information about the original sender chat
		/// </summary>
		[JsonPropertyName(PropertyNames.ForwardFromChat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Chat? ForwardFromChat { get; set; }
		/// <summary>
		/// Optional. For messages forwarded from channels, identifier of the original message in the channel
		/// </summary>
		[JsonPropertyName(PropertyNames.ForwardFromMessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int? ForwardFromMessageId { get; set; }
		/// <summary>
		/// Optional. For forwarded messages that were originally sent in channels or by an anonymous chat administrator, signature of the message sender if present
		/// </summary>
		[JsonPropertyName(PropertyNames.ForwardSignature)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ForwardSignature { get; set; }
		/// <summary>
		/// Optional. Sender's name for messages forwarded from users who disallow adding a link to their account in forwarded messages
		/// </summary>
		[JsonPropertyName(PropertyNames.ForwardSenderName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ForwardSenderName { get; set; }
		/// <summary>
		/// Optional. For forwarded messages, date the original message was sent in Unix time
		/// </summary>
		[JsonPropertyName(PropertyNames.ForwardDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? ForwardDate { get; set; }
		/// <summary>
		/// Optional. True, if the message is sent to a forum topic
		/// </summary>
		[JsonPropertyName(PropertyNames.IsTopicMessage)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? IsTopicMessage { get; set; }
		/// <summary>
		/// Optional. True, if the message is a channel post that was automatically forwarded to the connected discussion group
		/// </summary>
		[JsonPropertyName(PropertyNames.IsAutomaticForward)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? IsAutomaticForward { get; set; }
		/// <summary>
		/// Optional. For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
		/// </summary>
		[JsonPropertyName(PropertyNames.ReplyToMessage)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Message? ReplyToMessage { get; set; }
		/// <summary>
		/// Optional. Bot through which the message was sent
		/// </summary>
		[JsonPropertyName(PropertyNames.ViaBot)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User? ViaBot { get; set; }
		/// <summary>
		/// Optional. Date the message was last edited in Unix time
		/// </summary>
		[JsonPropertyName(PropertyNames.EditDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? EditDate { get; set; }
		/// <summary>
		/// Optional. True, if the message can't be forwarded
		/// </summary>
		[JsonPropertyName(PropertyNames.HasProtectedContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? HasProtectedContent { get; set; }
		/// <summary>
		/// Optional. The unique identifier of a media message group this message belongs to
		/// </summary>
		[JsonPropertyName(PropertyNames.MediaGroupId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? MediaGroupId { get; set; }
		/// <summary>
		/// Optional. Signature of the post author for messages in channels, or the custom title of an anonymous group administrator
		/// </summary>
		[JsonPropertyName(PropertyNames.AuthorSignature)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? AuthorSignature { get; set; }
		/// <summary>
		/// Optional. For text messages, the actual UTF-8 text of the message
		/// </summary>
		[JsonPropertyName(PropertyNames.Text)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Text { get; set; }
		/// <summary>
		/// Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text
		/// </summary>
		[JsonPropertyName(PropertyNames.Entities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? Entities { get; set; }
		/// <summary>
		/// Optional. Message is an animation, information about the animation. For backward compatibility, when this field is set, the document field will also be set
		/// </summary>
		[JsonPropertyName(PropertyNames.Animation)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Animation? Animation { get; set; }
		/// <summary>
		/// Optional. Message is an audio file, information about the file
		/// </summary>
		[JsonPropertyName(PropertyNames.Audio)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Audio? Audio { get; set; }
		/// <summary>
		/// Optional. Message is a general file, information about the file
		/// </summary>
		[JsonPropertyName(PropertyNames.Document)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Document? Document { get; set; }
		/// <summary>
		/// Optional. Message is a photo, available sizes of the photo
		/// </summary>
		[JsonPropertyName(PropertyNames.Photo)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize[]? Photo { get; set; }
		/// <summary>
		/// Optional. Message is a sticker, information about the sticker
		/// </summary>
		[JsonPropertyName(PropertyNames.Sticker)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Sticker? Sticker { get; set; }
		/// <summary>
		/// Optional. Message is a video, information about the video
		/// </summary>
		[JsonPropertyName(PropertyNames.Video)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Video? Video { get; set; }
		/// <summary>
		/// Optional. Message is a video note, information about the video message
		/// </summary>
		[JsonPropertyName(PropertyNames.VideoNote)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public VideoNote? VideoNote { get; set; }
		/// <summary>
		/// Optional. Message is a voice message, information about the file
		/// </summary>
		[JsonPropertyName(PropertyNames.Voice)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Voice? Voice { get; set; }
		/// <summary>
		/// Optional. Caption for the animation, audio, document, photo, video or voice
		/// </summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>
		/// Optional. For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption
		/// </summary>
		[JsonPropertyName(PropertyNames.CaptionEntities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
		/// <summary>
		/// Optional. True, if the message media is covered by a spoiler animation
		/// </summary>
		[JsonPropertyName(PropertyNames.HasMediaSpoiler)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? HasMediaSpoiler { get; set; }
		/// <summary>
		/// Optional. Message is a shared contact, information about the contact
		/// </summary>
		[JsonPropertyName(PropertyNames.Contact)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Contact? Contact { get; set; }
		/// <summary>
		/// Optional. Message is a dice with random value
		/// </summary>
		[JsonPropertyName(PropertyNames.Dice)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Dice? Dice { get; set; }
		/// <summary>
		/// Optional. Message is a game, information about the game. More about games »
		/// </summary>
		[JsonPropertyName(PropertyNames.Game)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Game? Game { get; set; }
		/// <summary>
		/// Optional. Message is a native poll, information about the poll
		/// </summary>
		[JsonPropertyName(PropertyNames.Poll)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Poll? Poll { get; set; }
		/// <summary>
		/// Optional. Message is a venue, information about the venue. For backward compatibility, when this field is set, the location field will also be set
		/// </summary>
		[JsonPropertyName(PropertyNames.Venue)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Venue? Venue { get; set; }
		/// <summary>
		/// Optional. Message is a shared location, information about the location
		/// </summary>
		[JsonPropertyName(PropertyNames.Location)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Location? Location { get; set; }
		/// <summary>
		/// Optional. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members)
		/// </summary>
		[JsonPropertyName(PropertyNames.NewChatMembers)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User[]? NewChatMembers { get; set; }
		/// <summary>
		/// Optional. A member was removed from the group, information about them (this member may be the bot itself)
		/// </summary>
		[JsonPropertyName(PropertyNames.LeftChatMember)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User? LeftChatMember { get; set; }
		/// <summary>
		/// Optional. A chat title was changed to this value
		/// </summary>
		[JsonPropertyName(PropertyNames.NewChatTitle)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? NewChatTitle { get; set; }
		/// <summary>
		/// Optional. A chat photo was change to this value
		/// </summary>
		[JsonPropertyName(PropertyNames.NewChatPhoto)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize[]? NewChatPhoto { get; set; }
		/// <summary>
		/// Optional. Service message: the chat photo was deleted
		/// </summary>
		[JsonPropertyName(PropertyNames.DeleteChatPhoto)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? DeleteChatPhoto { get; set; }
		/// <summary>
		/// Optional. Service message: the group has been created
		/// </summary>
		[JsonPropertyName(PropertyNames.GroupChatCreated)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? GroupChatCreated { get; set; }
		/// <summary>
		/// Optional. Service message: the supergroup has been created. This field can't be received in a message coming through updates, because bot can't be a member of a supergroup when it is created. It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.
		/// </summary>
		[JsonPropertyName(PropertyNames.SupergroupChatCreated)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? SupergroupChatCreated { get; set; }
		/// <summary>
		/// Optional. Service message: the channel has been created. This field can't be received in a message coming through updates, because bot can't be a member of a channel when it is created. It can only be found in reply_to_message if someone replies to a very first message in a channel.
		/// </summary>
		[JsonPropertyName(PropertyNames.ChannelChatCreated)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? ChannelChatCreated { get; set; }
		/// <summary>
		/// Optional. Service message: auto-delete timer settings changed in the chat
		/// </summary>
		[JsonPropertyName(PropertyNames.MessageAutoDeleteTimerChanged)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public MessageAutoDeleteTimerChanged? MessageAutoDeleteTimerChanged { get; set; }
		/// <summary>
		/// Optional. The group has been migrated to a supergroup with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
		/// </summary>
		[JsonPropertyName(PropertyNames.MigrateToChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long? MigrateToChatId { get; set; }
		/// <summary>
		/// Optional. The supergroup has been migrated from a group with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
		/// </summary>
		[JsonPropertyName(PropertyNames.MigrateFromChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long? MigrateFromChatId { get; set; }
		/// <summary>
		/// Optional. Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it is itself a reply.
		/// </summary>
		[JsonPropertyName(PropertyNames.PinnedMessage)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Message? PinnedMessage { get; set; }
		/// <summary>
		/// Optional. Message is an invoice for a payment, information about the invoice. More about payments »
		/// </summary>
		[JsonPropertyName(PropertyNames.Invoice)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Invoice? Invoice { get; set; }
		/// <summary>
		/// Optional. Message is a service message about a successful payment, information about the payment. More about payments »
		/// </summary>
		[JsonPropertyName(PropertyNames.SuccessfulPayment)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public SuccessfulPayment? SuccessfulPayment { get; set; }
		/// <summary>
		/// Optional. The domain name of the website on which the user has logged in. More about Telegram Login »
		/// </summary>
		[JsonPropertyName(PropertyNames.ConnectedWebsite)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ConnectedWebsite { get; set; }
		/// <summary>
		/// Optional. Service message: the user allowed the bot added to the attachment menu to write messages
		/// </summary>
		[JsonPropertyName(PropertyNames.WriteAccessAllowed)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public WriteAccessAllowed? WriteAccessAllowed { get; set; }
		/// <summary>
		/// Optional. Telegram Passport data
		/// </summary>
		[JsonPropertyName(PropertyNames.PassportData)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PassportData? PassportData { get; set; }
		/// <summary>
		/// Optional. Service message. A user in the chat triggered another user's proximity alert while sharing Live Location.
		/// </summary>
		[JsonPropertyName(PropertyNames.ProximityAlertTriggered)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ProximityAlertTriggered? ProximityAlertTriggered { get; set; }
		/// <summary>
		/// Optional. Service message: forum topic created
		/// </summary>
		[JsonPropertyName(PropertyNames.ForumTopicCreated)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ForumTopicCreated? ForumTopicCreated { get; set; }
		/// <summary>
		/// Optional. Service message: forum topic edited
		/// </summary>
		[JsonPropertyName(PropertyNames.ForumTopicEdited)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ForumTopicEdited? ForumTopicEdited { get; set; }
		/// <summary>
		/// Optional. Service message: forum topic closed
		/// </summary>
		[JsonPropertyName(PropertyNames.ForumTopicClosed)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ForumTopicClosed? ForumTopicClosed { get; set; }
		/// <summary>
		/// Optional. Service message: forum topic reopened
		/// </summary>
		[JsonPropertyName(PropertyNames.ForumTopicReopened)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ForumTopicReopened? ForumTopicReopened { get; set; }
		/// <summary>
		/// Optional. Service message: the 'General' forum topic hidden
		/// </summary>
		[JsonPropertyName(PropertyNames.GeneralForumTopicHidden)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public GeneralForumTopicHidden? GeneralForumTopicHidden { get; set; }
		/// <summary>
		/// Optional. Service message: the 'General' forum topic unhidden
		/// </summary>
		[JsonPropertyName(PropertyNames.GeneralForumTopicUnhidden)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public GeneralForumTopicUnhidden? GeneralForumTopicUnhidden { get; set; }
		/// <summary>
		/// Optional. Service message: video chat scheduled
		/// </summary>
		[JsonPropertyName(PropertyNames.VideoChatScheduled)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public VideoChatScheduled? VideoChatScheduled { get; set; }
		/// <summary>
		/// Optional. Service message: video chat started
		/// </summary>
		[JsonPropertyName(PropertyNames.VideoChatStarted)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public VideoChatStarted? VideoChatStarted { get; set; }
		/// <summary>
		/// Optional. Service message: video chat ended
		/// </summary>
		[JsonPropertyName(PropertyNames.VideoChatEnded)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public VideoChatEnded? VideoChatEnded { get; set; }
		/// <summary>
		/// Optional. Service message: new participants invited to a video chat
		/// </summary>
		[JsonPropertyName(PropertyNames.VideoChatParticipantsInvited)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public VideoChatParticipantsInvited? VideoChatParticipantsInvited { get; set; }
		/// <summary>
		/// Optional. Service message: data sent by a Web App
		/// </summary>
		[JsonPropertyName(PropertyNames.WebAppData)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public WebAppData? WebAppData { get; set; }
		/// <summary>
		/// Optional. Inline keyboard attached to the message. login_url buttons are represented as ordinary url buttons.
		/// </summary>
		[JsonPropertyName(PropertyNames.ReplyMarkup)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InlineKeyboardMarkup? ReplyMarkup { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as Message);
		}
		/// <inheritdoc/>
		public bool Equals(Message? other)
		{
			return other is not null &&
				   this.MessageId == other.MessageId &&
				   this.Date == other.Date &&
				   EqualityComparer<Chat>.Default.Equals(this.Chat, other.Chat) &&
				   this.MessageThreadId == other.MessageThreadId &&
				   EqualityComparer<User?>.Default.Equals(this.From, other.From) &&
				   EqualityComparer<Chat?>.Default.Equals(this.SenderChat, other.SenderChat) &&
				   EqualityComparer<User?>.Default.Equals(this.ForwardFrom, other.ForwardFrom) &&
				   EqualityComparer<Chat?>.Default.Equals(this.ForwardFromChat, other.ForwardFromChat) &&
				   this.ForwardFromMessageId == other.ForwardFromMessageId &&
				   this.ForwardSignature == other.ForwardSignature &&
				   this.ForwardSenderName == other.ForwardSenderName &&
				   this.ForwardDate == other.ForwardDate &&
				   this.IsTopicMessage == other.IsTopicMessage &&
				   this.IsAutomaticForward == other.IsAutomaticForward &&
				   EqualityComparer<Message?>.Default.Equals(this.ReplyToMessage, other.ReplyToMessage) &&
				   EqualityComparer<User?>.Default.Equals(this.ViaBot, other.ViaBot) &&
				   this.EditDate == other.EditDate &&
				   this.HasProtectedContent == other.HasProtectedContent &&
				   this.MediaGroupId == other.MediaGroupId &&
				   this.AuthorSignature == other.AuthorSignature &&
				   this.Text == other.Text &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.Entities, other.Entities) &&
				   EqualityComparer<Animation?>.Default.Equals(this.Animation, other.Animation) &&
				   EqualityComparer<Audio?>.Default.Equals(this.Audio, other.Audio) &&
				   EqualityComparer<Document?>.Default.Equals(this.Document, other.Document) &&
				   EqualityComparer<PhotoSize[]?>.Default.Equals(this.Photo, other.Photo) &&
				   EqualityComparer<Sticker?>.Default.Equals(this.Sticker, other.Sticker) &&
				   EqualityComparer<Video?>.Default.Equals(this.Video, other.Video) &&
				   EqualityComparer<VideoNote?>.Default.Equals(this.VideoNote, other.VideoNote) &&
				   EqualityComparer<Voice?>.Default.Equals(this.Voice, other.Voice) &&
				   this.Caption == other.Caption &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.HasMediaSpoiler == other.HasMediaSpoiler &&
				   EqualityComparer<Contact?>.Default.Equals(this.Contact, other.Contact) &&
				   EqualityComparer<Dice?>.Default.Equals(this.Dice, other.Dice) &&
				   EqualityComparer<Game?>.Default.Equals(this.Game, other.Game) &&
				   EqualityComparer<Poll?>.Default.Equals(this.Poll, other.Poll) &&
				   EqualityComparer<Venue?>.Default.Equals(this.Venue, other.Venue) &&
				   EqualityComparer<Location?>.Default.Equals(this.Location, other.Location) &&
				   EqualityComparer<User[]?>.Default.Equals(this.NewChatMembers, other.NewChatMembers) &&
				   EqualityComparer<User?>.Default.Equals(this.LeftChatMember, other.LeftChatMember) &&
				   this.NewChatTitle == other.NewChatTitle &&
				   EqualityComparer<PhotoSize[]?>.Default.Equals(this.NewChatPhoto, other.NewChatPhoto) &&
				   this.DeleteChatPhoto == other.DeleteChatPhoto &&
				   this.GroupChatCreated == other.GroupChatCreated &&
				   this.SupergroupChatCreated == other.SupergroupChatCreated &&
				   this.ChannelChatCreated == other.ChannelChatCreated &&
				   EqualityComparer<MessageAutoDeleteTimerChanged?>.Default.Equals(this.MessageAutoDeleteTimerChanged, other.MessageAutoDeleteTimerChanged) &&
				   this.MigrateToChatId == other.MigrateToChatId &&
				   this.MigrateFromChatId == other.MigrateFromChatId &&
				   EqualityComparer<Message?>.Default.Equals(this.PinnedMessage, other.PinnedMessage) &&
				   EqualityComparer<Invoice?>.Default.Equals(this.Invoice, other.Invoice) &&
				   EqualityComparer<SuccessfulPayment?>.Default.Equals(this.SuccessfulPayment, other.SuccessfulPayment) &&
				   this.ConnectedWebsite == other.ConnectedWebsite &&
				   EqualityComparer<WriteAccessAllowed?>.Default.Equals(this.WriteAccessAllowed, other.WriteAccessAllowed) &&
				   EqualityComparer<PassportData?>.Default.Equals(this.PassportData, other.PassportData) &&
				   EqualityComparer<ProximityAlertTriggered?>.Default.Equals(this.ProximityAlertTriggered, other.ProximityAlertTriggered) &&
				   EqualityComparer<ForumTopicCreated?>.Default.Equals(this.ForumTopicCreated, other.ForumTopicCreated) &&
				   EqualityComparer<ForumTopicEdited?>.Default.Equals(this.ForumTopicEdited, other.ForumTopicEdited) &&
				   EqualityComparer<ForumTopicClosed?>.Default.Equals(this.ForumTopicClosed, other.ForumTopicClosed) &&
				   EqualityComparer<ForumTopicReopened?>.Default.Equals(this.ForumTopicReopened, other.ForumTopicReopened) &&
				   EqualityComparer<GeneralForumTopicHidden?>.Default.Equals(this.GeneralForumTopicHidden, other.GeneralForumTopicHidden) &&
				   EqualityComparer<GeneralForumTopicUnhidden?>.Default.Equals(this.GeneralForumTopicUnhidden, other.GeneralForumTopicUnhidden) &&
				   EqualityComparer<VideoChatScheduled?>.Default.Equals(this.VideoChatScheduled, other.VideoChatScheduled) &&
				   EqualityComparer<VideoChatStarted?>.Default.Equals(this.VideoChatStarted, other.VideoChatStarted) &&
				   EqualityComparer<VideoChatEnded?>.Default.Equals(this.VideoChatEnded, other.VideoChatEnded) &&
				   EqualityComparer<VideoChatParticipantsInvited?>.Default.Equals(this.VideoChatParticipantsInvited, other.VideoChatParticipantsInvited) &&
				   EqualityComparer<WebAppData?>.Default.Equals(this.WebAppData, other.WebAppData) &&
				   EqualityComparer<InlineKeyboardMarkup?>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1776188689;
			hashCode = hashCode * -1521134295 + this.MessageId.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Date.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<Chat>.Default.GetHashCode(this.Chat);
			hashCode = hashCode * -1521134295 + this.MessageThreadId.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<User?>.Default.GetHashCode(this.From);
			hashCode = hashCode * -1521134295 + EqualityComparer<Chat?>.Default.GetHashCode(this.SenderChat);
			hashCode = hashCode * -1521134295 + EqualityComparer<User?>.Default.GetHashCode(this.ForwardFrom);
			hashCode = hashCode * -1521134295 + EqualityComparer<Chat?>.Default.GetHashCode(this.ForwardFromChat);
			hashCode = hashCode * -1521134295 + this.ForwardFromMessageId.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ForwardSignature);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ForwardSenderName);
			hashCode = hashCode * -1521134295 + this.ForwardDate.GetHashCode();
			hashCode = hashCode * -1521134295 + this.IsTopicMessage.GetHashCode();
			hashCode = hashCode * -1521134295 + this.IsAutomaticForward.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<Message?>.Default.GetHashCode(this.ReplyToMessage);
			hashCode = hashCode * -1521134295 + EqualityComparer<User?>.Default.GetHashCode(this.ViaBot);
			hashCode = hashCode * -1521134295 + this.EditDate.GetHashCode();
			hashCode = hashCode * -1521134295 + this.HasProtectedContent.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.MediaGroupId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.AuthorSignature);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Text);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.Entities);
			hashCode = hashCode * -1521134295 + EqualityComparer<Animation?>.Default.GetHashCode(this.Animation);
			hashCode = hashCode * -1521134295 + EqualityComparer<Audio?>.Default.GetHashCode(this.Audio);
			hashCode = hashCode * -1521134295 + EqualityComparer<Document?>.Default.GetHashCode(this.Document);
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize[]?>.Default.GetHashCode(this.Photo);
			hashCode = hashCode * -1521134295 + EqualityComparer<Sticker?>.Default.GetHashCode(this.Sticker);
			hashCode = hashCode * -1521134295 + EqualityComparer<Video?>.Default.GetHashCode(this.Video);
			hashCode = hashCode * -1521134295 + EqualityComparer<VideoNote?>.Default.GetHashCode(this.VideoNote);
			hashCode = hashCode * -1521134295 + EqualityComparer<Voice?>.Default.GetHashCode(this.Voice);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + this.HasMediaSpoiler.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<Contact?>.Default.GetHashCode(this.Contact);
			hashCode = hashCode * -1521134295 + EqualityComparer<Dice?>.Default.GetHashCode(this.Dice);
			hashCode = hashCode * -1521134295 + EqualityComparer<Game?>.Default.GetHashCode(this.Game);
			hashCode = hashCode * -1521134295 + EqualityComparer<Poll?>.Default.GetHashCode(this.Poll);
			hashCode = hashCode * -1521134295 + EqualityComparer<Venue?>.Default.GetHashCode(this.Venue);
			hashCode = hashCode * -1521134295 + EqualityComparer<Location?>.Default.GetHashCode(this.Location);
			hashCode = hashCode * -1521134295 + EqualityComparer<User[]?>.Default.GetHashCode(this.NewChatMembers);
			hashCode = hashCode * -1521134295 + EqualityComparer<User?>.Default.GetHashCode(this.LeftChatMember);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.NewChatTitle);
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize[]?>.Default.GetHashCode(this.NewChatPhoto);
			hashCode = hashCode * -1521134295 + this.DeleteChatPhoto.GetHashCode();
			hashCode = hashCode * -1521134295 + this.GroupChatCreated.GetHashCode();
			hashCode = hashCode * -1521134295 + this.SupergroupChatCreated.GetHashCode();
			hashCode = hashCode * -1521134295 + this.ChannelChatCreated.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<MessageAutoDeleteTimerChanged?>.Default.GetHashCode(this.MessageAutoDeleteTimerChanged);
			hashCode = hashCode * -1521134295 + this.MigrateToChatId.GetHashCode();
			hashCode = hashCode * -1521134295 + this.MigrateFromChatId.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<Message?>.Default.GetHashCode(this.PinnedMessage);
			hashCode = hashCode * -1521134295 + EqualityComparer<Invoice?>.Default.GetHashCode(this.Invoice);
			hashCode = hashCode * -1521134295 + EqualityComparer<SuccessfulPayment?>.Default.GetHashCode(this.SuccessfulPayment);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ConnectedWebsite);
			hashCode = hashCode * -1521134295 + EqualityComparer<WriteAccessAllowed?>.Default.GetHashCode(this.WriteAccessAllowed);
			hashCode = hashCode * -1521134295 + EqualityComparer<PassportData?>.Default.GetHashCode(this.PassportData);
			hashCode = hashCode * -1521134295 + EqualityComparer<ProximityAlertTriggered?>.Default.GetHashCode(this.ProximityAlertTriggered);
			hashCode = hashCode * -1521134295 + EqualityComparer<ForumTopicCreated?>.Default.GetHashCode(this.ForumTopicCreated);
			hashCode = hashCode * -1521134295 + EqualityComparer<ForumTopicEdited?>.Default.GetHashCode(this.ForumTopicEdited);
			hashCode = hashCode * -1521134295 + EqualityComparer<ForumTopicClosed?>.Default.GetHashCode(this.ForumTopicClosed);
			hashCode = hashCode * -1521134295 + EqualityComparer<ForumTopicReopened?>.Default.GetHashCode(this.ForumTopicReopened);
			hashCode = hashCode * -1521134295 + EqualityComparer<GeneralForumTopicHidden?>.Default.GetHashCode(this.GeneralForumTopicHidden);
			hashCode = hashCode * -1521134295 + EqualityComparer<GeneralForumTopicUnhidden?>.Default.GetHashCode(this.GeneralForumTopicUnhidden);
			hashCode = hashCode * -1521134295 + EqualityComparer<VideoChatScheduled?>.Default.GetHashCode(this.VideoChatScheduled);
			hashCode = hashCode * -1521134295 + EqualityComparer<VideoChatStarted?>.Default.GetHashCode(this.VideoChatStarted);
			hashCode = hashCode * -1521134295 + EqualityComparer<VideoChatEnded?>.Default.GetHashCode(this.VideoChatEnded);
			hashCode = hashCode * -1521134295 + EqualityComparer<VideoChatParticipantsInvited?>.Default.GetHashCode(this.VideoChatParticipantsInvited);
			hashCode = hashCode * -1521134295 + EqualityComparer<WebAppData?>.Default.GetHashCode(this.WebAppData);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup?>.Default.GetHashCode(this.ReplyMarkup);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(Message? left, Message? right)
		{
#pragma warning disable CS8604 // Possible null reference argument.
			return EqualityComparer<Message>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
		}
		/// <inheritdoc/>
		public static bool operator !=(Message? left, Message? right)
		{
			return !(left == right);
		}

	}
}
