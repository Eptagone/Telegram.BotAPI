// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.RichMessages;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditMessageText" method.
/// </summary>
public class EditMessageTextArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Unique identifier of the business connection on behalf of which the message to be edited was sent
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string? BusinessConnectionId { get; set; }

    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target bot, supergroup or channel in the format <em>@username</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object? ChatId { get; set; }

    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit.
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int? MessageId { get; set; }

    /// <summary>
    /// Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message.
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }

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
    /// Link preview generation options for the message
    /// </summary>
    [JsonPropertyName(PropertyNames.LinkPreviewOptions)]
    public LinkPreviewOptions? LinkPreviewOptions { get; set; }

    /// <summary>
    /// New rich content of the message; required if <em>text</em> isn't specified. Direct upload of new files isn't supported when an inline message is edited.
    /// </summary>
    [JsonPropertyName(PropertyNames.RichMessage)]
    public InputRichMessage? RichMessage { get; set; }

    /// <summary>
    /// A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
