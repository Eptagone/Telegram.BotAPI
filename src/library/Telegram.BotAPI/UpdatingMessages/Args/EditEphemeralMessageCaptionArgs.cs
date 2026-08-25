// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditEphemeralMessageCaption" method.
/// </summary>
public class EditEphemeralMessageCaptionArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageCaptionArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    public EditEphemeralMessageCaptionArgs(long chatId, long receiverUserId, int ephemeralMessageId)
    {
        this.ChatId = chatId;
        this.ReceiverUserId = receiverUserId;
        this.EphemeralMessageId = ephemeralMessageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageCaptionArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    public EditEphemeralMessageCaptionArgs(string chatId, long receiverUserId, int ephemeralMessageId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.ReceiverUserId = receiverUserId;
        this.EphemeralMessageId = ephemeralMessageId;
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Identifier of the user who received the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReceiverUserId)]
    public long ReceiverUserId { get; set; }

    /// <summary>
    /// Identifier of the ephemeral message to edit
    /// </summary>
    [JsonPropertyName(PropertyNames.EphemeralMessageId)]
    public int EphemeralMessageId { get; set; }

    /// <summary>
    /// New caption of the message, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Mode for parsing entities in the message caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the caption must be shown above the message media. Supported only for animation, photo and video messages.
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowCaptionAboveMedia)]
    public bool? ShowCaptionAboveMedia { get; set; }

    /// <summary>
    /// A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
