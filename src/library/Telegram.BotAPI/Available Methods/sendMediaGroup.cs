// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only group in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message enumerable.</returns>
	public static IEnumerable<Message> SendMediaGroup(this ITelegramBotClient bot, SendMediaGroupArgs args)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.CallMethod<IEnumerable<Message>>(MethodNames.SendMediaGroup, args);
	}
	/// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only group in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message enumerable.</returns>
	public static async Task<IEnumerable<Message>> SendMediaGroupAsync(this ITelegramBotClient bot, SendMediaGroupArgs args, CancellationToken cancellationToken = default)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static IEnumerable<Message> SendMediaGroup(this ITelegramBotClient client, long chatId, IEnumerable<InputMedia> media, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, IEnumerable<AttachedFile>? attachedFiles = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMediaGroupArgs(chatId, media)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethod<IEnumerable<Message>>(MethodNames.SendMediaGroup, args);
	}
	/// <summary>
	/// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static IEnumerable<Message> SendMediaGroup(this ITelegramBotClient client, string chatId, IEnumerable<InputMedia> media, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, IEnumerable<AttachedFile>? attachedFiles = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMediaGroupArgs(chatId, media)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethod<IEnumerable<Message>>(MethodNames.SendMediaGroup, args);
	}

	/// <summary>
	/// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<IEnumerable<Message>> SendMediaGroupAsync(this ITelegramBotClient client, long chatId, IEnumerable<InputMedia> media, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, IEnumerable<AttachedFile>? attachedFiles = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMediaGroupArgs(chatId, media)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			AttachedFiles = attachedFiles ?? []
		};
		return await client.CallMethodAsync<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<IEnumerable<Message>> SendMediaGroupAsync(this ITelegramBotClient client, string chatId, IEnumerable<InputMedia> media, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, IEnumerable<AttachedFile>? attachedFiles = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendMediaGroupArgs(chatId, media)
		{
			MessageThreadId = messageThreadId,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			AttachedFiles = attachedFiles ?? []
		};
		return await client.CallMethodAsync<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken).ConfigureAwait(false);
	}
}
