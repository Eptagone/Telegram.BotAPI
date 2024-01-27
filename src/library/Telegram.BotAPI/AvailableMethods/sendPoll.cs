// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send a native poll. A native poll can't be sent to a private chat. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendPoll(this ITelegramBotClient bot, SendPollArgs args)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.CallMethod<Message>(MethodNames.SendPoll, args);
	}

	/// <summary>Use this method to send a native poll. A native poll can't be sent to a private chat. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendPollAsync(this ITelegramBotClient bot, SendPollArgs args, CancellationToken cancellationToken = default)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<Message>(MethodNames.SendPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send a native poll. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="question">Poll question, 1-300 characters.</param>
	/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
	/// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”.</param>
	/// <param name="allowsMultipleAnswers">True, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to False.</param>
	/// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode.</param>
	/// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing.</param>
	/// <param name="explanationParseMode">Mode for parsing entities in the explanation. See formatting options for more details.</param>
	/// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of parse_mode.</param>
	/// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with close_date.</param>
	/// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with open_period.</param>
	/// <param name="isClosed">Pass True if the poll needs to be immediately closed. This can be useful for poll preview.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendPoll(this ITelegramBotClient client, long chatId, string question, IEnumerable<string> options, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, uint? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, ushort? openPeriod = null, uint? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPollArgs(chatId, question, options)
		{
			MessageThreadId = messageThreadId,
			IsAnonymous = isAnonymous,
			Type = type,
			AllowsMultipleAnswers = allowsMultipleAnswers,
			CorrectOptionId = correctOptionId,
			Explanation = explanation,
			ExplanationParseMode = explanationParseMode,
			ExplanationEntities = explanationEntities,
			OpenPeriod = openPeriod,
			CloseDate = closeDate,
			IsClosed = isClosed,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendPoll, args);
	}

	/// <summary>
	/// Use this method to send a native poll. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="question">Poll question, 1-300 characters.</param>
	/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
	/// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”.</param>
	/// <param name="allowsMultipleAnswers">True, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to False.</param>
	/// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode.</param>
	/// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing.</param>
	/// <param name="explanationParseMode">Mode for parsing entities in the explanation. See formatting options for more details.</param>
	/// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of parse_mode.</param>
	/// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with close_date.</param>
	/// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with open_period.</param>
	/// <param name="isClosed">Pass True if the poll needs to be immediately closed. This can be useful for poll preview.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendPoll(this ITelegramBotClient client, string chatId, string question, IEnumerable<string> options, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, uint? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, ushort? openPeriod = null, uint? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPollArgs(chatId, question, options)
		{
			MessageThreadId = messageThreadId,
			IsAnonymous = isAnonymous,
			Type = type,
			AllowsMultipleAnswers = allowsMultipleAnswers,
			CorrectOptionId = correctOptionId,
			Explanation = explanation,
			ExplanationParseMode = explanationParseMode,
			ExplanationEntities = explanationEntities,
			OpenPeriod = openPeriod,
			CloseDate = closeDate,
			IsClosed = isClosed,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendPoll, args);
	}

	/// <summary>
	/// Use this method to send a native poll. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="question">Poll question, 1-300 characters.</param>
	/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
	/// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”.</param>
	/// <param name="allowsMultipleAnswers">True, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to False.</param>
	/// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode.</param>
	/// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing.</param>
	/// <param name="explanationParseMode">Mode for parsing entities in the explanation. See formatting options for more details.</param>
	/// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of parse_mode.</param>
	/// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with close_date.</param>
	/// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with open_period.</param>
	/// <param name="isClosed">Pass True if the poll needs to be immediately closed. This can be useful for poll preview.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendPollAsync(this ITelegramBotClient client, long chatId, string question, IEnumerable<string> options, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, uint? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, ushort? openPeriod = null, uint? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPollArgs(chatId, question, options)
		{
			MessageThreadId = messageThreadId,
			IsAnonymous = isAnonymous,
			Type = type,
			AllowsMultipleAnswers = allowsMultipleAnswers,
			CorrectOptionId = correctOptionId,
			Explanation = explanation,
			ExplanationParseMode = explanationParseMode,
			ExplanationEntities = explanationEntities,
			OpenPeriod = openPeriod,
			CloseDate = closeDate,
			IsClosed = isClosed,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendPoll, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send a native poll. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="question">Poll question, 1-300 characters.</param>
	/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
	/// <param name="type">Poll type, “quiz” or “regular”, defaults to “regular”.</param>
	/// <param name="allowsMultipleAnswers">True, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to False.</param>
	/// <param name="correctOptionId">0-based identifier of the correct answer option, required for polls in quiz mode.</param>
	/// <param name="explanation">Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters with at most 2 line feeds after entities parsing.</param>
	/// <param name="explanationParseMode">Mode for parsing entities in the explanation. See formatting options for more details.</param>
	/// <param name="explanationEntities">A JSON-serialized list of special entities that appear in the poll explanation, which can be specified instead of parse_mode.</param>
	/// <param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together with close_date.</param>
	/// <param name="closeDate">Point in time (Unix timestamp) when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds in the future. Can't be used together with open_period.</param>
	/// <param name="isClosed">Pass True if the poll needs to be immediately closed. This can be useful for poll preview.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendPollAsync(this ITelegramBotClient client, string chatId, string question, IEnumerable<string> options, int? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, uint? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, IEnumerable<MessageEntity>? explanationEntities = null, ushort? openPeriod = null, uint? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPollArgs(chatId, question, options)
		{
			MessageThreadId = messageThreadId,
			IsAnonymous = isAnonymous,
			Type = type,
			AllowsMultipleAnswers = allowsMultipleAnswers,
			CorrectOptionId = correctOptionId,
			Explanation = explanation,
			ExplanationParseMode = explanationParseMode,
			ExplanationEntities = explanationEntities,
			OpenPeriod = openPeriod,
			CloseDate = closeDate,
			IsClosed = isClosed,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendPoll, args, cancellationToken).ConfigureAwait(false);
	}
}
