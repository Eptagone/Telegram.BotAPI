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
    public interface ITelegramBot
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        public void OnUpdate(Update update);
        /// <summary>Instructions for a message update.</summary>
        /// <param name="message">Message.</param>
        public void OnMessage(Message message);
        /// <summary>Instructions for a edited message.</summary>
        /// <param name="message">Message</param>
        public void OnEditedMessage(Message message);
        /// <summary>Instructions for a channel post.</summary>
        /// <param name="message">Message</param>
        public void OnChannelPost(Message message);
        /// <summary>Instructions for a edited channel post update.</summary>
        /// <param name="message">Message</param>
        public void OnEditedChannelPost(Message message);
        /// <summary>Instructions for a inline query update.</summary>
        /// <param name="inlineQuery">Inline query.</param>
        public void OnInlineQuery(InlineQuery inlineQuery);
        /// <summary>Instructions for a chosen inline result update.</summary>
        /// <param name="chosenInlineResult">Chosen Inline Result.</param>
        public void OnChosenInlineResult(ChosenInlineResult chosenInlineResult);
        /// <summary>Instructions for a callback query update.</summary>
        /// <param name="callbackQuery">Callback query</param>
        public void OnCallbackQuery(CallbackQuery callbackQuery);
        /// <summary>Instructions for a shipping query update.</summary>
        /// <param name="shippingQuery">Shipping query</param>
        public void OnShippingQuery(ShippingQuery shippingQuery);
        /// <summary>Instructions for a pre-checkout query update.</summary>
        /// <param name="preCheckoutQuery">Pre-checkout query.</param>
        public void OnPreCheckoutQuery(PreCheckoutQuery preCheckoutQuery);
        /// <summary>Instructions for a poll update.</summary>
        /// <param name="poll">Poll.</param>
        public void OnPoll(Poll poll);
        /// <summary>Instructions for a poll answer update.</summary>
        /// <param name="pollAnswer">Poll answer.</param>
        public void OnPollAnswer(PollAnswer pollAnswer);
        /// <summary>Instructions for a bot exception.</summary>
        /// <param name="exp">Bot exception</param>
        public void OnBotException(BotRequestException exp);
        /// <summary>Instructions for a general exception.</summary>
        /// <param name="exp">Exception</param>
        public void OnException(Exception exp);
    }
}
