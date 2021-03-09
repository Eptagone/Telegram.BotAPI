// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. The link can be revoked using the method revokeChatInviteLink. Returns the new invite link as <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire.</param>
        /// <param name="memberLimit">Maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static ChatInviteLink CreateChatInviteLink(this BotClient bot, long chatId, [Optional] uint expireDate, [Optional] uint memberLimit)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            if (expireDate != default)
            {
                json.WriteNumber(PropertyNames.ExpireDate, expireDate);
            }
            if (memberLimit != default)
            {
                json.WriteNumber(PropertyNames.MemberLimit, memberLimit);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<ChatInviteLink>(MethodNames.CreateChatInviteLink, stream);
        }
        /// <summary>Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. The link can be revoked using the method revokeChatInviteLink. Returns the new invite link as <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire.</param>
        /// <param name="memberLimit">Maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static ChatInviteLink CreateChatInviteLink(this BotClient bot, string chatId, [Optional] uint expireDate, [Optional] uint memberLimit)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            if (expireDate != default)
            {
                json.WriteNumber(PropertyNames.ExpireDate, expireDate);
            }
            if (memberLimit != default)
            {
                json.WriteNumber(PropertyNames.MemberLimit, memberLimit);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<ChatInviteLink>(MethodNames.CreateChatInviteLink, stream);
        }
        /// <summary>Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. The link can be revoked using the method revokeChatInviteLink. Returns the new invite link as <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire.</param>
        /// <param name="memberLimit">Maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static async Task<ChatInviteLink> CreateChatInviteLink(this BotClient bot, long chatId, [Optional] uint expireDate, [Optional] uint memberLimit, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            if (expireDate != default)
            {
                json.WriteNumber(PropertyNames.ExpireDate, expireDate);
            }
            if (memberLimit != default)
            {
                json.WriteNumber(PropertyNames.MemberLimit, memberLimit);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<ChatInviteLink>(MethodNames.CreateChatInviteLink, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. The link can be revoked using the method revokeChatInviteLink. Returns the new invite link as <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire.</param>
        /// <param name="memberLimit">Maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static async Task<ChatInviteLink> CreateChatInviteLink(this BotClient bot, string chatId, [Optional] uint expireDate, [Optional] uint memberLimit, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            if (expireDate != default)
            {
                json.WriteNumber(PropertyNames.ExpireDate, expireDate);
            }
            if (memberLimit != default)
            {
                json.WriteNumber(PropertyNames.MemberLimit, memberLimit);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<ChatInviteLink>(MethodNames.CreateChatInviteLink, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}