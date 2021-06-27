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
    /// <summary>Base class for Telegram Bots using async methods.</summary>
    public abstract class TelegramBotAsync : IAsyncTelegramBot
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        public virtual async Task OnUpdateAsync(Update update, [Optional] CancellationToken cancellationToken)
        {
            if (update == default)
            {
                throw new ArgumentNullException(nameof(update));
            }
            try
            {
                switch (update.Type)
                {
                    case UpdateType.Message:
                        await OnMessageAsync(update.Message, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.EditedMessage:
                        await OnEditedMessageAsync(update.EditedMessage, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.ChannelPost:
                        await OnChannelPostAsync(update.ChannelPost, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.EditedChannelPost:
                        await OnEditedChannelPostAsync(update.EditedChannelPost, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.InlineQuery:
                        await OnInlineQueryAsync(update.InlineQuery, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.ChosenInlineResult:
                        await OnChosenInlineResultAsync(update.ChosenInlineResult, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.CallbackQuery:
                        await OnCallbackQueryAsync(update.CallbackQuery, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.ShippingQuery:
                        await OnShippingQueryAsync(update.ShippingQuery, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.PreCheckoutQuery:
                        await OnPreCheckoutQueryAsync(update.PreCheckoutQuery, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.Poll:
                        await OnPollAsync(update.Poll, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.PollAnswer:
                        await OnPollAnswerAsync(update.PollAnswer, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.MyChatMember:
                        await OnMyChatMemberAsync(update.MyChatMember, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.ChatMember:
                        await OnChatMemberAsync(update.ChatMember, cancellationToken).ConfigureAwait(false);
                        break;
                    case UpdateType.Unknown:
                    default:
                        throw new ArgumentException("The update parameter does not correspond to a valid update.", nameof(update));
                }
            }
            catch (BotRequestException exp)
            {
                await OnBotExceptionAsync(exp, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception exp)
            {
                await OnExceptionAsync(exp, cancellationToken).ConfigureAwait(false);
            }
        }
        /// <summary>Instructions for a message update.</summary>
        /// <param name="message">Message.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnMessageAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a edited message.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnEditedMessageAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a channel post.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnChannelPostAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a edited channel post update.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnEditedChannelPostAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a inline query update.</summary>
        /// <param name="inlineQuery">Inline query.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnInlineQueryAsync(InlineQuery inlineQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a chosen inline result update.</summary>
        /// <param name="chosenInlineResult">Chosen Inline Result.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnChosenInlineResultAsync(ChosenInlineResult chosenInlineResult, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a callback query update.</summary>
        /// <param name="callbackQuery">Callback query</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnCallbackQueryAsync(CallbackQuery callbackQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a shipping query update.</summary>
        /// <param name="shippingQuery">Shipping query</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnShippingQueryAsync(ShippingQuery shippingQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a pre-checkout query update.</summary>
        /// <param name="preCheckoutQuery">Pre-checkout query.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnPreCheckoutQueryAsync(PreCheckoutQuery preCheckoutQuery, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a poll update.</summary>
        /// <param name="poll">Poll.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnPollAsync(Poll poll, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a poll answer update.</summary>
        /// <param name="pollAnswer">Poll answer.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnPollAnswerAsync(PollAnswer pollAnswer, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for my chat member updated.</summary>
        /// <param name="myChatMemberUpdated">Poll answer.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnMyChatMemberAsync(ChatMemberUpdated myChatMemberUpdated, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for chat member updated.</summary>
        /// <param name="chatMemberUpdated">Poll answer.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnChatMemberAsync(ChatMemberUpdated chatMemberUpdated, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a bot exception.</summary>
        /// <param name="exp">Bot exception</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnBotExceptionAsync(BotRequestException exp, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a general exception.</summary>
        /// <param name="exp">Exception</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnExceptionAsync(Exception exp, [Optional] CancellationToken cancellationToken);
    }
}
