// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send point on the map. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendLocation(this BotClient? bot, SendLocationArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.RPC<Message>(MethodNames.SendLocation, args);
	}
	/// <summary>Use this method to send point on the map. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static async Task<Message> SendLocationAsync(this BotClient? bot, SendLocationArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.RPCA<Message>(MethodNames.SendLocation, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send point on the map. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the location.</param>
	/// <param name="longitude">Longitude of the location.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="livePeriod">Period in seconds for which the location will be updated (see Live Locations, should be between 60 and 86400.</param>
	/// <param name="heading">For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendLocation(this BotClient? api, long chatId, float latitude, float longitude, [Optional] int? messageThreadId, [Optional] float? horizontalAccuracy, [Optional] uint? livePeriod, [Optional] ushort? heading, [Optional] uint? proximityAlertRadius, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendLocationArgs(chatId, latitude, longitude)
		{
			MessageThreadId = messageThreadId,
			HorizontalAccuracy = horizontalAccuracy,
			LivePeriod = livePeriod,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return api.RPC<Message>(MethodNames.SendLocation, args);
	}

	/// <summary>
	/// Use this method to send point on the map. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the location.</param>
	/// <param name="longitude">Longitude of the location.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="livePeriod">Period in seconds for which the location will be updated (see Live Locations, should be between 60 and 86400.</param>
	/// <param name="heading">For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendLocation(this BotClient? api, string chatId, float latitude, float longitude, [Optional] int? messageThreadId, [Optional] float? horizontalAccuracy, [Optional] uint? livePeriod, [Optional] ushort? heading, [Optional] uint? proximityAlertRadius, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendLocationArgs(chatId, latitude, longitude)
		{
			MessageThreadId = messageThreadId,
			HorizontalAccuracy = horizontalAccuracy,
			LivePeriod = livePeriod,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return api.RPC<Message>(MethodNames.SendLocation, args);
	}

	/// <summary>
	/// Use this method to send point on the map. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the location.</param>
	/// <param name="longitude">Longitude of the location.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="livePeriod">Period in seconds for which the location will be updated (see Live Locations, should be between 60 and 86400.</param>
	/// <param name="heading">For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendLocationAsync(this BotClient? api, long chatId, float latitude, float longitude, [Optional] int? messageThreadId, [Optional] float? horizontalAccuracy, [Optional] uint? livePeriod, [Optional] ushort? heading, [Optional] uint? proximityAlertRadius, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendLocationArgs(chatId, latitude, longitude)
		{
			MessageThreadId = messageThreadId,
			HorizontalAccuracy = horizontalAccuracy,
			LivePeriod = livePeriod,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return await api.RPCA<Message>(MethodNames.SendLocation, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send point on the map. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="latitude">Latitude of the location.</param>
	/// <param name="longitude">Longitude of the location.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500.</param>
	/// <param name="livePeriod">Period in seconds for which the location will be updated (see Live Locations, should be between 60 and 86400.</param>
	/// <param name="heading">For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
	/// <param name="proximityAlertRadius">For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendLocationAsync(this BotClient? api, string chatId, float latitude, float longitude, [Optional] int? messageThreadId, [Optional] float? horizontalAccuracy, [Optional] uint? livePeriod, [Optional] ushort? heading, [Optional] uint? proximityAlertRadius, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendLocationArgs(chatId, latitude, longitude)
		{
			MessageThreadId = messageThreadId,
			HorizontalAccuracy = horizontalAccuracy,
			LivePeriod = livePeriod,
			Heading = heading,
			ProximityAlertRadius = proximityAlertRadius,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return await api.RPCA<Message>(MethodNames.SendLocation, args, cancellationToken).ConfigureAwait(false);
	}
}
