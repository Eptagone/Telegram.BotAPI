// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, “🎳”, or “🎰”. Dice can have values 1-6 for “🎲”, “🎯” and “🎳”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient bot, string chatId, [Optional] string emoji, [Optional] bool disableNotification, [Optional] int replyToMessageId, [Optional] bool allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(chatId))
            {
                throw new ArgumentNullException(nameof(chatId));
            }

            var args = new SendDiceArgs
            {
                ChatId = chatId
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disableNotification)
            {
                args.DisableNotification = disableNotification;
            }

            if (replyToMessageId != default)
            {
                args.ReplyToMessageId = replyToMessageId;
            }

            if (allowSendingWithoutReply)
            {
                args.AllowSendingWithoutReply = allowSendingWithoutReply;
            }

            if (replyMarkup != null)
            {
                args.ReplyMarkup = replyMarkup;
            }

            return bot.RPC<Message>(MethodNames.SendDice, args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, or “🎰”. Dice can have values 1-6 for “🎲” and “🎯”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient bot, long chatId, [Optional] string emoji, [Optional] bool disableNotification, [Optional] int replyToMessageId, [Optional] bool allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (chatId == default)
            {
                throw new ArgumentNullException(nameof(chatId));
            }

            var args = new SendDiceArgs
            {
                ChatId = chatId
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disableNotification)
            {
                args.DisableNotification = disableNotification;
            }

            if (replyToMessageId != default)
            {
                args.ReplyToMessageId = replyToMessageId;
            }

            if (allowSendingWithoutReply)
            {
                args.AllowSendingWithoutReply = allowSendingWithoutReply;
            }

            if (replyMarkup != null)
            {
                args.ReplyMarkup = replyMarkup;
            }

            return bot.RPC<Message>(MethodNames.SendDice, args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient bot, SendDiceArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<Message>(MethodNames.SendDice, args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, or “🎰”. Dice can have values 1-6 for “🎲” and “🎯”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient bot, string chatId, [Optional] string emoji, [Optional] bool disableNotification, [Optional] int replyToMessageId, [Optional] bool allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(chatId))
            {
                throw new ArgumentNullException(nameof(chatId));
            }

            var args = new SendDiceArgs
            {
                ChatId = chatId
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disableNotification)
            {
                args.DisableNotification = disableNotification;
            }

            if (replyToMessageId != default)
            {
                args.ReplyToMessageId = replyToMessageId;
            }

            if (allowSendingWithoutReply)
            {
                args.AllowSendingWithoutReply = allowSendingWithoutReply;
            }

            if (replyMarkup != null)
            {
                args.ReplyMarkup = replyMarkup;
            }

            return await bot.RPCA<Message>(MethodNames.SendDice, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, or “🎰”. Dice can have values 1-6 for “🎲” and “🎯”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient bot, long chatId, [Optional] string emoji, [Optional] bool disableNotification, [Optional] int replyToMessageId, [Optional] bool allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (chatId == default)
            {
                throw new ArgumentNullException(nameof(chatId));
            }

            var args = new SendDiceArgs
            {
                ChatId = chatId
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disableNotification)
            {
                args.DisableNotification = disableNotification;
            }

            if (replyToMessageId != default)
            {
                args.ReplyToMessageId = replyToMessageId;
            }

            if (allowSendingWithoutReply)
            {
                args.AllowSendingWithoutReply = allowSendingWithoutReply;
            }

            if (replyMarkup != null)
            {
                args.ReplyMarkup = replyMarkup;
            }

            return await bot.RPCA<Message>(MethodNames.SendDice, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient bot, SendDiceArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Message>(MethodNames.SendDice, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
