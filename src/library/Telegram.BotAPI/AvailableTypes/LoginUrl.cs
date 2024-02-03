// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a parameter of the inline keyboard button used to automatically authorize a user. Serves as a great replacement for the <a href="https://core.telegram.org/widgets/login">Telegram Login Widget</a> when the user is coming from Telegram. All the user needs to do is tap/click a button and confirm that they want to log in:
/// Telegram apps support these buttons as of <a href="https://telegram.org/blog/privacy-discussions-web-bots#meet-seamless-web-bots">version 5.7</a>.
/// </summary>
public class LoginUrl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LoginUrl"/> class.
    /// </summary>
    /// <param name="url">An HTTPS URL to be opened with user authorization data added to the query string when the button is pressed. If the user refuses to provide authorization data, the original URL without information about the user will be opened. The data added is the same as described in <a href="https://core.telegram.org/widgets/login#receiving-authorization-data">Receiving authorization data</a>.<br /><br /><strong>NOTE:</strong> You <strong>must</strong> always check the hash of the received data to verify the authentication and the integrity of the data as described in <a href="https://core.telegram.org/widgets/login#checking-authorization">Checking authorization</a>.</param>
    public LoginUrl(string url)
    {
        this.Url = url ?? throw new ArgumentNullException(nameof(url));
    }

    /// <summary>
    /// An HTTPS URL to be opened with user authorization data added to the query string when the button is pressed. If the user refuses to provide authorization data, the original URL without information about the user will be opened. The data added is the same as described in <a href="https://core.telegram.org/widgets/login#receiving-authorization-data">Receiving authorization data</a>.<br /><br /><strong>NOTE:</strong> You <strong>must</strong> always check the hash of the received data to verify the authentication and the integrity of the data as described in <a href="https://core.telegram.org/widgets/login#checking-authorization">Checking authorization</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; }

    /// <summary>
    /// Optional. New text of the button in forwarded messages.
    /// </summary>
    [JsonPropertyName(PropertyNames.ForwardText)]
    public string? ForwardText { get; set; }

    /// <summary>
    /// Optional. Username of a bot, which will be used for user authorization. See <a href="https://core.telegram.org/widgets/login#setting-up-a-bot">Setting up a bot</a> for more details. If not specified, the current bot's username will be assumed. The <em>url</em>'s domain must be the same as the domain linked with the bot. See <a href="https://core.telegram.org/widgets/login#linking-your-domain-to-the-bot">Linking your domain to the bot</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.BotUsername)]
    public string? BotUsername { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to request the permission for your bot to send messages to the user.
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestWriteAccess)]
    public bool? RequestWriteAccess { get; set; }
}
