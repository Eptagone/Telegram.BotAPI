// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static bool BanChatMember(this BotClient bot, long chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.BanChatMember, stream);
        }
        /// <summary>Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static bool BanChatMember(this BotClient bot, string chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.BanChatMember, stream);
        }
        /// <summary>Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static async Task<bool> BanChatMemberAsync(this BotClient bot, long chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.BanChatMember, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static async Task<bool> BanChatMemberAsync(this BotClient bot, string chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.BanChatMember, stream, cancellationToken).ConfigureAwait(false);
        }

        #region kickChatMember Obsolete
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        [Obsolete("This method has been replaced by BanChatMember and will be removed in future releases.")]
        public static bool KickChatMember(this BotClient bot, long chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.KickChatMember, stream);
        }
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        [Obsolete("This method has been replaced by BanChatMember and will be removed in future releases.")]
        public static bool KickChatMember(this BotClient bot, string chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.KickChatMember, stream);
        }
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        [Obsolete("This method has been replaced by BanChatMemberAsync and will be removed in future releases.")]
        public static async Task<bool> KickChatMemberAsync(this BotClient bot, long chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.KickChatMember, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="untilDate">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="revokeMessages">Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        [Obsolete("This method has been replaced by BanChatMemberAsync and will be removed in future releases.")]
        public static async Task<bool> KickChatMemberAsync(this BotClient bot, string chatId, long userId, [Optional] uint? untilDate, [Optional] bool? revokeMessages, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            if (revokeMessages == true)
            {
                json.WriteBoolean(PropertyNames.RevokeMessages, true);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.KickChatMember, stream, cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
