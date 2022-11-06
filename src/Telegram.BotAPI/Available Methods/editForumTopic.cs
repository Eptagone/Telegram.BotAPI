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
        /// <summary>
        /// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
        /// <param name="name">New topic name, 1-128 characters.</param>
        /// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool EditForumTopic(this BotClient api, long chatId, int messageThreadId, string name, string iconCustomEmojiId)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
            json.WriteString(PropertyNames.Name, name);
            json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return api.RPC<bool>(MethodNames.EditForumTopic, stream);
        }

        /// <summary>
        /// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
        /// <param name="name">New topic name, 1-128 characters.</param>
        /// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool EditForumTopic(this BotClient api, string chatId, int messageThreadId, string name, string iconCustomEmojiId)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
            json.WriteString(PropertyNames.Name, name);
            json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return api.RPC<bool>(MethodNames.EditForumTopic, stream);
        }

        /// <summary>
        /// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
        /// <param name="name">New topic name, 1-128 characters.</param>
        /// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> EditForumTopicAsync(this BotClient api, long chatId, int messageThreadId, string name, string iconCustomEmojiId, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
            json.WriteString(PropertyNames.Name, name);
            json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await api.RPCA<bool>(MethodNames.EditForumTopic, stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread of the forum topic.</param>
        /// <param name="name">New topic name, 1-128 characters.</param>
        /// <param name="iconCustomEmojiId">New unique identifier of the custom emoji shown as the topic icon. Use getForumTopicIconStickers to get all allowed custom emoji identifiers.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> EditForumTopicAsync(this BotClient api, string chatId, int messageThreadId, string name, string iconCustomEmojiId, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageThreadId, messageThreadId);
            json.WriteString(PropertyNames.Name, name);
            json.WriteString(PropertyNames.IconCustomEmojiId, iconCustomEmojiId);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await api.RPCA<bool>(MethodNames.EditForumTopic, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
