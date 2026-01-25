// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

#region AUTHOR

/*
 * ┌────────────────────────────────────────────────────────────────────────────┐
 * │   █████████████████████████████████████████████████████████████████████	│
 * │  =======================================================================	│
 * │   Author: Quetzal Rivera                                             		│
 * │   Email: QuetzalDeveloper@outlook.com                               		│
 * │   Project: Telegram.BotAPI                                           		│
 * │   Creation Date: 13-12-2019                                           		│
 * │   Description: Library to access and interact with the Telegram Bot API. 	│
 * │  =======================================================================	│
 * └────────────────────────────────────────────────────────────────────────────┘
 */

#endregion

using System.Net.Http;

namespace Telegram.BotAPI;

/// <summary>
/// Provides a client for sending requests to the Telegram Bot API.
/// </summary>
/// <param name="options">Options for the <see cref="TelegramBotClient" />.</param>
public partial class TelegramBotClient(TelegramBotClientOptions options) : ITelegramBotClient
{
    private readonly TelegramBotClientOptions options = options;

    /// <summary>
    ///     Initialize a new instance of the <see cref="TelegramBotClient" /> class.
    /// </summary>
    /// <param name="botToken">
    ///     Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram
    ///     bot API.
    /// </param>
    public TelegramBotClient(string botToken)
        : this(new TelegramBotClientOptions(botToken)) { }

    /// <summary>
    ///     Initialize a new instance of the <see cref="TelegramBotClient" /> class.
    /// </summary>
    /// <param name="botToken">
    ///     Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram
    ///     bot API.
    /// </param>
    /// <param name="httpClient">Optional. Provide a specific HttpClient for this instance of BotClient.</param>
    [Obsolete("Specify the httpClient in the options instead")]
    public TelegramBotClient(string botToken, HttpClient? httpClient)
        : this(new TelegramBotClientOptions(botToken))
    {
        if (httpClient is not null)
        {
            this.options.HttpClient = httpClient;
        }
    }

    /// <summary>
    ///     Initialize a new instance of the <see cref="TelegramBotClient" /> class.
    /// </summary>
    /// <param name="options">Options for the <see cref="TelegramBotClient" />.</param>
    /// <param name="httpClient">Optional. Provide a specific HttpClient for this instance of BotClient.</param>
    [Obsolete("Specify the httpClient in the options instead")]
    public TelegramBotClient(TelegramBotClientOptions options, HttpClient? httpClient)
        : this(options)
    {
        if (httpClient is not null)
        {
            this.options.HttpClient = httpClient;
        }
    }
}
