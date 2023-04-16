// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;



namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendMessage(this BotClient? bot, SendMessageArgs args)
	{
		if (bot == null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.RPC<Message>(MethodNames.SendMessage, args);
	}
	/// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static async Task<Message> SendMessageAsync(this BotClient? bot, SendMessageArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.RPCA<Message>(MethodNames.SendMessage, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendMessage(this BotClient? api, long chatId, string text, [Optional] int? messageThreadId, [Optional] string parseMode, [Optional] IEnumerable<MessageEntity>? entities, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return api.RPC<Message>(MethodNames.SendMessage, args);
	}

	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendMessage(this BotClient? api, string chatId, string text, [Optional] int? messageThreadId, [Optional] string parseMode, [Optional] IEnumerable<MessageEntity>? entities, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return api.RPC<Message>(MethodNames.SendMessage, args);
	}

	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendMessageAsync(this BotClient? api, long chatId, string text, [Optional] int? messageThreadId, [Optional] string parseMode, [Optional] IEnumerable<MessageEntity>? entities, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return await api.RPCA<Message>(MethodNames.SendMessage, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="disableWebPagePreview">Disables link previews for links in this message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendMessageAsync(this BotClient? api, string chatId, string text, [Optional] int? messageThreadId, [Optional] string parseMode, [Optional] IEnumerable<MessageEntity>? entities, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			DisableWebPagePreview = disableWebPagePreview,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return await api.RPCA<Message>(MethodNames.SendMessage, args, cancellationToken).ConfigureAwait(false);
	}
}
