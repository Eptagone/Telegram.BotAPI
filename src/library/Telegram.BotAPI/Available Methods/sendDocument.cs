// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendDocument(this ITelegramBotClient client, SendDocumentArgs args)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		if (args is null)
			throw new ArgumentNullException(nameof(args));

		return client.CallMethod<Message>(MethodNames.SendDocument, args);
	}

	/// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <returns>Message Object.</returns>
	public static Task<Message> SendDocumentAsync(this ITelegramBotClient client, SendDocumentArgs args, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		if (args is null)
			throw new ArgumentNullException(nameof(args));

		return client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendDocument(this ITelegramBotClient client, long chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendDocument, args);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendDocument(this ITelegramBotClient client, long chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethod<Message>(MethodNames.SendDocument, args);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendDocument(this ITelegramBotClient client, string chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendDocument, args);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendDocument(this ITelegramBotClient client, string chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return client.CallMethod<Message>(MethodNames.SendDocument, args);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendDocumentAsync(this ITelegramBotClient client, long chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendDocumentAsync(this ITelegramBotClient client, long chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendDocumentAsync(this ITelegramBotClient client, string chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the document caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="attachedFiles">Attached files.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendDocumentAsync(this ITelegramBotClient client, string chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IEnumerable<AttachedFile>? attachedFiles = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendDocumentArgs(chatId, document)
		{
			MessageThreadId = messageThreadId,
			Thumbnail = thumbnail,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			DisableContentTypeDetection = disableContentTypeDetection,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup,
			AttachedFiles = attachedFiles ?? []
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken).ConfigureAwait(false);
	}
}
