// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class UpdatingMessagesExtensions
{
	/// <summary>Use this method to edit only the reply markup of messages.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static TReturn EditMessageReplyMarkup<TReturn>(this ITelegramBotClient client, EditMessageReplyMarkupArgs args)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(TReturn) != typeof(Message) && typeof(TReturn) != typeof(bool))
		{
			throw new ArgumentException($"{nameof(TReturn)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return client.CallMethod<TReturn>(MethodNames.EditMessageReplyMarkup, args);
	}

	/// <summary>Use this method to edit only the reply markup of messages.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static async Task<TReturn> EditMessageReplyMarkupAsync<TReturn>(this ITelegramBotClient client, EditMessageReplyMarkupArgs args, CancellationToken cancellationToken = default)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(TReturn) != typeof(Message) && typeof(TReturn) != typeof(bool))
		{
			throw new ArgumentException($"{nameof(TReturn)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return await client.CallMethodAsync<TReturn>(MethodNames.EditMessageReplyMarkup, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to edit only the reply markup of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageReplyMarkup(this ITelegramBotClient client, long chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageReplyMarkupArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageReplyMarkup, args);
	}

	/// <summary>
	/// Use this method to edit only the reply markup of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageReplyMarkup(this ITelegramBotClient client, string chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageReplyMarkupArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageReplyMarkup, args);
	}

	/// <summary>
	/// Use this method to edit only the reply markup of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> EditMessageReplyMarkupAsync(this ITelegramBotClient client, long chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageReplyMarkupArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.EditMessageReplyMarkup, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit only the reply markup of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> EditMessageReplyMarkupAsync(this ITelegramBotClient client, string chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageReplyMarkupArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.EditMessageReplyMarkup, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to edit only the reply markup of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool EditMessageReplyMarkup(this ITelegramBotClient client, string inlineMessageId, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageReplyMarkupArgs(inlineMessageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<bool>(MethodNames.EditMessageReplyMarkup, args);
	}

	/// <summary>
	/// Use this method to edit only the reply markup of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<bool> EditMessageReplyMarkupAsync(this ITelegramBotClient client, string inlineMessageId, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageReplyMarkupArgs(inlineMessageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<bool>(MethodNames.EditMessageReplyMarkup, args, cancellationToken);
	}
}
