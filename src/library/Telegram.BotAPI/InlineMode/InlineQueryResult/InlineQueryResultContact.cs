// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a contact with a phone number. By default, this contact will be sent by the user. Alternatively, you can use <em>input_message_content</em> to send a message with the specified content instead of the contact.
/// </summary>
public class InlineQueryResultContact : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>contact</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "contact";

    /// <summary>
    /// Unique identifier for this result, 1-64 Bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// Contact's phone number
    /// </summary>
    [JsonPropertyName(PropertyNames.PhoneNumber)]
    public string PhoneNumber { get; set; } = null!;

    /// <summary>
    /// Contact's first name
    /// </summary>
    [JsonPropertyName(PropertyNames.FirstName)]
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Optional. Contact's last name
    /// </summary>
    [JsonPropertyName(PropertyNames.LastName)]
    public string? LastName { get; set; }

    /// <summary>
    /// Optional. Additional data about the contact in the form of a <a href="https://en.wikipedia.org/wiki/VCard">vCard</a>, 0-2048 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Vcard)]
    public string? Vcard { get; set; }

    /// <summary>
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. Content of the message to be sent instead of the contact
    /// </summary>
    [JsonPropertyName(PropertyNames.InputMessageContent)]
    public InputMessageContent? InputMessageContent { get; set; }

    /// <summary>
    /// Optional. Url of the thumbnail for the result
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailUrl)]
    public string? ThumbnailUrl { get; set; }

    /// <summary>
    /// Optional. Thumbnail width
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailWidth)]
    public int? ThumbnailWidth { get; set; }

    /// <summary>
    /// Optional. Thumbnail height
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailHeight)]
    public int? ThumbnailHeight { get; set; }
}
