// Copyright (c) 2022 Quetzal Rivera.
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
    /// <summary>Base class for Telegram Bots.</summary>
    public abstract class AsyncTelegramBotBase<TBotProperties> : AsyncTelegramBotBase
        where TBotProperties : IBotProperties
    {
        /// <summary>The telegram bot properties.</summary>
        protected TBotProperties Properties => _properties;
        private readonly TBotProperties _properties;

        /// <summary>Bot client instance to interact with the Telegram Bot API.</summary>
        protected BotClient Api => _properties.Api;
        /// <summary>The basic information about the bot.</summary>
        protected User Me => _properties.User;

        /// <summary>Current update instance.</summary>
        protected Update Update { get; private set; }
        /// <summary>Current message instance.</summary>
        protected Message Message { get; set; }

        /// <summary>
        /// Initialize a new instance of <see cref="AsyncTelegramBotBase"/>.
        /// </summary>
        /// <param name="botProperties">Bot properties.</param>
        public AsyncTelegramBotBase(TBotProperties botProperties)
        {
            _properties = botProperties;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override async Task OnUpdateAsync(Update update, [Optional] CancellationToken cancellationToken)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Update = update;
            await base.OnUpdateAsync(update, cancellationToken);
        }

        /// <summary>
        /// Process received messages. If a bot command is detected, then the <see cref="OnCommandAsync(Message, string, string, CancellationToken)"/> method is called.
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        protected override async Task OnMessageAsync(Message message, [Optional] CancellationToken cancellationToken)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            var cmdMatch = _properties.CommandHelper.Match(message.Text);
            if (cmdMatch.Success)
            {
                await OnCommandAsync(message, cmdMatch.Name, cmdMatch.Params, cancellationToken);
            }
        }

        /// <summary>
        /// Read and process a received bot command.<br/>Example: <code>/&lt;command name&gt; &lt;command parameters&gt;</code>
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="commandName">Command name.<br/>Example: <code>/<b>&lt;command name&gt;</b> &lt;command parameters&gt;</code></param>
        /// <param name="commandParameters">Command parameters.<br/>Example: <code>/&lt;command name&gt; <b>&lt;command parameters&gt;</b></code></param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnCommandAsync(Message message, string commandName, string commandParameters, [Optional] CancellationToken cancellationToken);
    }

    /// <summary>Base class for Telegram Bots.</summary>
    public abstract class AsyncTelegramBotBase : ITelegramBot
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
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
                    case UpdateType.ChatJoinRequest:
                        await OnChatJoinRequestAsync(update.ChatJoinRequest).ConfigureAwait(false);
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
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnMessageAsync(Message message, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a edited message.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnEditedMessageAsync(Message message, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a channel post.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnChannelPostAsync(Message message, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a edited channel post update.</summary>
        /// <param name="message">Message</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnEditedChannelPostAsync(Message message, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a inline query update.</summary>
        /// <param name="inlineQuery">Inline query.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnInlineQueryAsync(InlineQuery inlineQuery, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a chosen inline result update.</summary>
        /// <param name="chosenInlineResult">Chosen Inline Result.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnChosenInlineResultAsync(ChosenInlineResult chosenInlineResult, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a callback query update.</summary>
        /// <param name="callbackQuery">Callback query</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnCallbackQueryAsync(CallbackQuery callbackQuery, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a shipping query update.</summary>
        /// <param name="shippingQuery">Shipping query</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnShippingQueryAsync(ShippingQuery shippingQuery, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a pre-checkout query update.</summary>
        /// <param name="preCheckoutQuery">Pre-checkout query.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnPreCheckoutQueryAsync(PreCheckoutQuery preCheckoutQuery, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a poll update.</summary>
        /// <param name="poll">Poll.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnPollAsync(Poll poll, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for a poll answer update.</summary>
        /// <param name="pollAnswer">Poll answer.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnPollAnswerAsync(PollAnswer pollAnswer, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for my chat member update.</summary>
        /// <param name="myChatMemberUpdated">Poll answer.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnMyChatMemberAsync(ChatMemberUpdated myChatMemberUpdated, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for chat member update.</summary>
        /// <param name="chatMemberUpdated">Poll answer.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnChatMemberAsync(ChatMemberUpdated chatMemberUpdated, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;
        /// <summary>Instructions for chat join request update.</summary>
        /// <param name="chatJoinRequest">Chat join request.</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected virtual Task OnChatJoinRequestAsync(ChatJoinRequest chatJoinRequest, [Optional] CancellationToken cancellationToken) => Task.CompletedTask;

        /// <summary>Instructions for a bot exception.</summary>
        /// <param name="exp">Bot exception</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnBotExceptionAsync(BotRequestException exp, [Optional] CancellationToken cancellationToken);
        /// <summary>Instructions for a general exception.</summary>
        /// <param name="exp">Exception</param>
        /// <param name="cancellationToken">Optional. The cancelation token.</param>
        /// <returns><see cref="Task"/></returns>
        protected abstract Task OnExceptionAsync(Exception exp, [Optional] CancellationToken cancellationToken);

#pragma warning disable CA1033 // Interface methods should be callable by child types
        void ITelegramBot.OnUpdate(Update update)
#pragma warning restore CA1033 // Interface methods should be callable by child types
        {
            OnUpdateAsync(update).Wait();
        }
    }
}
