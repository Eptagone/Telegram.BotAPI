// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SendWidget" method.
/// </summary>
public class SendWidgetArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendWidgetArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="html">HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.</param>
    public SendWidgetArgs(long chatId, string html)
    {
        this.ChatId = chatId;
        this.Html = html ?? throw new ArgumentNullException(nameof(html));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendWidgetArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="html">HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.</param>
    public SendWidgetArgs(string chatId, string html)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Html = html ?? throw new ArgumentNullException(nameof(html));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Unique identifier for the target message thread (topic) of a forum; for forum supergroups and private chats of bots with forum topic mode enabled only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageThreadId)]
    public int? MessageThreadId { get; set; }

    /// <summary>
    /// HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.
    /// </summary>
    [JsonPropertyName(PropertyNames.Html)]
    public string Html { get; set; }

    /// <summary>
    /// Width of the widget in logical pixels; omit if the widget must occupy the whole width of the message bubble. The width is clamped by the app to the range from 200 to the maximum width of the message bubble.
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int? Width { get; set; }

    /// <summary>
    /// Height of the widget in logical pixels; omit if the height of the widget isn't fixed. The height is clamped by the app to the range 50-600.
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int? Height { get; set; }

    /// <summary>
    /// Public data of the widget, 0-1024 bytes, which will be available wherever the widget is shown. If the widget is shared, then all messages with it will have the same public data.
    /// </summary>
    [JsonPropertyName(PropertyNames.PublicData)]
    public string? PublicData { get; set; }

    /// <summary>
    /// Data of the widget, which is specific to the message, 0-1024 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatData)]
    public string? ChatData { get; set; }

    /// <summary>
    /// Widget caption, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Mode for parsing entities in the widget caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the caption must be shown above the widget
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowCaptionAboveMedia)]
    public bool? ShowCaptionAboveMedia { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow the widget to send queries to the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowQueries)]
    public bool? AllowQueries { get; set; }

    /// <summary>
    /// Pass <em>True</em> to create a shared widget, which can be sent again using the method <a href="https://core.telegram.org/bots/api#sendsharedwidget">sendSharedWidget</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.IsShared)]
    public bool? IsShared { get; set; }

    /// <summary>
    /// Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the sent message from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance.
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowPaidBroadcast)]
    public bool? AllowPaidBroadcast { get; set; }

    /// <summary>
    /// Unique identifier of the message effect to be added to the message; for private chats only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageEffectId)]
    public string? MessageEffectId { get; set; }

    /// <summary>
    /// Description of the message to reply to
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyParameters)]
    public ReplyParameters? ReplyParameters { get; set; }

    /// <summary>
    /// Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public object? ReplyMarkup { get; set; }
}
