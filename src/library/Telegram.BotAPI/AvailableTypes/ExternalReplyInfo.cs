// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Stickers;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about a message that is being replied to, which may come from another chat or forum topic.
/// </summary>
public class ExternalReplyInfo
{
    /// <summary>
    /// Origin of the message replied to by the given message
    /// </summary>
    [JsonPropertyName(PropertyNames.Origin)]
    public MessageOrigin Origin { get; set; } = null!;

    /// <summary>
    /// Optional. Chat the original message belongs to. Available only if the chat is a supergroup or a channel.
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat? Chat { get; set; }

    /// <summary>
    /// Optional. Unique message identifier inside the original chat. Available only if the original chat is a supergroup or a channel.
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int? MessageId { get; set; }

    /// <summary>
    /// Optional. Options used for link preview generation for the original message, if it is a text message
    /// </summary>
    [JsonPropertyName(PropertyNames.LinkPreviewOptions)]
    public LinkPreviewOptions? LinkPreviewOptions { get; set; }

    /// <summary>
    /// Optional. Message is an animation, information about the animation
    /// </summary>
    [JsonPropertyName(PropertyNames.Animation)]
    public Animation? Animation { get; set; }

    /// <summary>
    /// Optional. Message is an audio file, information about the file
    /// </summary>
    [JsonPropertyName(PropertyNames.Audio)]
    public Audio? Audio { get; set; }

    /// <summary>
    /// Optional. Message is a general file, information about the file
    /// </summary>
    [JsonPropertyName(PropertyNames.Document)]
    public Document? Document { get; set; }

    /// <summary>
    /// Optional. Message contains paid media; information about the paid media
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMedia)]
    public PaidMediaInfo? PaidMedia { get; set; }

    /// <summary>
    /// Optional. Message is a photo, available sizes of the photo
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public IEnumerable<PhotoSize>? Photo { get; set; }

    /// <summary>
    /// Optional. Message is a sticker, information about the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public Sticker? Sticker { get; set; }

    /// <summary>
    /// Optional. Message is a forwarded story
    /// </summary>
    [JsonPropertyName(PropertyNames.Story)]
    public Story? Story { get; set; }

    /// <summary>
    /// Optional. Message is a video, information about the video
    /// </summary>
    [JsonPropertyName(PropertyNames.Video)]
    public Video? Video { get; set; }

    /// <summary>
    /// Optional. Message is a <a href="https://telegram.org/blog/video-messages-and-telescope">video note</a>, information about the video message
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoNote)]
    public VideoNote? VideoNote { get; set; }

    /// <summary>
    /// Optional. Message is a voice message, information about the file
    /// </summary>
    [JsonPropertyName(PropertyNames.Voice)]
    public Voice? Voice { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the message media is covered by a spoiler animation
    /// </summary>
    [JsonPropertyName(PropertyNames.HasMediaSpoiler)]
    public bool? HasMediaSpoiler { get; set; }

    /// <summary>
    /// Optional. Message is a shared contact, information about the contact
    /// </summary>
    [JsonPropertyName(PropertyNames.Contact)]
    public Contact? Contact { get; set; }

    /// <summary>
    /// Optional. Message is a dice with random value
    /// </summary>
    [JsonPropertyName(PropertyNames.Dice)]
    public Dice? Dice { get; set; }

    /// <summary>
    /// Optional. Message is a game, information about the game. <a href="https://core.telegram.org/bots/api#games">More about games »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Game)]
    public Game? Game { get; set; }

    /// <summary>
    /// Optional. Message is a scheduled giveaway, information about the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.Giveaway)]
    public Giveaway? Giveaway { get; set; }

    /// <summary>
    /// Optional. A giveaway with public winners was completed
    /// </summary>
    [JsonPropertyName(PropertyNames.GiveawayWinners)]
    public GiveawayWinners? GiveawayWinners { get; set; }

    /// <summary>
    /// Optional. Message is an invoice for a <a href="https://core.telegram.org/bots/api#payments">payment</a>, information about the invoice. <a href="https://core.telegram.org/bots/api#payments">More about payments »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Invoice)]
    public Invoice? Invoice { get; set; }

    /// <summary>
    /// Optional. Message is a shared location, information about the location
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location? Location { get; set; }

    /// <summary>
    /// Optional. Message is a native poll, information about the poll
    /// </summary>
    [JsonPropertyName(PropertyNames.Poll)]
    public Poll? Poll { get; set; }

    /// <summary>
    /// Optional. Message is a venue, information about the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Venue)]
    public Venue? Venue { get; set; }
}
