// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>Available Methods</summary>
public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages to delete. See deleteMessage for limitations on which messages can be deleted.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool DeleteMessages(this ITelegramBotClient client, long chatId, IEnumerable<int> messageIds)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new Dictionary<string, object>()
		{
			{PropertyNames.ChatId, chatId},
			{PropertyNames.MessageIds, messageIds}
		};
		return client.CallMethod<bool>(MethodNames.DeleteMessages, args);
	}

	/// <summary>
	/// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages to delete. See deleteMessage for limitations on which messages can be deleted.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool DeleteMessages(this ITelegramBotClient client, string chatId, IEnumerable<int> messageIds)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new Dictionary<string, object>()
		{
			{PropertyNames.ChatId, chatId},
			{PropertyNames.MessageIds, messageIds}
		};
		return client.CallMethod<bool>(MethodNames.DeleteMessages, args);
	}

	/// <summary>
	/// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages to delete. See deleteMessage for limitations on which messages can be deleted.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> DeleteMessagesAsync(this ITelegramBotClient client, long chatId, IEnumerable<int> messageIds, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new Dictionary<string, object>()
		{
			{PropertyNames.ChatId, chatId},
			{PropertyNames.MessageIds, messageIds}
		};
		return await client.CallMethodAsync<bool>(MethodNames.DeleteMessages, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageIds">Identifiers of 1-100 messages to delete. See deleteMessage for limitations on which messages can be deleted.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> DeleteMessagesAsync(this ITelegramBotClient client, string chatId, IEnumerable<int> messageIds, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new Dictionary<string, object>()
		{
			{PropertyNames.ChatId, chatId},
			{PropertyNames.MessageIds, messageIds}
		};
		return await client.CallMethodAsync<bool>(MethodNames.DeleteMessages, args, cancellationToken).ConfigureAwait(false);
	}
}
