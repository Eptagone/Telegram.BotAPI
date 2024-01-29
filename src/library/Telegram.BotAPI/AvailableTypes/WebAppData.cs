// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes data sent from a <a href="https://core.telegram.org/bots/webapps">Web App</a> to the bot.
/// </summary>
public class WebAppData
{
    /// <summary>
    /// The data. Be aware that a bad client can send arbitrary data in this field.
    /// </summary>
    [JsonPropertyName(PropertyNames.Data)]
    public string Data { get; set; } = null!;

    /// <summary>
    /// Text of the <em>web_app</em> keyboard button from which the Web App was opened. Be aware that a bad client can send arbitrary data in this field.
    /// </summary>
    [JsonPropertyName(PropertyNames.ButtonText)]
    public string ButtonText { get; set; } = null!;
}
