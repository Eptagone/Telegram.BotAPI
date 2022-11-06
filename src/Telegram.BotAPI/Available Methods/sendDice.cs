// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
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

        /// <summary>
		/// Use this method to send an animated emoji that will display a random value. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, or ÔÇ£ÔÇØ. Dice can have values 1-6 for ÔÇ£ÔÇØ, ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, values 1-5 for ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, and values 1-64 for ÔÇ£ÔÇØ. Defaults to ÔÇ£ÔÇØ.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendDice(this BotClient api, long chatId, [Optional] int? messageThreadId, [Optional] string? emoji, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendDiceArgs(chatId)
            {
                MessageThreadId = messageThreadId,
                Emoji = emoji,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPC<Message>(MethodNames.SendDice, args);
        }

        /// <summary>
        /// Use this method to send an animated emoji that will display a random value. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, or ÔÇ£ÔÇØ. Dice can have values 1-6 for ÔÇ£ÔÇØ, ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, values 1-5 for ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, and values 1-64 for ÔÇ£ÔÇØ. Defaults to ÔÇ£ÔÇØ.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendDice(this BotClient api, string chatId, [Optional] int? messageThreadId, [Optional] string? emoji, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendDiceArgs(chatId)
            {
                MessageThreadId = messageThreadId,
                Emoji = emoji,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPC<Message>(MethodNames.SendDice, args);
        }

        /// <summary>
        /// Use this method to send an animated emoji that will display a random value. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, or ÔÇ£ÔÇØ. Dice can have values 1-6 for ÔÇ£ÔÇØ, ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, values 1-5 for ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, and values 1-64 for ÔÇ£ÔÇØ. Defaults to ÔÇ£ÔÇØ.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendDiceAsync(this BotClient api, long chatId, [Optional] int? messageThreadId, [Optional] string? emoji, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendDiceArgs(chatId)
            {
                MessageThreadId = messageThreadId,
                Emoji = emoji,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCA<Message>(MethodNames.SendDice, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send an animated emoji that will display a random value. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, ÔÇ£ÔÇØ, or ÔÇ£ÔÇØ. Dice can have values 1-6 for ÔÇ£ÔÇØ, ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, values 1-5 for ÔÇ£ÔÇØ and ÔÇ£ÔÇØ, and values 1-64 for ÔÇ£ÔÇØ. Defaults to ÔÇ£ÔÇØ.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendDiceAsync(this BotClient api, string chatId, [Optional] int? messageThreadId, [Optional] string? emoji, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendDiceArgs(chatId)
            {
                MessageThreadId = messageThreadId,
                Emoji = emoji,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCA<Message>(MethodNames.SendDice, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
