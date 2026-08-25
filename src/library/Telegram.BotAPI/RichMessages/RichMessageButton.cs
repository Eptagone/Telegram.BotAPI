// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// This object represents a button in a <see cref="RichMessage"/>. Exactly one of the fields other than <em>text</em> and <em>style</em> must be used to specify the type of the button.
/// </summary>
public class RichMessageButton
{
    /// <summary>
    /// Text of the button. May contain only plain text, <see cref="RichTextCustomEmoji"/> and <see cref="RichTextDateTime"/> entities.
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// Optional. Style of the button. Must be one of “danger” (red), “success” (green), “primary” (blue) or “link” (the button is shown as a regular link without borders). If omitted, then an app-specific style is used. The style “link” is allowed only for callback buttons.
    /// </summary>
    [JsonPropertyName(PropertyNames.Style)]
    public string? Style { get; set; }

    /// <summary>
    /// Optional. HTTP or tg:// URL to be opened when the button is pressed. Links <em>tg://user?id=&lt;user_id&gt;</em> can be used to mention a user by their identifier without using a username, if this is allowed by their privacy settings.
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string? Url { get; set; }

    /// <summary>
    /// Optional. Data to be sent in a <a href="https://core.telegram.org/bots/api#callbackquery">callback query</a> to the bot when the button is pressed, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackData)]
    public string? CallbackData { get; set; }

    /// <summary>
    /// Optional. Description of the <a href="https://core.telegram.org/bots/webapps">Web App</a> that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method <a href="https://core.telegram.org/bots/api#answerwebappquery">answerWebAppQuery</a>. Available only in private chats between a user and the bot. Not supported for messages sent on behalf of a business account.
    /// </summary>
    [JsonPropertyName(PropertyNames.WebApp)]
    public WebAppInfo? WebApp { get; set; }

    /// <summary>
    /// Optional. An HTTPS URL used to automatically authorize the user. Can be used as a replacement for the <a href="https://core.telegram.org/widgets/login">Telegram Login Widget</a>. Not supported for ephemeral messages.
    /// </summary>
    [JsonPropertyName(PropertyNames.LoginUrl)]
    public LoginUrl? LoginUrl { get; set; }

    /// <summary>
    /// Optional. If set, pressing the button will prompt the user to select one of their chats, open that chat and insert the bot's username and the specified inline query in the input field. May be empty, in which case just the bot's username will be inserted. Not supported for messages sent in channel direct messages chats and on behalf of a business account.
    /// </summary>
    [JsonPropertyName(PropertyNames.SwitchInlineQuery)]
    public string? SwitchInlineQuery { get; set; }

    /// <summary>
    /// Optional. If set, pressing the button will insert the bot's username and the specified inline query in the current chat's input field. May be empty, in which case only the bot's username will be inserted. Not supported in channels and for messages sent in channel direct messages chats and on behalf of a business account.
    /// </summary>
    [JsonPropertyName(PropertyNames.SwitchInlineQueryCurrentChat)]
    public string? SwitchInlineQueryCurrentChat { get; set; }

    /// <summary>
    /// Optional. If set, pressing the button will prompt the user to select one of their chats of the specified type, open that chat and insert the bot's username and the specified inline query in the input field. Not supported for messages sent in channel direct messages chats and on behalf of a business account.
    /// </summary>
    [JsonPropertyName(PropertyNames.SwitchInlineQueryChosenChat)]
    public SwitchInlineQueryChosenChat? SwitchInlineQueryChosenChat { get; set; }

    /// <summary>
    /// Optional. A button that copies the specified text to the clipboard
    /// </summary>
    [JsonPropertyName(PropertyNames.CopyText)]
    public CopyTextButton? CopyText { get; set; }

    /// <summary>
    /// Optional. If set, then the button is disabled and does nothing
    /// </summary>
    [JsonPropertyName(PropertyNames.Disabled)]
    public DisabledButton? Disabled { get; set; }
}
