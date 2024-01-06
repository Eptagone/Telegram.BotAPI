// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.
	/// </summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
	public static TReturn StopMessageLiveLocation<TReturn>(this ITelegramBotClient client, StopMessageLiveLocationArgs args)
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
		return client.CallMethod<TReturn>(MethodNames.StopMessageLiveLocation, args);
	}

	/// <summary>
	/// Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.
	/// </summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
	public static async Task<TReturn> StopMessageLiveLocationAsync<TReturn>(this ITelegramBotClient client, StopMessageLiveLocationArgs args, CancellationToken cancellationToken = default)
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
		return await client.CallMethodAsync<TReturn>(MethodNames.StopMessageLiveLocation, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to stop updating a live location message before live_period expires. On success, if the message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message with live location to stop.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message StopMessageLiveLocation(this ITelegramBotClient client, long chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new StopMessageLiveLocationArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.StopMessageLiveLocation, args);
	}

	/// <summary>
	/// Use this method to stop updating a live location message before live_period expires. On success, if the message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message with live location to stop.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message StopMessageLiveLocation(this ITelegramBotClient client, string chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new StopMessageLiveLocationArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.StopMessageLiveLocation, args);
	}

	/// <summary>
	/// Use this method to stop updating a live location message before live_period expires. On success, if the message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message with live location to stop.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> StopMessageLiveLocationAsync(this ITelegramBotClient client, long chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new StopMessageLiveLocationArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.StopMessageLiveLocation, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to stop updating a live location message before live_period expires. On success, if the message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message with live location to stop.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> StopMessageLiveLocationAsync(this ITelegramBotClient client, string chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new StopMessageLiveLocationArgs(chatId, messageId)
		{
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.StopMessageLiveLocation, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to stop updating a live location message before live_period expires. On success, if the message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool StopMessageLiveLocation(this ITelegramBotClient client, string inlineMessageId, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new StopMessageLiveLocationArgs(inlineMessageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<bool>(MethodNames.StopMessageLiveLocation, args);
	}

	/// <summary>
	/// Use this method to stop updating a live location message before live_period expires. On success, if the message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<bool> StopMessageLiveLocationAsync(this ITelegramBotClient client, string inlineMessageId, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new StopMessageLiveLocationArgs(inlineMessageId)
		{
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<bool>(MethodNames.StopMessageLiveLocation, args, cancellationToken);
	}
}
