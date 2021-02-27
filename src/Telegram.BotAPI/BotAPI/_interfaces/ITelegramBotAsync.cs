// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI
{
    /// <summary>Interface for Telegram Bots</summary>
    public interface ITelegramBotAsync
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnUpdateAsync(Update update, [Optional] CancellationToken cancellationToken);
    }
}
