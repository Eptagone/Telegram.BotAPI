// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents one button of an inline keyboard. You <strong>must</strong> use exactly one of the optional fields.
/// </summary>
public class InlineKeyboardButton
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InlineKeyboardButton"/> class.
    /// </summary>
    /// <param name="text">Label text on the button</param>
    public InlineKeyboardButton(string text)
    {
        this.Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    /// <summary>
    /// Label text on the button
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; }

    /// <summary>
    /// <em>Optional</em>. HTTP or tg:// URL to be opened when the button is pressed. Links <code>tg://user?id=&lt;user_id&gt;</code> can be used to mention a user by their identifier without using a username, if this is allowed by their privacy settings.
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string? Url { get; set; }

    /// <summary>
    /// <em>Optional</em>. Data to be sent in a <a href="https://core.telegram.org/bots/api#callbackquery">callback query</a> to the bot when button is pressed, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackData)]
    public string? CallbackData { get; set; }

    /// <summary>
    /// <em>Optional</em>. Description of the <a href="https://core.telegram.org/bots/webapps">Web App</a> that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method <a href="https://core.telegram.org/bots/api#answerwebappquery">answerWebAppQuery</a>. Available only in private chats between a user and the bot.
    /// </summary>
    [JsonPropertyName(PropertyNames.WebApp)]
    public WebAppInfo? WebApp { get; set; }

    /// <summary>
    /// <em>Optional</em>. An HTTPS URL used to automatically authorize the user. Can be used as a replacement for the <a href="https://core.telegram.org/widgets/login">Telegram Login Widget</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.LoginUrl)]
    public LoginUrl? LoginUrl { get; set; }

    /// <summary>
    /// <em>Optional</em>. If set, pressing the button will prompt the user to select one of their chats, open that chat and insert the bot's username and the specified inline query in the input field. May be empty, in which case just the bot's username will be inserted.
    /// </summary>
    [JsonPropertyName(PropertyNames.SwitchInlineQuery)]
    public string? SwitchInlineQuery { get; set; }

    /// <summary>
    /// <em>Optional</em>. If set, pressing the button will insert the bot's username and the specified inline query in the current chat's input field. May be empty, in which case only the bot's username will be inserted.<br /><br />This offers a quick way for the user to open your bot in inline mode in the same chat - good for selecting something from multiple options.
    /// </summary>
    [JsonPropertyName(PropertyNames.SwitchInlineQueryCurrentChat)]
    public string? SwitchInlineQueryCurrentChat { get; set; }

    /// <summary>
    /// <em>Optional</em>. If set, pressing the button will prompt the user to select one of their chats of the specified type, open that chat and insert the bot's username and the specified inline query in the input field
    /// </summary>
    [JsonPropertyName(PropertyNames.SwitchInlineQueryChosenChat)]
    public SwitchInlineQueryChosenChat? SwitchInlineQueryChosenChat { get; set; }

    /// <summary>
    /// <em>Optional</em>. Description of the game that will be launched when the user presses the button.<br /><br /><strong>NOTE:</strong> This type of button <strong>must</strong> always be the first button in the first row.
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackGame)]
    public CallbackGame? CallbackGame { get; set; }

    /// <summary>
    /// <em>Optional</em>. Specify <em>True</em>, to send a <a href="https://core.telegram.org/bots/api#payments">Pay button</a>.<br /><br /><strong>NOTE:</strong> This type of button <strong>must</strong> always be the first button in the first row and can only be used in invoice messages.
    /// </summary>
    [JsonPropertyName(PropertyNames.Pay)]
    public bool? Pay { get; set; }
}
