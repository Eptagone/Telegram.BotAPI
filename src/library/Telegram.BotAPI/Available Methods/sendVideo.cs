// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>On success, the sent Message is returned.</returns>
	public static Message SendVideo(this ITelegramBotClient client, SendVideoArgs args)
	{
		return client is null
			? throw new ArgumentNullException(nameof(client))
			: client.CallMethod<Message>(MethodNames.SendVideo, args);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>On success, the sent Message is returned.</returns>
	public static Task<Message> SendVideoAsync(this ITelegramBotClient client, SendVideoArgs args, CancellationToken cancellationToken = default)
	{
		return client is null
			? throw new ArgumentNullException(nameof(client))
			: client.CallMethodAsync<Message>(MethodNames.SendVideo, args, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideo(this ITelegramBotClient client, long chatId, InputFile video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendVideo, args);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="files">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideo(this ITelegramBotClient client, long chatId, string video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			Files = files ?? new Dictionary<string, InputFile>()
		};
		return client.CallMethod<Message>(MethodNames.SendVideo, args);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideo(this ITelegramBotClient client, string chatId, InputFile video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendVideo, args);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="files">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendVideo(this ITelegramBotClient client, string chatId, string video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			Files = files ?? new Dictionary<string, InputFile>()
		};
		return client.CallMethod<Message>(MethodNames.SendVideo, args);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendVideoAsync(this ITelegramBotClient client, long chatId, InputFile video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="files">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendVideoAsync(this ITelegramBotClient client, long chatId, string video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			Files = files ?? new Dictionary<string, InputFile>()
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendVideoAsync(this ITelegramBotClient client, string chatId, InputFile video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="duration">Duration of sent video in seconds.</param>
	/// <param name="width">Video width.</param>
	/// <param name="height">Video height.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
	/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="files">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendVideoAsync(this ITelegramBotClient client, string chatId, string video, int? messageThreadId = null, uint? duration = null, uint? width = null, uint? height = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? supportsStreaming = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendVideoArgs(chatId, video)
		{
			MessageThreadId = messageThreadId,
			Duration = duration,
			Width = width,
			Height = height,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			SupportsStreaming = supportsStreaming,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			Files = files ?? new Dictionary<string, InputFile>()
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
	}
}
