// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditEphemeralMessageReplyMarkup" method.
/// </summary>
public class EditEphemeralMessageReplyMarkupArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageReplyMarkupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    public EditEphemeralMessageReplyMarkupArgs(long chatId, long receiverUserId, int ephemeralMessageId)
    {
        this.ChatId = chatId;
        this.ReceiverUserId = receiverUserId;
        this.EphemeralMessageId = ephemeralMessageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageReplyMarkupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    public EditEphemeralMessageReplyMarkupArgs(string chatId, long receiverUserId, int ephemeralMessageId)
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
    /// A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
