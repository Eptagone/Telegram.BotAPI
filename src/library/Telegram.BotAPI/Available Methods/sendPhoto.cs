// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendPhoto(this ITelegramBotClient client, SendPhotoArgs args)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		if (args is null)
			throw new ArgumentNullException(nameof(args));

		return client.CallMethod<Message>(MethodNames.SendPhoto, args);
	}

	/// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Task<Message> SendPhotoAsync(this ITelegramBotClient client, SendPhotoArgs args, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		if (args is null)
			throw new ArgumentNullException(nameof(args));

		return client.CallMethodAsync<Message>(MethodNames.SendPhoto, args, cancellationToken);
	}


	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendPhoto(this ITelegramBotClient client, long chatId, InputFile photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendPhoto, args);
	}

	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendPhoto(this ITelegramBotClient client, long chatId, string photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendPhoto, args);
	}

	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendPhoto(this ITelegramBotClient client, string chatId, InputFile photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendPhoto, args);
	}

	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendPhoto(this ITelegramBotClient client, string chatId, string photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendPhoto, args);
	}

	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendPhotoAsync(this ITelegramBotClient client, long chatId, InputFile photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendPhotoAsync(this ITelegramBotClient client, long chatId, string photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendPhotoAsync(this ITelegramBotClient client, string chatId, InputFile photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send photos. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
	/// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
	/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
	/// <param name="hasSpoiler">Pass True if the photo needs to be covered with a spoiler animation.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendPhotoAsync(this ITelegramBotClient client, string chatId, string photo, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendPhotoArgs(chatId, photo)
		{
			MessageThreadId = messageThreadId,
			Caption = caption,
			ParseMode = parseMode,
			CaptionEntities = captionEntities,
			HasSpoiler = hasSpoiler,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
	}
}
