// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send information about a venue. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendVenue(this ITelegramBotClient bot, SendVenueArgs args)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.CallMethod<Message>(MethodNames.SendVenue, args);
	}
	/// <summary>Use this method to send information about a venue. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static async Task<Message> SendVenueAsync(this ITelegramBotClient bot, SendVenueArgs args, CancellationToken cancellationToken = default)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<Message>(MethodNames.SendVenue, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send information about a venue. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the venue.</param>
	/// <param name="longitude">Longitude of the venue.</param>
	/// <param name="title">Name of the venue.</param>
	/// <param name="address">Address of the venue.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="foursquareId">Foursquare identifier of the venue.</param>
	/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.).</param>
	/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
	/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVenue(this ITelegramBotClient client, long chatId, float latitude, float longitude, string title, string address, int? messageThreadId = null, string? foursquareId = null, string? foursquareType = null, string? googlePlaceId = null, string? googlePlaceType = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
		{
			MessageThreadId = messageThreadId,
			FoursquareId = foursquareId,
			FoursquareType = foursquareType,
			GooglePlaceId = googlePlaceId,
			GooglePlaceType = googlePlaceType,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendVenue, args);
	}

	/// <summary>
	/// Use this method to send information about a venue. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the venue.</param>
	/// <param name="longitude">Longitude of the venue.</param>
	/// <param name="title">Name of the venue.</param>
	/// <param name="address">Address of the venue.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="foursquareId">Foursquare identifier of the venue.</param>
	/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.).</param>
	/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
	/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVenue(this ITelegramBotClient client, string chatId, float latitude, float longitude, string title, string address, int? messageThreadId = null, string? foursquareId = null, string? foursquareType = null, string? googlePlaceId = null, string? googlePlaceType = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
		{
			MessageThreadId = messageThreadId,
			FoursquareId = foursquareId,
			FoursquareType = foursquareType,
			GooglePlaceId = googlePlaceId,
			GooglePlaceType = googlePlaceType,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendVenue, args);
	}

	/// <summary>
	/// Use this method to send information about a venue. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the venue.</param>
	/// <param name="longitude">Longitude of the venue.</param>
	/// <param name="title">Name of the venue.</param>
	/// <param name="address">Address of the venue.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="foursquareId">Foursquare identifier of the venue.</param>
	/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.).</param>
	/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
	/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendVenueAsync(this ITelegramBotClient client, long chatId, float latitude, float longitude, string title, string address, int? messageThreadId = null, string? foursquareId = null, string? foursquareType = null, string? googlePlaceId = null, string? googlePlaceType = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
		{
			MessageThreadId = messageThreadId,
			FoursquareId = foursquareId,
			FoursquareType = foursquareType,
			GooglePlaceId = googlePlaceId,
			GooglePlaceType = googlePlaceType,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendVenue, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send information about a venue. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the venue.</param>
	/// <param name="longitude">Longitude of the venue.</param>
	/// <param name="title">Name of the venue.</param>
	/// <param name="address">Address of the venue.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="foursquareId">Foursquare identifier of the venue.</param>
	/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.).</param>
	/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
	/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendVenueAsync(this ITelegramBotClient client, string chatId, float latitude, float longitude, string title, string address, int? messageThreadId = null, string? foursquareId = null, string? foursquareType = null, string? googlePlaceId = null, string? googlePlaceType = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
		{
			MessageThreadId = messageThreadId,
			FoursquareId = foursquareId,
			FoursquareType = foursquareType,
			GooglePlaceId = googlePlaceId,
			GooglePlaceType = googlePlaceType,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendVenue, args, cancellationToken).ConfigureAwait(false);
	}
}
