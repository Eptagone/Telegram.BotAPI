// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>As of v.4.0, Telegram clients support rounded square mp4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendVideoNote(this ITelegramBotClient bot, SendVideoNoteArgs args)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.CallMethod<Message>(MethodNames.SendVideoNote, args);
	}

	/// <summary>As of v.4.0, Telegram clients support rounded square mp4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Task<Message> SendVideoNoteAsync(this ITelegramBotClient bot, SendVideoNoteArgs args, CancellationToken cancellationToken = default)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.CallMethodAsync<Message>(MethodNames.SendVideoNote, args, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideoNote(this ITelegramBotClient client, long chatId, InputFile videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendVideoNote, args);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideoNote(this ITelegramBotClient client, long chatId, string videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethod<Message>(MethodNames.SendVideoNote, args);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideoNote(this ITelegramBotClient client, string chatId, InputFile videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendVideoNote, args);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideoNote(this ITelegramBotClient client, string chatId, string videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethod<Message>(MethodNames.SendVideoNote, args);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendVideoNoteAsync(this ITelegramBotClient client, long chatId, InputFile videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.SendVideoNote, args, cancellationToken);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendVideoNoteAsync(this ITelegramBotClient client, long chatId, string videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethodAsync<Message>(MethodNames.SendVideoNote, args, cancellationToken);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendVideoNoteAsync(this ITelegramBotClient client, string chatId, InputFile videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.SendVideoNote, args, cancellationToken);
	}

	/// <summary>
	/// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="length">Video width and height, i.e. diameter of the video message.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendVideoNoteAsync(this ITelegramBotClient client, string chatId, string videoNote, int? messageThreadId = null, uint? duration = null, uint? length = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoNoteArgs(chatId, videoNote)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Length = length,
			Thumbnail = thumbnail,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethodAsync<Message>(MethodNames.SendVideoNote, args, cancellationToken);
	}
}
