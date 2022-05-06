﻿// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI
{
    /// <summary>Base class for Telegram Bots.</summary>
    public abstract class TelegramBotBase<TBotProperties> : TelegramBotBase
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

        /// <summary>Initialize a new instance of <see cref="TelegramBotBase"/>.</summary>
        /// <param name="botProperties">Bot properties.</param>
        public TelegramBotBase(TBotProperties botProperties)
        {
            _properties = botProperties;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void OnUpdate(Update update)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Update = update;
            base.OnUpdate(update);
        }

        /// <summary>Process received messages. If a bot command is detected, then the <see cref="OnCommand(Message, string, string)"/> method is called.</summary>
        /// <param name="message">Message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        protected override void OnMessage(Message message)
        {
            var cmdMatch = _properties.CommandHelper.Match(message.Text);
            if (cmdMatch.Success)
            {
                OnCommand(message, cmdMatch.Name, cmdMatch.Params);
            }
        }

        /// <summary>
        /// Read and process a received bot command.<br/>Example: <code>/&lt;command name&gt; &lt;command parameters&gt;</code>
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="commandName">Command name.<br/>Example: <code>/<b>&lt;command name&gt;</b> &lt;command parameters&gt;</code></param>
        /// <param name="commandParameters">Command parameters.<br/>Example: <code>/&lt;command name&gt; <b>&lt;command parameters&gt;</b></code></param>
        protected abstract void OnCommand(Message message, string commandName, string commandParameters);
    }

    /// <summary>Base class for Telegram Bots.</summary>
    public abstract class TelegramBotBase : ITelegramBot
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        public virtual void OnUpdate(Update update)
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
                        OnMessage(update.Message);
                        break;
                    case UpdateType.EditedMessage:
                        OnEditedMessage(update.EditedMessage);
                        break;
                    case UpdateType.ChannelPost:
                        OnChannelPost(update.ChannelPost);
                        break;
                    case UpdateType.EditedChannelPost:
                        OnEditedChannelPost(update.EditedChannelPost);
                        break;
                    case UpdateType.InlineQuery:
                        OnInlineQuery(update.InlineQuery);
                        break;
                    case UpdateType.ChosenInlineResult:
                        OnChosenInlineResult(update.ChosenInlineResult);
                        break;
                    case UpdateType.CallbackQuery:
                        OnCallbackQuery(update.CallbackQuery);
                        break;
                    case UpdateType.ShippingQuery:
                        OnShippingQuery(update.ShippingQuery);
                        break;
                    case UpdateType.PreCheckoutQuery:
                        OnPreCheckoutQuery(update.PreCheckoutQuery);
                        break;
                    case UpdateType.Poll:
                        OnPoll(update.Poll);
                        break;
                    case UpdateType.PollAnswer:
                        OnPollAnswer(update.PollAnswer);
                        break;
                    case UpdateType.MyChatMember:
                        OnMyChatMember(update.MyChatMember);
                        break;
                    case UpdateType.ChatMember:
                        OnChatMember(update.ChatMember);
                        break;
                    case UpdateType.ChatJoinRequest:
                        OnChatJoinRequest(update.ChatJoinRequest);
                        break;
                    case UpdateType.Unknown:
                    default:
                        throw new ArgumentException("The update parameter does not correspond to a valid update.", nameof(update));
                }
            }
            catch (BotRequestException exp)
            {
                OnBotException(exp);
            }
            catch (Exception exp)
            {
                OnException(exp);
            }
        }

        /// <summary>Instructions for a message update.</summary>
        /// <param name="message">Message.</param>
        protected abstract void OnMessage(Message message);
        /// <summary>Instructions for an edited message.</summary>
        /// <param name="message">Message</param>
        protected virtual void OnEditedMessage(Message message) { }
        /// <summary>Instructions for a channel post.</summary>
        /// <param name="message">Message</param>
        protected virtual void OnChannelPost(Message message) { }
        /// <summary>Instructions for an edited channel post update.</summary>
        /// <param name="message">Message</param>
        protected virtual void OnEditedChannelPost(Message message) { }
        /// <summary>Instructions for an inline query update.</summary>
        /// <param name="inlineQuery">Inline query.</param>
        protected virtual void OnInlineQuery(InlineQuery inlineQuery) { }
        /// <summary>Instructions for a chosen inline result update.</summary>
        /// <param name="chosenInlineResult">Chosen Inline Result.</param>
        protected virtual void OnChosenInlineResult(ChosenInlineResult chosenInlineResult) { }
        /// <summary>Instructions for a callback query update.</summary>
        /// <param name="callbackQuery">Callback query</param>
        protected virtual void OnCallbackQuery(CallbackQuery callbackQuery) { }
        /// <summary>Instructions for a shipping query update.</summary>
        /// <param name="shippingQuery">Shipping query</param>
        protected virtual void OnShippingQuery(ShippingQuery shippingQuery) { }
        /// <summary>Instructions for a pre-checkout query update.</summary>
        /// <param name="preCheckoutQuery">Pre-checkout query.</param>
        protected virtual void OnPreCheckoutQuery(PreCheckoutQuery preCheckoutQuery) { }
        /// <summary>Instructions for a poll update.</summary>
        /// <param name="poll">Poll.</param>
        protected virtual void OnPoll(Poll poll) { }
        /// <summary>Instructions for a poll answer update.</summary>
        /// <param name="pollAnswer">Poll answer.</param>
        protected virtual void OnPollAnswer(PollAnswer pollAnswer) { }
        /// <summary>Instructions for my chat member update.</summary>
        /// <param name="myChatMemberUpdated">My chat member updated.</param>
        protected virtual void OnMyChatMember(ChatMemberUpdated myChatMemberUpdated) { }
        /// <summary>Instructions for chat member update.</summary>
        /// <param name="chatMemberUpdated">Chat member updated.</param>
        protected virtual void OnChatMember(ChatMemberUpdated chatMemberUpdated) { }
        /// <summary>Instructions for chat join request update.</summary>
        /// <param name="chatJoinRequest">Chat join request.</param>
        protected virtual void OnChatJoinRequest(ChatJoinRequest chatJoinRequest) { }
        /// <summary>Instructions for a bot exception.</summary>
        /// <param name="exp">Bot exception</param>
        protected abstract void OnBotException(BotRequestException exp);
        /// <summary>Instructions for a general exception.</summary>
        /// <param name="exp">Exception</param>
        protected abstract void OnException(Exception exp);
    }
}
