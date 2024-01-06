// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class UpdatingMessagesExtensions
{
	/// <summary>Use this method to edit text and game messages.</summary>
	/// <typeparam name="TReturn">Return type. <see cref="Message"/> or bool</typeparam>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static TReturn EditMessageText<TReturn>(this ITelegramBotClient client, EditMessageTextArgs args)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(TReturn) != typeof(Message) && typeof(TReturn) != typeof(bool))
		{
			throw new ArgumentException($"{nameof(TReturn)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return client.CallMethod<TReturn>(MethodNames.EditMessageText, args);
	}

	/// <summary>Use this method to edit text and game messages.</summary>
	/// <typeparam name="TReturn">Return type. <see cref="Message"/> or bool</typeparam>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken"></param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static Task<TReturn> EditMessageTextAsync<TReturn>(this ITelegramBotClient client, EditMessageTextArgs args, CancellationToken cancellationToken = default)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(TReturn) != typeof(Message) && typeof(TReturn) != typeof(bool))
		{
			throw new ArgumentException($"{nameof(TReturn)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return client.CallMethodAsync<TReturn>(MethodNames.EditMessageText, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageText(this ITelegramBotClient client, long chatId, int messageId, string text, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new EditMessageTextArgs(chatId, messageId, text)
		{
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageText, args);
	}

	/// <summary>
	/// Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageText(this ITelegramBotClient client, string chatId, int messageId, string text, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new EditMessageTextArgs(chatId, messageId, text)
		{
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageText, args);
	}

	/// <summary>
	/// Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> EditMessageTextAsync(this ITelegramBotClient client, long chatId, int messageId, string text, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new EditMessageTextArgs(chatId, messageId, text)
		{
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.EditMessageText, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> EditMessageTextAsync(this ITelegramBotClient client, string chatId, int messageId, string text, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new EditMessageTextArgs(chatId, messageId, text)
		{
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.EditMessageText, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool EditMessageText(this ITelegramBotClient client, string inlineMessageId, string text, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new EditMessageTextArgs(inlineMessageId, text)
		{
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<bool>(MethodNames.EditMessageText, args);
	}

	/// <summary>
	/// Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<bool> EditMessageTextAsync(this ITelegramBotClient client, string inlineMessageId, string text, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new EditMessageTextArgs(inlineMessageId, text)
		{
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<bool>(MethodNames.EditMessageText, args, cancellationToken);
	}
}
