// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class UpdatingMessagesExtensions
{
	/// <summary>Use this method to edit text and game messages.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static Message EditMessageText(this BotClient? bot, EditMessageTextArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		return bot.RPC<Message>(MethodNames.EditMessageText, args);
	}
	/// <summary>Use this method to edit text and game messages.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static async Task<Message> EditMessageTextAsync(this BotClient? bot, EditMessageTextArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		return await bot.RPCA<Message>(MethodNames.EditMessageText, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to edit text and game messages.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static T EditMessageText<T>(this BotClient? bot, EditMessageTextArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool) && typeof(T) != typeof(JObject) && typeof(T) != typeof(JsonDocument))
		{
			throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return bot.RPC<T>(MethodNames.EditMessageText, args);
	}

	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageText(this BotClient? bot, long chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return bot.EditMessageText(args);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageText(this BotClient? bot, string chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return bot.EditMessageText(args);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> EditMessageTextAsync(this BotClient? bot, long chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return await bot.EditMessageTextAsync(args, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> EditMessageTextAsync(this BotClient? bot, string chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return await bot.EditMessageTextAsync(args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

	public static Message EditMessageText(this BotClient? bot, string inlineMessageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup)
	{
		var args = new EditMessageTextArgs(text)
		{
			InlineMessageId = inlineMessageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return bot.EditMessageText(args);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

	public static async Task<Message> EditMessageTextAsync(this BotClient? bot, string inlineMessageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		var args = new EditMessageTextArgs(text)
		{
			InlineMessageId = inlineMessageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return await bot.EditMessageTextAsync(args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to edit text and game messages.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static async Task<T> EditMessageTextAsync<T>(this BotClient? bot, EditMessageTextArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool) && typeof(T) != typeof(JObject) && typeof(T) != typeof(JsonDocument))
		{
			throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return await bot.RPCA<T>(MethodNames.EditMessageText, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static T EditMessageText<T>(this BotClient? bot, long chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return bot.EditMessageText<T>(args);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static T EditMessageText<T>(this BotClient? bot, string chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return bot.EditMessageText<T>(args);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static async Task<T> EditMessageTextAsync<T>(this BotClient? bot, long chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return await bot.EditMessageTextAsync<T>(args, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static async Task<T> EditMessageTextAsync<T>(this BotClient? bot, string chatId, int messageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		var args = new EditMessageTextArgs(text)
		{
			ChatId = chatId,
			MessageId = messageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return await bot.EditMessageTextAsync<T>(args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static T EditMessageText<T>(this BotClient? bot, string inlineMessageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup)
	{
		var args = new EditMessageTextArgs(text)
		{
			InlineMessageId = inlineMessageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return bot.EditMessageText<T>(args);
	}
	/// <summary>Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message</param>
	/// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static async Task<T> EditMessageTextAsync<T>(this BotClient? bot, string inlineMessageId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		var args = new EditMessageTextArgs(text)
		{
			InlineMessageId = inlineMessageId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			ReplyMarkup = replyMarkup
		};
		return await bot.EditMessageTextAsync<T>(args, cancellationToken).ConfigureAwait(false);
	}
}
