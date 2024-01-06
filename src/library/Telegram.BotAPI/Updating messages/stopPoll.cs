// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>Updating messages</summary>
public static partial class UpdatingMessagesExtensions
{
	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Poll StopPoll(this ITelegramBotClient bot, long chatId, int messageId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<Poll>(MethodNames.StopPoll, stream);
	}

	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Poll StopPoll(this ITelegramBotClient bot, string chatId, int messageId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<Poll>(MethodNames.StopPoll, stream);
	}
	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Poll StopPoll(this ITelegramBotClient bot, long chatId, int messageId, InlineKeyboardMarkup replyMarkup)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (replyMarkup == default)
		{
			throw new ArgumentNullException(nameof(replyMarkup));
		}

		var args = new StopPollArgs
		{
			ChatId = chatId,
			MessageId = messageId,
			ReplyMarkup = replyMarkup
		};
		return bot.CallMethod<Poll>(MethodNames.StopPoll, args);
	}
	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Poll StopPoll(this ITelegramBotClient bot, string chatId, int messageId, InlineKeyboardMarkup replyMarkup)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (replyMarkup == default)
		{
			throw new ArgumentNullException(nameof(replyMarkup));
		}

		var args = new StopPollArgs
		{
			ChatId = chatId,
			MessageId = messageId,
			ReplyMarkup = replyMarkup
		};
		return bot.CallMethod<Poll>(MethodNames.StopPoll, args);
	}

	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Poll> StopPollAsync(this ITelegramBotClient bot, long chatId, int messageId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<Poll>(MethodNames.StopPoll, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Poll> StopPollAsync(this ITelegramBotClient bot, string chatId, int messageId, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.MessageId, messageId);
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<Poll>(MethodNames.StopPoll, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Poll> StopPollAsync(this ITelegramBotClient bot, long chatId, int messageId, [Optional] InlineKeyboardMarkup replyMarkup, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (replyMarkup == default)
		{
			throw new ArgumentNullException(nameof(replyMarkup));
		}

		var args = new StopPollArgs
		{
			ChatId = chatId,
			MessageId = messageId,
			ReplyMarkup = replyMarkup
		};
		return await bot.CallMethodAsync<Poll>(MethodNames.StopPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the original message with the poll</param>
	/// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Poll> StopPollAsync(this ITelegramBotClient bot, string chatId, int messageId, InlineKeyboardMarkup replyMarkup, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (replyMarkup == default)
		{
			throw new ArgumentNullException(nameof(replyMarkup));
		}

		var args = new StopPollArgs
		{
			ChatId = chatId,
			MessageId = messageId,
			ReplyMarkup = replyMarkup
		};
		return await bot.CallMethodAsync<Poll>(MethodNames.StopPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Poll StopPoll(this ITelegramBotClient bot, StopPollArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.CallMethod<Poll>(MethodNames.StopPoll, args);
	}
	/// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Poll> StopPollAsync(this ITelegramBotClient bot, StopPollArgs args, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<Poll>(MethodNames.StopPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}
}
