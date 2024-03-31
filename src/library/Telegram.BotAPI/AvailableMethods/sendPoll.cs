// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to send a native poll. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendPoll" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendPoll(this ITelegramBotClient client, SendPollArgs args) =>
        client.SendPollAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a native poll. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendPoll" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendPollAsync(this ITelegramBotClient client, SendPollArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Message>(MethodNames.SendPoll, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send a native poll. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="question">Poll question, 1-300 characters</param>
    /// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="isAnonymous"><em>True</em>, if the poll needs to be anonymous, defaults to <em>True</em></param>
    /// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”</param>
    /// <param name="allowsMultipleAnswers"><em>True</em>, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to <em>False</em></param>
    /// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode</param>
    /// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing</param>
    /// <param name="explanationParseMode">Mode for parsing entities in the explanation. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with <em>close_date</em>.</param>
    /// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with <em>open_period</em>.</param>
    /// <param name="isClosed">Pass <em>True</em> if the poll needs to be immediately closed. This can be useful for poll preview.</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user. Not supported for messages sent on behalf of a business account</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendPoll(this ITelegramBotClient client, long chatId, string question, IEnumerable<string> options, string? businessConnectionId = null, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, int? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, int? openPeriod = null, int? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null) =>
        client.SendPollAsync(chatId, question, options, businessConnectionId, messageThreadId, isAnonymous, type, allowsMultipleAnswers, correctOptionId, explanation, explanationParseMode, explanationEntities, openPeriod, closeDate, isClosed, disableNotification, protectContent, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a native poll. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="question">Poll question, 1-300 characters</param>
    /// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="isAnonymous"><em>True</em>, if the poll needs to be anonymous, defaults to <em>True</em></param>
    /// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”</param>
    /// <param name="allowsMultipleAnswers"><em>True</em>, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to <em>False</em></param>
    /// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode</param>
    /// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing</param>
    /// <param name="explanationParseMode">Mode for parsing entities in the explanation. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with <em>close_date</em>.</param>
    /// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with <em>open_period</em>.</param>
    /// <param name="isClosed">Pass <em>True</em> if the poll needs to be immediately closed. This can be useful for poll preview.</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user. Not supported for messages sent on behalf of a business account</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendPollAsync(this ITelegramBotClient client, long chatId, string question, IEnumerable<string> options, string? businessConnectionId = null, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, int? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, int? openPeriod = null, int? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Question, question ?? throw new ArgumentNullException(nameof(question)) },
            { PropertyNames.Options, options ?? throw new ArgumentNullException(nameof(options)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (isAnonymous is not null)
        {
            args.Add(PropertyNames.IsAnonymous, isAnonymous);
        }
        if (type is not null)
        {
            args.Add(PropertyNames.Type, type);
        }
        if (allowsMultipleAnswers is not null)
        {
            args.Add(PropertyNames.AllowsMultipleAnswers, allowsMultipleAnswers);
        }
        if (correctOptionId is not null)
        {
            args.Add(PropertyNames.CorrectOptionId, correctOptionId);
        }
        if (explanation is not null)
        {
            args.Add(PropertyNames.Explanation, explanation);
        }
        if (explanationParseMode is not null)
        {
            args.Add(PropertyNames.ExplanationParseMode, explanationParseMode);
        }
        if (explanationEntities is not null)
        {
            args.Add(PropertyNames.ExplanationEntities, explanationEntities);
        }
        if (openPeriod is not null)
        {
            args.Add(PropertyNames.OpenPeriod, openPeriod);
        }
        if (closeDate is not null)
        {
            args.Add(PropertyNames.CloseDate, closeDate);
        }
        if (isClosed is not null)
        {
            args.Add(PropertyNames.IsClosed, isClosed);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }
        if (replyParameters is not null)
        {
            args.Add(PropertyNames.ReplyParameters, replyParameters);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.SendPoll, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send a native poll. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="question">Poll question, 1-300 characters</param>
    /// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="isAnonymous"><em>True</em>, if the poll needs to be anonymous, defaults to <em>True</em></param>
    /// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”</param>
    /// <param name="allowsMultipleAnswers"><em>True</em>, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to <em>False</em></param>
    /// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode</param>
    /// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing</param>
    /// <param name="explanationParseMode">Mode for parsing entities in the explanation. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with <em>close_date</em>.</param>
    /// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with <em>open_period</em>.</param>
    /// <param name="isClosed">Pass <em>True</em> if the poll needs to be immediately closed. This can be useful for poll preview.</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user. Not supported for messages sent on behalf of a business account</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendPoll(this ITelegramBotClient client, string chatId, string question, IEnumerable<string> options, string? businessConnectionId = null, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, int? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, int? openPeriod = null, int? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null) =>
        client.SendPollAsync(chatId, question, options, businessConnectionId, messageThreadId, isAnonymous, type, allowsMultipleAnswers, correctOptionId, explanation, explanationParseMode, explanationEntities, openPeriod, closeDate, isClosed, disableNotification, protectContent, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a native poll. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="question">Poll question, 1-300 characters</param>
    /// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="isAnonymous"><em>True</em>, if the poll needs to be anonymous, defaults to <em>True</em></param>
    /// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”</param>
    /// <param name="allowsMultipleAnswers"><em>True</em>, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to <em>False</em></param>
    /// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode</param>
    /// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing</param>
    /// <param name="explanationParseMode">Mode for parsing entities in the explanation. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with <em>close_date</em>.</param>
    /// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with <em>open_period</em>.</param>
    /// <param name="isClosed">Pass <em>True</em> if the poll needs to be immediately closed. This can be useful for poll preview.</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user. Not supported for messages sent on behalf of a business account</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendPollAsync(this ITelegramBotClient client, string chatId, string question, IEnumerable<string> options, string? businessConnectionId = null, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, int? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, int? openPeriod = null, int? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Question, question ?? throw new ArgumentNullException(nameof(question)) },
            { PropertyNames.Options, options ?? throw new ArgumentNullException(nameof(options)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (isAnonymous is not null)
        {
            args.Add(PropertyNames.IsAnonymous, isAnonymous);
        }
        if (type is not null)
        {
            args.Add(PropertyNames.Type, type);
        }
        if (allowsMultipleAnswers is not null)
        {
            args.Add(PropertyNames.AllowsMultipleAnswers, allowsMultipleAnswers);
        }
        if (correctOptionId is not null)
        {
            args.Add(PropertyNames.CorrectOptionId, correctOptionId);
        }
        if (explanation is not null)
        {
            args.Add(PropertyNames.Explanation, explanation);
        }
        if (explanationParseMode is not null)
        {
            args.Add(PropertyNames.ExplanationParseMode, explanationParseMode);
        }
        if (explanationEntities is not null)
        {
            args.Add(PropertyNames.ExplanationEntities, explanationEntities);
        }
        if (openPeriod is not null)
        {
            args.Add(PropertyNames.OpenPeriod, openPeriod);
        }
        if (closeDate is not null)
        {
            args.Add(PropertyNames.CloseDate, closeDate);
        }
        if (isClosed is not null)
        {
            args.Add(PropertyNames.IsClosed, isClosed);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }
        if (replyParameters is not null)
        {
            args.Add(PropertyNames.ReplyParameters, replyParameters);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.SendPoll, args, cancellationToken);
    }
}
