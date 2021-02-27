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
        /// <summary>Instructions for a message update.</summary>
        /// <param name="message">Message.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnMessageAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a edited message.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnEditedMessageAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a channel post.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnChannelPostAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a edited channel post update.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnEditedChannelPostAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a inline query update.</summary>
        /// <param name="inlineQuery">Inline query.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnInlineQueryAsync(InlineQuery inlineQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a chosen inline result update.</summary>
        /// <param name="chosenInlineResult">Chosen Inline Result.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnChosenInlineResultAsync(ChosenInlineResult chosenInlineResult, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a callback query update.</summary>
        /// <param name="callbackQuery">Callback query</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnCallbackQueryAsync(CallbackQuery callbackQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a shipping query update.</summary>
        /// <param name="shippingQuery">Shipping query</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnShippingQueryAsync(ShippingQuery shippingQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a pre-checkout query update.</summary>
        /// <param name="preCheckoutQuery">Pre-checkout query.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnPreCheckoutQueryAsync(PreCheckoutQuery preCheckoutQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a poll update.</summary>
        /// <param name="poll">Poll.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnPollAsync(Poll poll, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a poll answer update.</summary>
        /// <param name="pollAnswer">Poll answer.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnPollAnswerAsync(PollAnswer pollAnswer, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a bot exception.</summary>
        /// <param name="exp">Bot exception</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnBotExceptionAsync(BotRequestException exp, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a general exception.</summary>
        /// <param name="exp">Exception</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public Task OnExceptionAsync(Exception exp, [Optional] CancellationToken cancellationToken);
    }
}
