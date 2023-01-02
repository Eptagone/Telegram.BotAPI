// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>Use this method to send a native poll. A native poll can't be sent to a private chat. On success, the sent Message is returned.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendPoll(this BotClient? bot, SendPollArgs args)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return bot.RPC<Message>(MethodNames.SendPoll, args);
		}

		/// <summary>Use this method to send a native poll. A native poll can't be sent to a private chat. On success, the sent Message is returned.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendPollAsync(this BotClient? bot, SendPollArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return await bot.RPCA<Message>(MethodNames.SendPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to send a native poll. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="question">Poll question, 1-300 characters.</param>
		/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
		/// <param name="type">Poll type, ÔÇ£quizÔÇØ or ÔÇ£regularÔÇØ, defaults to ÔÇ£regularÔÇØ.</param>
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
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendPoll(this BotClient? api, long chatId, string question, IEnumerable<string> options, [Optional] int? messageThreadId, [Optional] bool? isAnonymous, [Optional] string? type, [Optional] bool? allowsMultipleAnswers, [Optional] uint? correctOptionId, [Optional] string? explanation, [Optional] string? explanationParseMode, [Optional] IEnumerable<MessageEntity>? explanationEntities, [Optional] ushort? openPeriod, [Optional] uint? closeDate, [Optional] bool? isClosed, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<Message>(MethodNames.SendPoll, args);
		}

		/// <summary>
		/// Use this method to send a native poll. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="question">Poll question, 1-300 characters.</param>
		/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
		/// <param name="type">Poll type, ÔÇ£quizÔÇØ or ÔÇ£regularÔÇØ, defaults to ÔÇ£regularÔÇØ.</param>
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
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendPoll(this BotClient? api, string chatId, string question, IEnumerable<string> options, [Optional] int? messageThreadId, [Optional] bool? isAnonymous, [Optional] string? type, [Optional] bool? allowsMultipleAnswers, [Optional] uint? correctOptionId, [Optional] string? explanation, [Optional] string? explanationParseMode, [Optional] IEnumerable<MessageEntity>? explanationEntities, [Optional] ushort? openPeriod, [Optional] uint? closeDate, [Optional] bool? isClosed, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<Message>(MethodNames.SendPoll, args);
		}

		/// <summary>
		/// Use this method to send a native poll. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="question">Poll question, 1-300 characters.</param>
		/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
		/// <param name="type">Poll type, ÔÇ£quizÔÇØ or ÔÇ£regularÔÇØ, defaults to ÔÇ£regularÔÇØ.</param>
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
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendPollAsync(this BotClient? api, long chatId, string question, IEnumerable<string> options, [Optional] int? messageThreadId, [Optional] bool? isAnonymous, [Optional] string? type, [Optional] bool? allowsMultipleAnswers, [Optional] uint? correctOptionId, [Optional] string? explanation, [Optional] string? explanationParseMode, [Optional] IEnumerable<MessageEntity>? explanationEntities, [Optional] ushort? openPeriod, [Optional] uint? closeDate, [Optional] bool? isClosed, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<Message>(MethodNames.SendPoll, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to send a native poll. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="question">Poll question, 1-300 characters.</param>
		/// <param name="options">A JSON-serialized list of answer options, 2-10 strings 1-100 characters each.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="isAnonymous">True, if the poll needs to be anonymous, defaults to True.</param>
		/// <param name="type">Poll type, ÔÇ£quizÔÇØ or ÔÇ£regularÔÇØ, defaults to ÔÇ£regularÔÇØ.</param>
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
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendPollAsync(this BotClient? api, string chatId, string question, IEnumerable<string> options, [Optional] int? messageThreadId, [Optional] bool? isAnonymous, [Optional] string? type, [Optional] bool? allowsMultipleAnswers, [Optional] uint? correctOptionId, [Optional] string? explanation, [Optional] string? explanationParseMode, [Optional] IEnumerable<MessageEntity>? explanationEntities, [Optional] ushort? openPeriod, [Optional] uint? closeDate, [Optional] bool? isClosed, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<Message>(MethodNames.SendPoll, args, cancellationToken).ConfigureAwait(false);
		}
	}
}
