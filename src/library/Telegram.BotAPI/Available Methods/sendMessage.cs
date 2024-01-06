// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendMessage(this ITelegramBotClient client, SendMessageArgs args)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		if (args is null)
			throw new ArgumentNullException(nameof(args));
		return client.CallMethod<Message>(MethodNames.SendMessage, args);
	}


	/// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Task<Message> SendMessageAsync(this ITelegramBotClient client, SendMessageArgs args, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		if (args is null)
			throw new ArgumentNullException(nameof(args));
		return client.CallMethodAsync<Message>(MethodNames.SendMessage, args, cancellationToken: cancellationToken);
	}


	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendMessage(this ITelegramBotClient client, long chatId, string text, int? messageThreadId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendMessage, args);
	}

	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendMessage(this ITelegramBotClient client, string chatId, string text, int? messageThreadId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendMessage, args);
	}

	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendMessageAsync(this ITelegramBotClient client, long chatId, string text, int? messageThreadId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendMessage, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send text messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="parseMode">Mode for parsing entities in the message text. See formatting options for more details.</param>
	/// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode.</param>
	/// <param name="linkPreviewOptions">Link preview generation options for the message.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendMessageAsync(this ITelegramBotClient client, string chatId, string text, int? messageThreadId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMessageArgs(chatId, text)
		{
			MessageThreadId = messageThreadId,
			ParseMode = parseMode,
			Entities = entities,
			LinkPreviewOptions = linkPreviewOptions,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendMessage, args, cancellationToken).ConfigureAwait(false);
	}
}
