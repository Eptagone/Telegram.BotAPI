// Copyright (c) 2022 Quetzal Rivera.
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
        /// <summary>Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the revoked invite link <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="inviteLink">The invite link to revoke.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static ChatInviteLink RevokeChatInviteLink(this BotClient bot, long chatId, string inviteLink)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (string.IsNullOrEmpty(inviteLink))
            {
                throw new ArgumentNullException(nameof(inviteLink));
            }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteString(PropertyNames.InviteLink, inviteLink);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<ChatInviteLink>(MethodNames.RevokeChatInviteLink, stream);
        }
        /// <summary>Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the revoked invite link <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="inviteLink">The invite link to revoke.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static ChatInviteLink RevokeChatInviteLink(this BotClient bot, string chatId, string inviteLink)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (string.IsNullOrEmpty(inviteLink))
            {
                throw new ArgumentNullException(nameof(inviteLink));
            }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteString(PropertyNames.InviteLink, inviteLink);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<ChatInviteLink>(MethodNames.RevokeChatInviteLink, stream);
        }
        /// <summary>Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the revoked invite link <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="inviteLink">The invite link to revoke.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static async Task<ChatInviteLink> RevokeChatInviteLink(this BotClient bot, long chatId, string inviteLink, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (string.IsNullOrEmpty(inviteLink))
            {
                throw new ArgumentNullException(nameof(inviteLink));
            }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteString(PropertyNames.InviteLink, inviteLink);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<ChatInviteLink>(MethodNames.RevokeChatInviteLink, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the revoked invite link <see cref="ChatInviteLink"/> object.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="inviteLink">The invite link to revoke.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="ChatInviteLink"/></returns>
        public static async Task<ChatInviteLink> RevokeChatInviteLink(this BotClient bot, string chatId, string inviteLink, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (string.IsNullOrEmpty(inviteLink))
            {
                throw new ArgumentNullException(nameof(inviteLink));
            }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteString(PropertyNames.InviteLink, inviteLink);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<ChatInviteLink>(MethodNames.RevokeChatInviteLink, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}