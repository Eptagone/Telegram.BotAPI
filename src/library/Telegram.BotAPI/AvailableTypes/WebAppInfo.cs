// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a <a href="https://core.telegram.org/bots/webapps">Web App</a>.
/// </summary>
public class WebAppInfo
{
    /// <summary>
    /// An HTTPS URL of a Web App to be opened with additional data as specified in <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">Initializing Web Apps</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; } = null!;
}
