// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>Use this method to send video files, Telegram clients support mp4 videos (other formats may be sent as Document).</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <returns>On success, the sent Message is returned.</returns>
		public static Message SendVideo(this BotClient? bot, SendVideoArgs args)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return bot.RPCF<Message>(MethodNames.SendVideo, args);
		}

		/// <summary>Use this method to send video files, Telegram clients support mp4 videos (other formats may be sent as Document).</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <returns>On success, the sent Message is returned.</returns>
		public static async Task<Message> SendVideoAsync(this BotClient? bot, SendVideoArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return await bot.RPCAF<Message>(MethodNames.SendVideo, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendVideo(this BotClient? api, long chatId, InputFile video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return api.RPCF<Message>(MethodNames.SendVideo, args);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="attachedFiles">Attached files.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendVideo(this BotClient? api, long chatId, string video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] IEnumerable<AttachedFile>? attachedFiles)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup,
				AttachedFiles = attachedFiles == null ? new List<AttachedFile>() : new List<AttachedFile>(attachedFiles)
			};
			return api.RPCF<Message>(MethodNames.SendVideo, args);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendVideo(this BotClient? api, string chatId, InputFile video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return api.RPCF<Message>(MethodNames.SendVideo, args);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="attachedFiles">Attached files.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendVideo(this BotClient? api, string chatId, string video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] IEnumerable<AttachedFile>? attachedFiles)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup,
				AttachedFiles = attachedFiles == null ? new List<AttachedFile>() : new List<AttachedFile>(attachedFiles)
			};
			return api.RPCF<Message>(MethodNames.SendVideo, args);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendVideoAsync(this BotClient? api, long chatId, InputFile video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCAF<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="attachedFiles">Attached files.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendVideoAsync(this BotClient? api, long chatId, string video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] IEnumerable<AttachedFile>? attachedFiles, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup,
				AttachedFiles = attachedFiles == null ? new List<AttachedFile>() : new List<AttachedFile>(attachedFiles)
			};
			return await api.RPCAF<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendVideoAsync(this BotClient? api, string chatId, InputFile video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCAF<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as Document). On success, the sent Message is returned. Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data. More information on Sending Files ».</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="duration">Duration of sent video in seconds.</param>
		/// <param name="width">Video width.</param>
		/// <param name="height">Video height.</param>
		/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files ».</param>
		/// <param name="caption">Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the video caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="hasSpoiler">Pass True if the video needs to be covered with a spoiler animation.</param>
		/// <param name="supportsStreaming">Pass True if the uploaded video is suitable for streaming.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <param name="attachedFiles">Attached files.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> SendVideoAsync(this BotClient? api, string chatId, string video, [Optional] int? messageThreadId, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string? thumbnail, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? hasSpoiler, [Optional] bool? supportsStreaming, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] IEnumerable<AttachedFile>? attachedFiles, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
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
				ReplyToMessageId = replyToMessageId,
				AllowSendingWithoutReply = allowSendingWithoutReply,
				ReplyMarkup = replyMarkup,
				AttachedFiles = attachedFiles == null ? new List<AttachedFile>() : new List<AttachedFile>(attachedFiles)
			};
			return await api.RPCAF<Message>(MethodNames.SendVideo, args, cancellationToken).ConfigureAwait(false);
		}
	}
}
