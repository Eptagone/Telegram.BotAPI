// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;
using System.Threading;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.UpdatingMessages
{
    public static partial class UpdatingMessagesExtensions
    {
        /// <summary>Use this method to delete a message, including service messages, with the following limitations: <br/>
        /// - A message can only be deleted if it was sent less than 48 hours ago.<br/>
        /// - Bots can delete outgoing messages in private chats, groups, and supergroups.<br/>
        /// - Bots can delete incoming messages in private chats.<br/>
        /// - Bots granted can_post_messages permissions can delete outgoing messages in channels.<br/>
        /// - If the bot is an administrator of a group, it can delete any message there.<br/>
        /// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.<br/></summary>
        /// <param name="api"><see cref="BotClient"/> instance.</param>
        /// <param name="message">Message to delete.</param>
        /// <returns>True on success.</returns>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool DeleteMessages(this BotClient api, Message message)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            return api.DeleteMessage(message.Chat.Id, message.MessageId);
        }

        /// <summary>Use this method to delete a message, including service messages, with the following limitations: <br/>
        /// - A message can only be deleted if it was sent less than 48 hours ago.<br/>
        /// - Bots can delete outgoing messages in private chats, groups, and supergroups.<br/>
        /// - Bots can delete incoming messages in private chats.<br/>
        /// - Bots granted can_post_messages permissions can delete outgoing messages in channels.<br/>
        /// - If the bot is an administrator of a group, it can delete any message there.<br/>
        /// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.<br/></summary>
        /// <param name="api"><see cref="BotClient"/> instance.</param>
        /// <param name="message">Message to delete.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>True on success.</returns>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> DeleteMessagesAsync(this BotClient api, Message message, [Optional] CancellationToken cancellationToken)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            return await api.DeleteMessageAsync(message.Chat.Id, message.MessageId, cancellationToken).ConfigureAwait(false);
        }
    }
}
