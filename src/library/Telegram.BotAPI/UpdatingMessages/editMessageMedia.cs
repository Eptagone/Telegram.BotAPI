// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class UpdatingMessagesExtensions
{
	/// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static TReturn EditMessageMedia<TReturn>(this ITelegramBotClient client, EditMessageMediaArgs args)
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
		return client.CallMethod<TReturn>(MethodNames.EditMessageMedia, args);
	}

	/// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static Task<TReturn> EditMessageMediaAsync<TReturn>(this ITelegramBotClient client, EditMessageMediaArgs args, CancellationToken cancellationToken = default)
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
		return client.CallMethodAsync<TReturn>(MethodNames.EditMessageMedia, args, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// Use this method to edit animation, audio, document, photo, or video messages. If a message is part of a message album, then it can be edited only to an audio for audio albums, only to a document for document albums and to a photo or a video otherwise. When an inline message is edited, a new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageMedia(this ITelegramBotClient client, long chatId, int messageId, InputMedia media, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageMediaArgs(chatId, messageId, media)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageMedia, args);
	}

	/// <summary>
	/// Use this method to edit animation, audio, document, photo, or video messages. If a message is part of a message album, then it can be edited only to an audio for audio albums, only to a document for document albums and to a photo or a video otherwise. When an inline message is edited, a new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageMedia(this ITelegramBotClient client, string chatId, int messageId, InputMedia media, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageMediaArgs(chatId, messageId, media)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageMedia, args);
	}

	/// <summary>
	/// Use this method to edit animation, audio, document, photo, or video messages. If a message is part of a message album, then it can be edited only to an audio for audio albums, only to a document for document albums and to a photo or a video otherwise. When an inline message is edited, a new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> EditMessageMediaAsync(this ITelegramBotClient client, long chatId, int messageId, InputMedia media, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageMediaArgs(chatId, messageId, media)
		{
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.EditMessageMedia, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to edit animation, audio, document, photo, or video messages. If a message is part of a message album, then it can be edited only to an audio for audio albums, only to a document for document albums and to a photo or a video otherwise. When an inline message is edited, a new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> EditMessageMediaAsync(this ITelegramBotClient client, string chatId, int messageId, InputMedia media, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageMediaArgs(chatId, messageId, media)
		{
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.EditMessageMedia, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to edit animation, audio, document, photo, or video messages. If a message is part of a message album, then it can be edited only to an audio for audio albums, only to a document for document albums and to a photo or a video otherwise. When an inline message is edited, a new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool EditMessageMedia(this ITelegramBotClient client, string inlineMessageId, InputMedia media, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageMediaArgs(inlineMessageId, media)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<bool>(MethodNames.EditMessageMedia, args);
	}

	/// <summary>
	/// Use this method to edit animation, audio, document, photo, or video messages. If a message is part of a message album, then it can be edited only to an audio for audio albums, only to a document for document albums and to a photo or a video otherwise. When an inline message is edited, a new file can't be uploaded; use a previously uploaded file via its file_id or specify a URL. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<bool> EditMessageMediaAsync(this ITelegramBotClient client, string inlineMessageId, InputMedia media, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageMediaArgs(inlineMessageId, media)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<bool>(MethodNames.EditMessageMedia, args, cancellationToken);
	}
}