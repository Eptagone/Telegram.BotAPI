// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Payments;
using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about a message that is being replied to, which may come from another chat or forum topic.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ExternalReplyInfo
{
	/// <summary>
	/// Origin of the message replied to by the given message
	/// </summary>
	[JsonPropertyName(PropertyNames.Origin)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MessageOrigin Origin { get; set; }
	/// <summary>
	/// Optional. Chat the original message belongs to. Available only if the chat is a supergroup or a channel.
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat? Chat { get; set; }
	/// <summary>
	/// Optional. Unique message identifier inside the original chat. Available only if the original chat is a supergroup or a channel.
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long? MessageId { get; set; }
	/// <summary>
	/// Optional. Options used for link preview generation for the original message, if it is a text message
	/// </summary>
	[JsonPropertyName(PropertyNames.LinkPreviewOptions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public LinkPreviewOptions? LinkPreviewOptions { get; set; }
	/// <summary>
	/// Optional. Message is an animation, information about the animation
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
	/// Optional. Message is a scheduled giveaway, information about the giveaway
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
	/// Optional. Message is an invoice for a payment, information about the invoice. More about payments »
	/// </summary>
	[JsonPropertyName(PropertyNames.Invoice)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Invoice? Invoice { get; set; }
	/// <summary>
	/// Optional. Message is a shared location, information about the location
	/// </summary>
	[JsonPropertyName(PropertyNames.Location)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Location? Location { get; set; }
	/// <summary>
	/// Optional. Message is a native poll, information about the poll
	/// </summary>
	[JsonPropertyName(PropertyNames.Poll)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Poll? Poll { get; set; }
	/// <summary>
	/// Optional. Message is a venue, information about the venue
	/// </summary>
	[JsonPropertyName(PropertyNames.Venue)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Venue? Venue { get; set; }
}
