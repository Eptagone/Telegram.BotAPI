// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send information about a venue. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendVenue(this BotClient bot, SendVenueArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return bot.RPC<Message>(MethodNames.SendVenue, args);
        }
        /// <summary>Use this method to send information about a venue. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendVenueAsync(this BotClient bot, SendVenueArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Message>(MethodNames.SendVenue, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
		/// Use this method to send information about a venue. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="latitude">Latitude of the venue.</param>
		/// <param name="longitude">Longitude of the venue.</param>
		/// <param name="title">Name of the venue.</param>
		/// <param name="address">Address of the venue.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="foursquareId">Foursquare identifier of the venue.</param>
		/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, ÔÇ£arts_entertainment/defaultÔÇØ, ÔÇ£arts_entertainment/aquariumÔÇØ or ÔÇ£food/icecreamÔÇØ.).</param>
		/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
		/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendVenue(this BotClient api, long chatId, float latitude, float longitude, string title, string address, [Optional] int? messageThreadId, [Optional] string? foursquareId, [Optional] string? foursquareType, [Optional] string? googlePlaceId, [Optional] string? googlePlaceType, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }			
			var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
			{
				MessageThreadId = messageThreadId,
				FoursquareId = foursquareId,
				FoursquareType = foursquareType,
				GooglePlaceId = googlePlaceId,
				GooglePlaceType = googlePlaceType,
				DisableNotification = disableNotification,
				ProtectContent = protectContent,
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<Message>(MethodNames.SendVenue, args);
		}

		/// <summary>
		/// Use this method to send information about a venue. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="latitude">Latitude of the venue.</param>
		/// <param name="longitude">Longitude of the venue.</param>
		/// <param name="title">Name of the venue.</param>
		/// <param name="address">Address of the venue.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="foursquareId">Foursquare identifier of the venue.</param>
		/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, ÔÇ£arts_entertainment/defaultÔÇØ, ÔÇ£arts_entertainment/aquariumÔÇØ or ÔÇ£food/icecreamÔÇØ.).</param>
		/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
		/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendVenue(this BotClient api, string chatId, float latitude, float longitude, string title, string address, [Optional] int? messageThreadId, [Optional] string? foursquareId, [Optional] string? foursquareType, [Optional] string? googlePlaceId, [Optional] string? googlePlaceType, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }			
			var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
			{
				MessageThreadId = messageThreadId,
				FoursquareId = foursquareId,
				FoursquareType = foursquareType,
				GooglePlaceId = googlePlaceId,
				GooglePlaceType = googlePlaceType,
				DisableNotification = disableNotification,
				ProtectContent = protectContent,
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<Message>(MethodNames.SendVenue, args);
		}

		/// <summary>
		/// Use this method to send information about a venue. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="latitude">Latitude of the venue.</param>
		/// <param name="longitude">Longitude of the venue.</param>
		/// <param name="title">Name of the venue.</param>
		/// <param name="address">Address of the venue.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="foursquareId">Foursquare identifier of the venue.</param>
		/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, ÔÇ£arts_entertainment/defaultÔÇØ, ÔÇ£arts_entertainment/aquariumÔÇØ or ÔÇ£food/icecreamÔÇØ.).</param>
		/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
		/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendVenueAsync(this BotClient api, long chatId, float latitude, float longitude, string title, string address, [Optional] int? messageThreadId, [Optional] string? foursquareId, [Optional] string? foursquareType, [Optional] string? googlePlaceId, [Optional] string? googlePlaceType, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }			
			var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
			{
				MessageThreadId = messageThreadId,
				FoursquareId = foursquareId,
				FoursquareType = foursquareType,
				GooglePlaceId = googlePlaceId,
				GooglePlaceType = googlePlaceType,
				DisableNotification = disableNotification,
				ProtectContent = protectContent,
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<Message>(MethodNames.SendVenue, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to send information about a venue. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="latitude">Latitude of the venue.</param>
		/// <param name="longitude">Longitude of the venue.</param>
		/// <param name="title">Name of the venue.</param>
		/// <param name="address">Address of the venue.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="foursquareId">Foursquare identifier of the venue.</param>
		/// <param name="foursquareType">Foursquare type of the venue, if known. (For example, ÔÇ£arts_entertainment/defaultÔÇØ, ÔÇ£arts_entertainment/aquariumÔÇØ or ÔÇ£food/icecreamÔÇØ.).</param>
		/// <param name="googlePlaceId">Google Places identifier of the venue.</param>
		/// <param name="googlePlaceType">Google Places type of the venue. (See supported types.).</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendVenueAsync(this BotClient api, string chatId, float latitude, float longitude, string title, string address, [Optional] int? messageThreadId, [Optional] string? foursquareId, [Optional] string? foursquareType, [Optional] string? googlePlaceId, [Optional] string? googlePlaceType, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }			
			var args = new SendVenueArgs(chatId, latitude, longitude, title, address)
			{
				MessageThreadId = messageThreadId,
				FoursquareId = foursquareId,
				FoursquareType = foursquareType,
				GooglePlaceId = googlePlaceId,
				GooglePlaceType = googlePlaceType,
				DisableNotification = disableNotification,
				ProtectContent = protectContent,
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<Message>(MethodNames.SendVenue, args, cancellationToken).ConfigureAwait(false);
		}
    }
}
