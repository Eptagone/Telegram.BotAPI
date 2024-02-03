// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#inputmessagecontent">content</a> of a text message to be sent as the result of an inline query.
/// </summary>
public class InputTextMessageContent : InputMessageContent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputTextMessageContent"/> class.
    /// </summary>
    /// <param name="messageText">Text of the message to be sent, 1-4096 characters</param>
    public InputTextMessageContent(string messageText)
    {
        this.MessageText = messageText ?? throw new ArgumentNullException(nameof(messageText));
    }

    /// <summary>
    /// Text of the message to be sent, 1-4096 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageText)]
    public string MessageText { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// Optional. List of special entities that appear in message text, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Entities)]
    public IEnumerable<MessageEntity>? Entities { get; set; }

    /// <summary>
    /// Optional. Link preview generation options for the message
    /// </summary>
    [JsonPropertyName(PropertyNames.LinkPreviewOptions)]
    public LinkPreviewOptions? LinkPreviewOptions { get; set; }
}
