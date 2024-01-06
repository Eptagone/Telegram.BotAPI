// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static TReturn EditMessageLiveLocation<TReturn>(this ITelegramBotClient bot, EditMessageLiveLocationArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(TReturn) != typeof(Message) && typeof(TReturn) != typeof(bool))
		{
			throw new ArgumentException($"{nameof(TReturn)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return bot.CallMethod<TReturn>(MethodNames.EditMessageLiveLocation, args);
	}

	/// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
	/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
	public static Task<TReturn> EditMessageLiveLocationAsync<TReturn>(this ITelegramBotClient bot, EditMessageLiveLocationArgs args, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}
		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}
		if (typeof(TReturn) != typeof(Message) && typeof(TReturn) != typeof(bool))
		{
			throw new ArgumentException($"{nameof(TReturn)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
		}
		return bot.CallMethodAsync<TReturn>(MethodNames.EditMessageLiveLocation, args, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// Use this method to edit live location messages. A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>]
	/// <param name="latitude">Latitude of new location.</param>
	/// <param name="longitude">Longitude of new location.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageLiveLocation(this ITelegramBotClient client, long chatId, int messageId, float latitude, float longitude, float? horizontalAccuracy = null, ushort? heading = null, uint? proximityAlertRadius = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageLiveLocationArgs(chatId, messageId, latitude, longitude)
		{
			HorizontalAccuracy = horizontalAccuracy,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageLiveLocation, args);
	}

	/// <summary>
	/// Use this method to edit live location messages. A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>]
	/// <param name="latitude">Latitude of new location.</param>
	/// <param name="longitude">Longitude of new location.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message EditMessageLiveLocation(this ITelegramBotClient client, string chatId, int messageId, float latitude, float longitude, float? horizontalAccuracy = null, ushort? heading = null, uint? proximityAlertRadius = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageLiveLocationArgs(chatId, messageId, latitude, longitude)
		{
			HorizontalAccuracy = horizontalAccuracy,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.EditMessageLiveLocation, args);
	}

	/// <summary>
	/// Use this method to edit live location messages. A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="latitude">Latitude of new location.</param>
	/// <param name="longitude">Longitude of new location.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> EditMessageLiveLocationAsync(this ITelegramBotClient client, long chatId, int messageId, float latitude, float longitude, float? horizontalAccuracy = null, ushort? heading = null, uint? proximityAlertRadius = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageLiveLocationArgs(chatId, messageId, latitude, longitude)
		{
			HorizontalAccuracy = horizontalAccuracy,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.EditMessageLiveLocation, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit live location messages. A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="latitude">Latitude of new location.</param>
	/// <param name="longitude">Longitude of new location.</param>
	/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> EditMessageLiveLocationAsync(this ITelegramBotClient client, string chatId, int messageId, float latitude, float longitude, float? horizontalAccuracy = null, ushort? heading = null, uint? proximityAlertRadius = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageLiveLocationArgs(chatId, messageId, latitude, longitude)
		{
			HorizontalAccuracy = horizontalAccuracy,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.EditMessageLiveLocation, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to edit live location messages. A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="latitude">Latitude of new location.</param>
	/// <param name="longitude">Longitude of new location.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool EditMessageLiveLocation(this ITelegramBotClient client, string inlineMessageId, float latitude, float longitude, float? horizontalAccuracy = null, ushort? heading = null, uint? proximityAlertRadius = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageLiveLocationArgs(inlineMessageId, latitude, longitude)
		{
			HorizontalAccuracy = horizontalAccuracy,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<bool>(MethodNames.EditMessageLiveLocation, args);
	}

	/// <summary>
	/// Use this method to edit live location messages. A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="latitude">Latitude of new location.</param>
	/// <param name="longitude">Longitude of new location.</param>
	/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="replyMarkup">A JSON-serialized object for a new inline keyboard.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<bool> EditMessageLiveLocationAsync(this ITelegramBotClient client, string inlineMessageId, float latitude, float longitude, float? horizontalAccuracy = null, ushort? heading = null, uint? proximityAlertRadius = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null) { throw new ArgumentNullException(nameof(client)); }
		var args = new EditMessageLiveLocationArgs(inlineMessageId, latitude, longitude)
		{
			HorizontalAccuracy = horizontalAccuracy,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<bool>(MethodNames.EditMessageLiveLocation, args, cancellationToken);
	}
}