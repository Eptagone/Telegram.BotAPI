// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.RichMessages;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditEphemeralMessageText" method.
/// </summary>
public class EditEphemeralMessageTextArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageTextArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    public EditEphemeralMessageTextArgs(long chatId, long receiverUserId, int ephemeralMessageId)
    {
        this.ChatId = chatId;
        this.ReceiverUserId = receiverUserId;
        this.EphemeralMessageId = ephemeralMessageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EditEphemeralMessageTextArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    public EditEphemeralMessageTextArgs(string chatId, long receiverUserId, int ephemeralMessageId)
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
    /// New text of the message, 1-4096 characters after entity parsing; required if <em>rich_message</em> isn't specified
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string? Text { get; set; }

    /// <summary>
    /// Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Entities)]
    public IEnumerable<MessageEntity>? Entities { get; set; }

    /// <summary>
    /// New rich content of the message; required if <em>text</em> isn't specified
    /// </summary>
    [JsonPropertyName(PropertyNames.RichMessage)]
    public InputRichMessage? RichMessage { get; set; }

    /// <summary>
    /// Link preview generation options for the message
    /// </summary>
    [JsonPropertyName(PropertyNames.LinkPreviewOptions)]
    public LinkPreviewOptions? LinkPreviewOptions { get; set; }

    /// <summary>
    /// A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
