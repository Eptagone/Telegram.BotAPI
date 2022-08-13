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
        /// <summary>Use this method to get the current value of the bot's menu button in a private chat, or the default menu button. Returns MenuButton on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be returned.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static MenuButton GetChatMenuButton(this BotClient api, [Optional] long? chatId)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (chatId is not null)
            {
                json.WriteNumber(PropertyNames.ChatId, (int)chatId);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return api.RPC<MenuButton>(MethodNames.GetChatMenuButton, stream);
        }

        /// <summary>Use this method to get the current value of the bot's menu button in a private chat, or the default menu button. Returns MenuButton on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be returned.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<MenuButton> GetChatMenuButtonAsync(this BotClient api, [Optional] long? chatId, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (chatId is not null)
            {
                json.WriteNumber(PropertyNames.ChatId, (int)chatId);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await api.RPCA<MenuButton>(MethodNames.GetChatMenuButton, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
