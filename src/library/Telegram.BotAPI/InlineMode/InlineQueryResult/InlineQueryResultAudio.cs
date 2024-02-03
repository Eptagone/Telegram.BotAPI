// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a link to an MP3 audio file. By default, this audio file will be sent by the user. Alternatively, you can use <em>input_message_content</em> to send a message with the specified content instead of the audio.
/// </summary>
public class InlineQueryResultAudio : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>audio</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "audio";

    /// <summary>
    /// Unique identifier for this result, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// A valid URL for the audio file
    /// </summary>
    [JsonPropertyName(PropertyNames.AudioUrl)]
    public string AudioUrl { get; set; } = null!;

    /// <summary>
    /// Title
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Optional. Caption, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// Optional. List of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// Optional. Performer
    /// </summary>
    [JsonPropertyName(PropertyNames.Performer)]
    public string? Performer { get; set; }

    /// <summary>
    /// Optional. Audio duration in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.AudioDuration)]
    public int? AudioDuration { get; set; }

    /// <summary>
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. Content of the message to be sent instead of the audio
    /// </summary>
    [JsonPropertyName(PropertyNames.InputMessageContent)]
    public InputMessageContent? InputMessageContent { get; set; }
}
