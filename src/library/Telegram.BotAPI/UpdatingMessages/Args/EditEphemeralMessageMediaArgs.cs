// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditEphemeralMessageMedia" method.
/// </summary>
public class EditEphemeralMessageMediaArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageMediaArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="media">A JSON-serialized object for the new media content of the message. A new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL.</param>
    public EditEphemeralMessageMediaArgs(long chatId, long receiverUserId, int ephemeralMessageId, InputMedia media)
    {
        this.ChatId = chatId;
        this.ReceiverUserId = receiverUserId;
        this.EphemeralMessageId = ephemeralMessageId;
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageMediaArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="media">A JSON-serialized object for the new media content of the message. A new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL.</param>
    public EditEphemeralMessageMediaArgs(string chatId, long receiverUserId, int ephemeralMessageId, InputMedia media)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.ReceiverUserId = receiverUserId;
        this.EphemeralMessageId = ephemeralMessageId;
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
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
    /// A JSON-serialized object for the new media content of the message. A new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL.
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public InputMedia Media { get; set; }

    /// <summary>
    /// A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
