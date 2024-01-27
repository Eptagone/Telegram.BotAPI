// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Payments;
using Telegram.BotAPI.Stickers;
using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a message.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Message : MaybeInaccessibleMessage
{
	/// <summary>
	/// Unique message identifier inside this chat
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override int MessageId { get; set; }
	/// <summary>
	/// Date the message was sent in Unix time. It is always a positive number, representing a valid date.
	/// </summary>
	[JsonPropertyName(PropertyNames.Date)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override uint Date { get; set; }
	/// <summary>
	/// Chat the message belongs to
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override Chat Chat { get; set; }
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
	/// Optional. Information about the original message for forwarded messages
	/// </summary>
	[JsonPropertyName(PropertyNames.ForwardOrigin)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MessageOrigin? ForwardOrigin { get; set; }
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
	/// Optional. For replies in the same chat and message thread, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyToMessage)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? ReplyToMessage { get; set; }
	/// <summary>
	/// Optional. Information about the message that is being replied to, which may come from another chat or forum topic
	/// </summary>
	[JsonPropertyName(PropertyNames.ExternalReply)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ExternalReplyInfo? ExternalReply { get; set; }
	/// <summary>
	/// Optional. For replies that quote part of the original message, the quoted part of the message
	/// </summary>
	[JsonPropertyName(PropertyNames.Quote)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public TextQuote? Quote { get; set; }
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
	/// Optional. Options used for link preview generation for the message, if it is a text message and link preview options were changed
	/// </summary>
	[JsonPropertyName(PropertyNames.LinkPreviewOptions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public LinkPreviewOptions? LinkPreviewOptions { get; set; }
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
	public IEnumerable<PhotoSize>? Photo { get; set; }
	/// <summary>
	/// Optional. Message is a sticker, information about the sticker
	/// </summary>
	[JsonPropertyName(PropertyNames.Sticker)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Sticker? Sticker { get; set; }
	/// <summary>
	/// Optional. Message is a forwarded story
	/// </summary>
	[JsonPropertyName(PropertyNames.Story)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Story? Story { get; set; }
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
	public IEnumerable<User>? NewChatMembers { get; set; }
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
	public IEnumerable<PhotoSize>? NewChatPhoto { get; set; }
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
	public int? MigrateToChatId { get; set; }
	/// <summary>
	/// Optional. The supergroup has been migrated from a group with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
	/// </summary>
	[JsonPropertyName(PropertyNames.MigrateFromChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MigrateFromChatId { get; set; }
	/// <summary>
	/// Optional. Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
	/// </summary>
	[JsonPropertyName(PropertyNames.PinnedMessage)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MaybeInaccessibleMessage? PinnedMessage { get; set; }
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
	/// Optional. Service message: users were shared with the bot
	/// </summary>
	[JsonPropertyName(PropertyNames.UsersShared)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public UsersShared? UsersShared { get; set; }
	/// <summary>
	/// Optional. Service message: a chat was shared with the bot
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatShared)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatShared? ChatShared { get; set; }
	/// <summary>
	/// Optional. The domain name of the website on which the user has logged in. More about Telegram Login »
	/// </summary>
	[JsonPropertyName(PropertyNames.ConnectedWebsite)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ConnectedWebsite { get; set; }
	/// <summary>
	/// Optional. Service message: the user allowed the bot to write messages after adding it to the attachment or side menu, launching a Web App from a link, or accepting an explicit request from a Web App sent by the method requestWriteAccess
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
	/// Optional. Service message: a scheduled giveaway was created
	/// </summary>
	[JsonPropertyName(PropertyNames.GiveawayCreated)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public GiveawayCreated? GiveawayCreated { get; set; }
	/// <summary>
	/// Optional. The message is a scheduled giveaway message
	/// </summary>
	[JsonPropertyName(PropertyNames.Giveaway)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Giveaway? Giveaway { get; set; }
	/// <summary>
	/// Optional. A giveaway with public winners was completed
	/// </summary>
	[JsonPropertyName(PropertyNames.GiveawayWinners)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public GiveawayWinners? GiveawayWinners { get; set; }
	/// <summary>
	/// Optional. Service message: a giveaway without public winners was completed
	/// </summary>
	[JsonPropertyName(PropertyNames.GiveawayCompleted)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public GiveawayCompleted? GiveawayCompleted { get; set; }
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
}
