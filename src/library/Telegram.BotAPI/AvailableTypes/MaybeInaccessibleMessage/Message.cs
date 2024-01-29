// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Stickers;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Payments;
using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a message.
/// </summary>
public class Message : MaybeInaccessibleMessage
{
    /// <summary>
    /// Unique message identifier inside this chat
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public override int MessageId { get; set; }

    /// <summary>
    /// <em>Optional</em>. Unique identifier of a message thread to which the message belongs; for supergroups only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageThreadId)]
    public int? MessageThreadId { get; set; }

    /// <summary>
    /// <em>Optional</em>. Sender of the message; empty for messages sent to channels. For backward compatibility, the field contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User? From { get; set; }

    /// <summary>
    /// <em>Optional</em>. Sender of the message, sent on behalf of a chat. For example, the channel itself for channel posts, the supergroup itself for messages from anonymous group administrators, the linked channel for messages automatically forwarded to the discussion group. For backward compatibility, the field <em>from</em> contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
    /// </summary>
    [JsonPropertyName(PropertyNames.SenderChat)]
    public Chat? SenderChat { get; set; }

    /// <summary>
    /// Date the message was sent in Unix time. It is always a positive number, representing a valid date.
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public override int Date { get; set; }

    /// <summary>
    /// Chat the message belongs to
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public override Chat Chat { get; set; } = null!;

    /// <summary>
    /// <em>Optional</em>. Information about the original message for forwarded messages
    /// </summary>
    [JsonPropertyName(PropertyNames.ForwardOrigin)]
    public MessageOrigin? ForwardOrigin { get; set; }

    /// <summary>
    /// <em>Optional</em>. <em>True</em>, if the message is sent to a forum topic
    /// </summary>
    [JsonPropertyName(PropertyNames.IsTopicMessage)]
    public bool? IsTopicMessage { get; set; }

