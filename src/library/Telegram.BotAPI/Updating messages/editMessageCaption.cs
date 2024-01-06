// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class UpdatingMessagesExtensions
{
	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when <typeparamref name="TReturn"/> is not <see cref="Message"/> or <see cref="bool"/>.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static TReturn EditMessageCaption<TReturn>(this ITelegramBotClient client, EditMessageCaptionArgs args)
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
		return client.CallMethod<TReturn>(MethodNames.EditMessageCaption, args);
	}
	
	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when <typeparamref name="TReturn"/> is not <see cref="Message"/> or <see cref="bool"/>.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static Task<TReturn> EditMessageCaptionAsync<TReturn>(this ITelegramBotClient client, EditMessageCaptionArgs args, CancellationToken cancellationToken = default)
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
		return client.CallMethodAsync<TReturn>(MethodNames.EditMessageCaption, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageCaption(this ITelegramBotClient client, long chatId, int messageId, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageCaptionArgs(chatId, messageId)
		{
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageCaption, args);
	}

	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageCaption(this ITelegramBotClient client, string chatId, int messageId, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageCaptionArgs(chatId, messageId)
		{
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageCaption, args);
	}

	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> EditMessageCaptionAsync(this ITelegramBotClient client, long chatId, int messageId, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageCaptionArgs(chatId, messageId)
		{
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.EditMessageCaption, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> EditMessageCaptionAsync(this ITelegramBotClient client, string chatId, int messageId, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageCaptionArgs(chatId, messageId)
		{
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.EditMessageCaption, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool EditMessageCaption(this ITelegramBotClient client, string inlineMessageId, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageCaptionArgs(inlineMessageId)
		{
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<bool>(MethodNames.EditMessageCaption, args);
	}

	/// <summary>
	/// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<bool> EditMessageCaptionAsync(this ITelegramBotClient client, string inlineMessageId, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageCaptionArgs(inlineMessageId)
		{
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<bool>(MethodNames.EditMessageCaption, args, cancellationToken);
	}
}