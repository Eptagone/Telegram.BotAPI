// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "AnswerCallbackQuery" method.
/// </summary>
public class AnswerCallbackQueryArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnswerCallbackQueryArgs"/> class.
    /// </summary>
    /// <param name="callbackQueryId">Unique identifier for the query to be answered</param>
    public AnswerCallbackQueryArgs(string callbackQueryId)
    {
        this.CallbackQueryId = callbackQueryId ?? throw new ArgumentNullException(nameof(callbackQueryId));
    }

    /// <summary>
    /// Unique identifier for the query to be answered
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackQueryId)]
    public string CallbackQueryId { get; set; }

    /// <summary>
    /// Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string? Text { get; set; }

    /// <summary>
    /// If <em>True</em>, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to <em>false</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowAlert)]
    public bool? ShowAlert { get; set; }

    /// <summary>
    /// URL that will be opened by the user's client. If you have created a <see cref="Game"/> and accepted the conditions via <a href="https://t.me/botfather">@BotFather</a>, specify the URL that opens your game - note that this will only work if the query comes from a <a href="https://core.telegram.org/bots/api#inlinekeyboardbutton">callback_game</a> button.<br /><br />Otherwise, you may use links like <em>t.me/your_bot?start=XXXX</em> that open your bot with a parameter.
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string? Url { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.
    /// </summary>
    [JsonPropertyName(PropertyNames.CacheTime)]
    public int? CacheTime { get; set; }
}
