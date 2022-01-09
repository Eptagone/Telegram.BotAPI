// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Net.Http;
using System.Runtime.InteropServices;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    /// <summary>Represents a set of basic bot configuration properties.</summary>
    public class BotProperties : IBotProperties
    {
        /// <summary>Initialize a new instance of <see cref="BotProperties"/>.</summary>
        /// <param name="bot">The Telegram Bot Client</param>
        public BotProperties(BotClient bot)
        {
            Api = bot;
            User = bot.GetMe();
            CommandHelper = new BotCommandHelper(this);
        }
        /// <summary>Initialize a new instance of <see cref="BotProperties"/>.</summary>
        /// <param name="botToken">Token granted by BotFather. Required to access the Telegram bot API.</param>
        /// <param name="httpClient">Provide a specific HttpClient for this instance of BotClient.</param>
        public BotProperties(string botToken, [Optional] HttpClient httpClient) : this(new BotClient(botToken, httpClient))
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public BotClient Api { get; }
        public User User { get; }
        public BotCommandHelper CommandHelper { get; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