    /// <summary>
    /// <em>Optional</em>. <em>True</em>, if the message is a channel post that was automatically forwarded to the connected discussion group
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAutomaticForward)]
    public bool? IsAutomaticForward { get; set; }

    /// <summary>
    /// <em>Optional</em>. For replies in the same chat and message thread, the original message. Note that the Message object in this field will not contain further <em>reply_to_message</em> fields even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyToMessage)]
    public Message? ReplyToMessage { get; set; }

    /// <summary>
    /// <em>Optional</em>. Information about the message that is being replied to, which may come from another chat or forum topic
    /// </summary>
    [JsonPropertyName(PropertyNames.ExternalReply)]
    public ExternalReplyInfo? ExternalReply { get; set; }

    /// <summary>
    /// <em>Optional</em>. For replies that quote part of the original message, the quoted part of the message
    /// </summary>
    [JsonPropertyName(PropertyNames.Quote)]
    public TextQuote? Quote { get; set; }

    /// <summary>
    /// <em>Optional</em>. Bot through which the message was sent
    /// </summary>
    [JsonPropertyName(PropertyNames.ViaBot)]
    public User? ViaBot { get; set; }

    /// <summary>
    /// <em>Optional</em>. Date the message was last edited in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.EditDate)]
    public int? EditDate { get; set; }

    /// <summary>
    /// <em>Optional</em>. <em>True</em>, if the message can't be forwarded
    /// </summary>
    [JsonPropertyName(PropertyNames.HasProtectedContent)]
    public bool? HasProtectedContent { get; set; }

    /// <summary>
    /// <em>Optional</em>. The unique identifier of a media message group this message belongs to
    /// </summary>
    [JsonPropertyName(PropertyNames.MediaGroupId)]
    public string? MediaGroupId { get; set; }

    /// <summary>
    /// <em>Optional</em>. Signature of the post author for messages in channels, or the custom title of an anonymous group administrator
    /// </summary>
    [JsonPropertyName(PropertyNames.AuthorSignature)]
    public string? AuthorSignature { get; set; }

    /// <summary>
    /// <em>Optional</em>. For text messages, the actual UTF-8 text of the message
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string? Text { get; set; }

    /// <summary>
    /// <em>Optional</em>. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text
    /// </summary>
    [JsonPropertyName(PropertyNames.Entities)]
    public IEnumerable<MessageEntity>? Entities { get; set; }

    /// <summary>
    /// <em>Optional</em>. Options used for link preview generation for the message, if it is a text message and link preview options were changed
    /// </summary>
    [JsonPropertyName(PropertyNames.LinkPreviewOptions)]
    public LinkPreviewOptions? LinkPreviewOptions { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is an animation, information about the animation. For backward compatibility, when this field is set, the <em>document</em> field will also be set
    /// </summary>
    [JsonPropertyName(PropertyNames.Animation)]
    public Animation? Animation { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is an audio file, information about the file
    /// </summary>
    [JsonPropertyName(PropertyNames.Audio)]
    public Audio? Audio { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a general file, information about the file
    /// </summary>
    [JsonPropertyName(PropertyNames.Document)]
    public Document? Document { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a photo, available sizes of the photo
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public IEnumerable<PhotoSize>? Photo { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a sticker, information about the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public Sticker? Sticker { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a forwarded story
    /// </summary>
    [JsonPropertyName(PropertyNames.Story)]
    public Story? Story { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a video, information about the video
    /// </summary>
    [JsonPropertyName(PropertyNames.Video)]
    public Video? Video { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a <a href="https://telegram.org/blog/video-messages-and-telescope">video note</a>, information about the video message
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoNote)]
    public VideoNote? VideoNote { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a voice message, information about the file
    /// </summary>
    [JsonPropertyName(PropertyNames.Voice)]
    public Voice? Voice { get; set; }

    /// <summary>
    /// <em>Optional</em>. Caption for the animation, audio, document, photo, video or voice
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// <em>Optional</em>. For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// <em>Optional</em>. <em>True</em>, if the message media is covered by a spoiler animation
    /// </summary>
    [JsonPropertyName(PropertyNames.HasMediaSpoiler)]
    public bool? HasMediaSpoiler { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a shared contact, information about the contact
    /// </summary>
    [JsonPropertyName(PropertyNames.Contact)]
    public Contact? Contact { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a dice with random value
    /// </summary>
    [JsonPropertyName(PropertyNames.Dice)]
    public Dice? Dice { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a game, information about the game. <a href="https://core.telegram.org/bots/api#games">More about games »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Game)]
    public Game? Game { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a native poll, information about the poll
    /// </summary>
    [JsonPropertyName(PropertyNames.Poll)]
    public Poll? Poll { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a venue, information about the venue. For backward compatibility, when this field is set, the <em>location</em> field will also be set
    /// </summary>
    [JsonPropertyName(PropertyNames.Venue)]
    public Venue? Venue { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a shared location, information about the location
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location? Location { get; set; }

    /// <summary>
    /// <em>Optional</em>. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members)
    /// </summary>
    [JsonPropertyName(PropertyNames.NewChatMembers)]
    public IEnumerable<User>? NewChatMembers { get; set; }

    /// <summary>
    /// <em>Optional</em>. A member was removed from the group, information about them (this member may be the bot itself)
    /// </summary>
    [JsonPropertyName(PropertyNames.LeftChatMember)]
    public User? LeftChatMember { get; set; }

    /// <summary>
    /// <em>Optional</em>. A chat title was changed to this value
    /// </summary>
    [JsonPropertyName(PropertyNames.NewChatTitle)]
    public string? NewChatTitle { get; set; }

    /// <summary>
    /// <em>Optional</em>. A chat photo was change to this value
    /// </summary>
    [JsonPropertyName(PropertyNames.NewChatPhoto)]
    public IEnumerable<PhotoSize>? NewChatPhoto { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: the chat photo was deleted
    /// </summary>
    [JsonPropertyName(PropertyNames.DeleteChatPhoto)]
    public bool? DeleteChatPhoto { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: the group has been created
    /// </summary>
    [JsonPropertyName(PropertyNames.GroupChatCreated)]
    public bool? GroupChatCreated { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: the supergroup has been created. This field can't be received in a message coming through updates, because bot can't be a member of a supergroup when it is created. It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.
    /// </summary>
    [JsonPropertyName(PropertyNames.SupergroupChatCreated)]
    public bool? SupergroupChatCreated { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: the channel has been created. This field can't be received in a message coming through updates, because bot can't be a member of a channel when it is created. It can only be found in reply_to_message if someone replies to a very first message in a channel.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChannelChatCreated)]
    public bool? ChannelChatCreated { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: auto-delete timer settings changed in the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageAutoDeleteTimerChanged)]
    public MessageAutoDeleteTimerChanged? MessageAutoDeleteTimerChanged { get; set; }

    /// <summary>
    /// <em>Optional</em>. The group has been migrated to a supergroup with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.MigrateToChatId)]
    public long? MigrateToChatId { get; set; }

    /// <summary>
    /// <em>Optional</em>. The supergroup has been migrated from a group with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.MigrateFromChatId)]
    public long? MigrateFromChatId { get; set; }

    /// <summary>
    /// <em>Optional</em>. Specified message was pinned. Note that the Message object in this field will not contain further <em>reply_to_message</em> fields even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.PinnedMessage)]
    public MaybeInaccessibleMessage? PinnedMessage { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is an invoice for a <a href="https://core.telegram.org/bots/api#payments">payment</a>, information about the invoice. <a href="https://core.telegram.org/bots/api#payments">More about payments »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Invoice)]
    public Invoice? Invoice { get; set; }

    /// <summary>
    /// <em>Optional</em>. Message is a service message about a successful payment, information about the payment. <a href="https://core.telegram.org/bots/api#payments">More about payments »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.SuccessfulPayment)]
    public SuccessfulPayment? SuccessfulPayment { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: users were shared with the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.UsersShared)]
    public UsersShared? UsersShared { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: a chat was shared with the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatShared)]
    public ChatShared? ChatShared { get; set; }

    /// <summary>
    /// <em>Optional</em>. The domain name of the website on which the user has logged in. <a href="https://core.telegram.org/widgets/login">More about Telegram Login »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.ConnectedWebsite)]
    public string? ConnectedWebsite { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: the user allowed the bot to write messages after adding it to the attachment or side menu, launching a Web App from a link, or accepting an explicit request from a Web App sent by the method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestWriteAccess</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.WriteAccessAllowed)]
    public WriteAccessAllowed? WriteAccessAllowed { get; set; }

    /// <summary>
    /// <em>Optional</em>. Telegram Passport data
    /// </summary>
    [JsonPropertyName(PropertyNames.PassportData)]
    public PassportData? PassportData { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message. A user in the chat triggered another user's proximity alert while sharing Live Location.
    /// </summary>
    [JsonPropertyName(PropertyNames.ProximityAlertTriggered)]
    public ProximityAlertTriggered? ProximityAlertTriggered { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: forum topic created
    /// </summary>
    [JsonPropertyName(PropertyNames.ForumTopicCreated)]
    public ForumTopicCreated? ForumTopicCreated { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: forum topic edited
    /// </summary>
    [JsonPropertyName(PropertyNames.ForumTopicEdited)]
    public ForumTopicEdited? ForumTopicEdited { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: forum topic closed
    /// </summary>
    [JsonPropertyName(PropertyNames.ForumTopicClosed)]
    public ForumTopicClosed? ForumTopicClosed { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: forum topic reopened
    /// </summary>
    [JsonPropertyName(PropertyNames.ForumTopicReopened)]
    public ForumTopicReopened? ForumTopicReopened { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: the 'General' forum topic hidden
    /// </summary>
    [JsonPropertyName(PropertyNames.GeneralForumTopicHidden)]
    public GeneralForumTopicHidden? GeneralForumTopicHidden { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: the 'General' forum topic unhidden
    /// </summary>
    [JsonPropertyName(PropertyNames.GeneralForumTopicUnhidden)]
    public GeneralForumTopicUnhidden? GeneralForumTopicUnhidden { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: a scheduled giveaway was created
    /// </summary>
    [JsonPropertyName(PropertyNames.GiveawayCreated)]
    public GiveawayCreated? GiveawayCreated { get; set; }

    /// <summary>
    /// <em>Optional</em>. The message is a scheduled giveaway message
    /// </summary>
    [JsonPropertyName(PropertyNames.Giveaway)]
    public Giveaway? Giveaway { get; set; }

    /// <summary>
    /// <em>Optional</em>. A giveaway with public winners was completed
    /// </summary>
    [JsonPropertyName(PropertyNames.GiveawayWinners)]
    public GiveawayWinners? GiveawayWinners { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: a giveaway without public winners was completed
    /// </summary>
    [JsonPropertyName(PropertyNames.GiveawayCompleted)]
    public GiveawayCompleted? GiveawayCompleted { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: video chat scheduled
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoChatScheduled)]
    public VideoChatScheduled? VideoChatScheduled { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: video chat started
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoChatStarted)]
    public VideoChatStarted? VideoChatStarted { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: video chat ended
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoChatEnded)]
    public VideoChatEnded? VideoChatEnded { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: new participants invited to a video chat
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoChatParticipantsInvited)]
    public VideoChatParticipantsInvited? VideoChatParticipantsInvited { get; set; }

    /// <summary>
    /// <em>Optional</em>. Service message: data sent by a Web App
    /// </summary>
    [JsonPropertyName(PropertyNames.WebAppData)]
    public WebAppData? WebAppData { get; set; }

    /// <summary>
    /// <em>Optional</em>. Inline keyboard attached to the message. <code>login_url</code> buttons are represented as ordinary <code>url</code> buttons.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
