// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI
{
    /// <summary>Interface for Telegram Bots</summary>
    public abstract class TelegramBot : ITelegramBot
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
        public abstract void OnMessage(Message message);
        /// <summary>Instructions for a edited message.</summary>
        /// <param name="message">Message</param>
        public abstract void OnEditedMessage(Message message);
        /// <summary>Instructions for a channel post.</summary>
        /// <param name="message">Message</param>
        public abstract void OnChannelPost(Message message);
        /// <summary>Instructions for a edited channel post update.</summary>
        /// <param name="message">Message</param>
        public abstract void OnEditedChannelPost(Message message);
        /// <summary>Instructions for a inline query update.</summary>
        /// <param name="inlineQuery">Inline query.</param>
        public abstract void OnInlineQuery(InlineQuery inlineQuery);
        /// <summary>Instructions for a chosen inline result update.</summary>
        /// <param name="chosenInlineResult">Chosen Inline Result.</param>
        public abstract void OnChosenInlineResult(ChosenInlineResult chosenInlineResult);
        /// <summary>Instructions for a callback query update.</summary>
        /// <param name="callbackQuery">Callback query</param>
        public abstract void OnCallbackQuery(CallbackQuery callbackQuery);
        /// <summary>Instructions for a shipping query update.</summary>
        /// <param name="shippingQuery">Shipping query</param>
        public abstract void OnShippingQuery(ShippingQuery shippingQuery);
        /// <summary>Instructions for a pre-checkout query update.</summary>
        /// <param name="preCheckoutQuery">Pre-checkout query.</param>
        public abstract void OnPreCheckoutQuery(PreCheckoutQuery preCheckoutQuery);
        /// <summary>Instructions for a poll update.</summary>
        /// <param name="poll">Poll.</param>
        public abstract void OnPoll(Poll poll);
        /// <summary>Instructions for a poll answer update.</summary>
        /// <param name="pollAnswer">Poll answer.</param>
        public abstract void OnPollAnswer(PollAnswer pollAnswer);
        /// <summary>Instructions for a bot exception.</summary>
        /// <param name="exp">Bot exception</param>
        public abstract void OnBotException(BotRequestException exp);
        /// <summary>Instructions for a general exception.</summary>
        /// <param name="exp">Exception</param>
        public abstract void OnException(Exception exp);
    }
}
