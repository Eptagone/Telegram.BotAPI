// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageLiveLocation" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static TResult EditMessageLiveLocation<TResult>(this ITelegramBotClient client, EditMessageLiveLocationArgs args) =>
        client.EditMessageLiveLocationAsync<TResult>(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageLiveLocation" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<TResult> EditMessageLiveLocationAsync<TResult>(this ITelegramBotClient client, EditMessageLiveLocationArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<TResult>(MethodNames.EditMessageLiveLocation, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="latitude">Latitude of new location</param>
    /// <param name="longitude">Longitude of new location</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="livePeriod">New period in seconds during which the location can be updated, starting from the message send date. If 0x7FFFFFFF is specified, then the location can be updated forever. Otherwise, the new value must not exceed the current <em>live_period</em> by more than a day, and the live location expiration date must remain within the next 90 days. If not specified, then <em>live_period</em> remains unchanged</param>
    /// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500</param>
    /// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
    /// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message EditMessageLiveLocation(this ITelegramBotClient client, long chatId, int messageId, float latitude, float longitude, string? businessConnectionId = null, int? livePeriod = null, float? horizontalAccuracy = null, int? heading = null, int? proximityAlertRadius = null, ReplyMarkup? replyMarkup = null) =>
        client.EditMessageLiveLocationAsync(chatId, messageId, latitude, longitude, businessConnectionId, livePeriod, horizontalAccuracy, heading, proximityAlertRadius, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="latitude">Latitude of new location</param>
    /// <param name="longitude">Longitude of new location</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="livePeriod">New period in seconds during which the location can be updated, starting from the message send date. If 0x7FFFFFFF is specified, then the location can be updated forever. Otherwise, the new value must not exceed the current <em>live_period</em> by more than a day, and the live location expiration date must remain within the next 90 days. If not specified, then <em>live_period</em> remains unchanged</param>
    /// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500</param>
    /// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
    /// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> EditMessageLiveLocationAsync(this ITelegramBotClient client, long chatId, int messageId, float latitude, float longitude, string? businessConnectionId = null, int? livePeriod = null, float? horizontalAccuracy = null, int? heading = null, int? proximityAlertRadius = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId },
            { PropertyNames.Latitude, latitude },
            { PropertyNames.Longitude, longitude }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (livePeriod is not null)
        {
            args.Add(PropertyNames.LivePeriod, livePeriod);
        }
        if (horizontalAccuracy is not null)
        {
            args.Add(PropertyNames.HorizontalAccuracy, horizontalAccuracy);
        }
        if (heading is not null)
        {
            args.Add(PropertyNames.Heading, heading);
        }
        if (proximityAlertRadius is not null)
        {
            args.Add(PropertyNames.ProximityAlertRadius, proximityAlertRadius);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.EditMessageLiveLocation, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="latitude">Latitude of new location</param>
    /// <param name="longitude">Longitude of new location</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="livePeriod">New period in seconds during which the location can be updated, starting from the message send date. If 0x7FFFFFFF is specified, then the location can be updated forever. Otherwise, the new value must not exceed the current <em>live_period</em> by more than a day, and the live location expiration date must remain within the next 90 days. If not specified, then <em>live_period</em> remains unchanged</param>
    /// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500</param>
    /// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
    /// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message EditMessageLiveLocation(this ITelegramBotClient client, string chatId, int messageId, float latitude, float longitude, string? businessConnectionId = null, int? livePeriod = null, float? horizontalAccuracy = null, int? heading = null, int? proximityAlertRadius = null, ReplyMarkup? replyMarkup = null) =>
        client.EditMessageLiveLocationAsync(chatId, messageId, latitude, longitude, businessConnectionId, livePeriod, horizontalAccuracy, heading, proximityAlertRadius, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="latitude">Latitude of new location</param>
    /// <param name="longitude">Longitude of new location</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="livePeriod">New period in seconds during which the location can be updated, starting from the message send date. If 0x7FFFFFFF is specified, then the location can be updated forever. Otherwise, the new value must not exceed the current <em>live_period</em> by more than a day, and the live location expiration date must remain within the next 90 days. If not specified, then <em>live_period</em> remains unchanged</param>
    /// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500</param>
    /// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
    /// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> EditMessageLiveLocationAsync(this ITelegramBotClient client, string chatId, int messageId, float latitude, float longitude, string? businessConnectionId = null, int? livePeriod = null, float? horizontalAccuracy = null, int? heading = null, int? proximityAlertRadius = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.MessageId, messageId },
            { PropertyNames.Latitude, latitude },
            { PropertyNames.Longitude, longitude }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (livePeriod is not null)
        {
            args.Add(PropertyNames.LivePeriod, livePeriod);
        }
        if (horizontalAccuracy is not null)
        {
            args.Add(PropertyNames.HorizontalAccuracy, horizontalAccuracy);
        }
        if (heading is not null)
        {
            args.Add(PropertyNames.Heading, heading);
        }
        if (proximityAlertRadius is not null)
        {
            args.Add(PropertyNames.ProximityAlertRadius, proximityAlertRadius);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.EditMessageLiveLocation, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="latitude">Latitude of new location</param>
    /// <param name="longitude">Longitude of new location</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="livePeriod">New period in seconds during which the location can be updated, starting from the message send date. If 0x7FFFFFFF is specified, then the location can be updated forever. Otherwise, the new value must not exceed the current <em>live_period</em> by more than a day, and the live location expiration date must remain within the next 90 days. If not specified, then <em>live_period</em> remains unchanged</param>
    /// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500</param>
    /// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
    /// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditMessageLiveLocation(this ITelegramBotClient client, string inlineMessageId, float latitude, float longitude, string? businessConnectionId = null, int? livePeriod = null, float? horizontalAccuracy = null, int? heading = null, int? proximityAlertRadius = null, ReplyMarkup? replyMarkup = null) =>
        client.EditMessageLiveLocationAsync(inlineMessageId, latitude, longitude, businessConnectionId, livePeriod, horizontalAccuracy, heading, proximityAlertRadius, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its <em>live_period</em> expires or editing is explicitly disabled by a call to <a href="https://core.telegram.org/bots/api#stopmessagelivelocation">stopMessageLiveLocation</a>. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="latitude">Latitude of new location</param>
    /// <param name="longitude">Longitude of new location</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="livePeriod">New period in seconds during which the location can be updated, starting from the message send date. If 0x7FFFFFFF is specified, then the location can be updated forever. Otherwise, the new value must not exceed the current <em>live_period</em> by more than a day, and the live location expiration date must remain within the next 90 days. If not specified, then <em>live_period</em> remains unchanged</param>
    /// <param name="horizontalAccuracy">The radius of uncertainty for the location, measured in meters; 0-1500</param>
    /// <param name="heading">Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</param>
    /// <param name="proximityAlertRadius">The maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditMessageLiveLocationAsync(this ITelegramBotClient client, string inlineMessageId, float latitude, float longitude, string? businessConnectionId = null, int? livePeriod = null, float? horizontalAccuracy = null, int? heading = null, int? proximityAlertRadius = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.InlineMessageId, inlineMessageId ?? throw new ArgumentNullException(nameof(inlineMessageId)) },
            { PropertyNames.Latitude, latitude },
            { PropertyNames.Longitude, longitude }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (livePeriod is not null)
        {
            args.Add(PropertyNames.LivePeriod, livePeriod);
        }
        if (horizontalAccuracy is not null)
        {
            args.Add(PropertyNames.HorizontalAccuracy, horizontalAccuracy);
        }
        if (heading is not null)
        {
            args.Add(PropertyNames.Heading, heading);
        }
        if (proximityAlertRadius is not null)
        {
            args.Add(PropertyNames.ProximityAlertRadius, proximityAlertRadius);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<bool>(MethodNames.EditMessageLiveLocation, args, cancellationToken);
    }
}
