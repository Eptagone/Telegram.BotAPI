// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a menu button, which launches a <a href="https://core.telegram.org/bots/webapps">Web App</a>.
/// </summary>
public class MenuButtonWebApp : MenuButton
{
    /// <summary>
    /// Type of the button, must be <em>web_app</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "web_app";

    /// <summary>
    /// Text on the button
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; } = null!;

    /// <summary>
    /// Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method <a href="https://core.telegram.org/bots/api#answerwebappquery">answerWebAppQuery</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.WebApp)]
    public WebAppInfo WebApp { get; set; } = null!;
}
