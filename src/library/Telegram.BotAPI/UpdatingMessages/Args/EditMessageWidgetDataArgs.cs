// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "EditMessageWidgetData" method.
/// </summary>
public class EditMessageWidgetDataArgs
{
    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object? ChatId { get; set; }

    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Identifier of the message with the widget.
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int? MessageId { get; set; }

    /// <summary>
    /// Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message.
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }

    /// <summary>
    /// New public data of the widget, 0-1024 bytes; pass an empty string to remove the public data. If omitted, then the public data isn't changed.
    /// </summary>
    [JsonPropertyName(PropertyNames.PublicData)]
    public string? PublicData { get; set; }

    /// <summary>
    /// New data of the widget, which is specific to the message, 0-1024 bytes; pass an empty string to remove the data. If omitted, then the data isn't changed.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatData)]
    public string? ChatData { get; set; }
}
