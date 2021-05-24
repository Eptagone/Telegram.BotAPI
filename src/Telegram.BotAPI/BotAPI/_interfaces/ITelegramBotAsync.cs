// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI
{
    /// <summary>Defines the OnUpdate async method, used by basic Telegram bots.</summary>
    public interface IAsyncTelegramBot
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnUpdateAsync(Update update, [Optional] CancellationToken cancellationToken);
    }
}
