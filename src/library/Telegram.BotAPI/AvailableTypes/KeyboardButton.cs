// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents one button of the reply keyboard. At most one of the optional fields must be used to specify type of the button. For simple text buttons, <em>String</em> can be used instead of this object to specify the button text.
/// </summary>
public class KeyboardButton
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyboardButton"/> class.
    /// </summary>
    /// <param name="text">Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed</param>
    public KeyboardButton(string text)
    {
        this.Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    /// <summary>
    /// Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; }

    /// <summary>
    /// <em>Optional.</em> If specified, pressing the button will open a list of suitable users. Identifiers of selected users will be sent to the bot in a “users_shared” service message. Available in private chats only.
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestUsers)]
    public KeyboardButtonRequestUsers? RequestUsers { get; set; }

    /// <summary>
    /// <em>Optional.</em> If specified, pressing the button will open a list of suitable chats. Tapping on a chat will send its identifier to the bot in a “chat_shared” service message. Available in private chats only.
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestChat)]
    public KeyboardButtonRequestChat? RequestChat { get; set; }

    /// <summary>
    /// Optional. If <em>True</em>, the user's phone number will be sent as a contact when the button is pressed. Available in private chats only.
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestContact)]
    public bool? RequestContact { get; set; }

    /// <summary>
    /// Optional. If <em>True</em>, the user's current location will be sent when the button is pressed. Available in private chats only.
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestLocation)]
    public bool? RequestLocation { get; set; }

    /// <summary>
    /// Optional. If specified, the user will be asked to create a poll and send it to the bot when the button is pressed. Available in private chats only.
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestPoll)]
    public KeyboardButtonPollType? RequestPoll { get; set; }

    /// <summary>
    /// Optional. If specified, the described <a href="https://core.telegram.org/bots/webapps">Web App</a> will be launched when the button is pressed. The Web App will be able to send a “web_app_data” service message. Available in private chats only.
    /// </summary>
    [JsonPropertyName(PropertyNames.WebApp)]
    public WebAppInfo? WebApp { get; set; }
}
