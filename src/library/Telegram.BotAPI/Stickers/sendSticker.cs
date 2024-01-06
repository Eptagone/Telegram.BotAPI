// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.Stickers;

public static partial class StickersExtensions
{
	/// <summary>Use this method to send static .WEBP or animated .TGS stickers. On success, the sent Message is returned..</summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendSticker(this ITelegramBotClient client, SendStickerArgs args)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return client.CallMethod<Message>(MethodNames.SendSticker, args);
	}

	/// <summary>Use this method to send static .WEBP or animated .TGS stickers. On success, the sent Message is returned..</summary>
	/// <param name="client">The bot client</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendStickerAsync(this ITelegramBotClient client, SendStickerArgs args, CancellationToken cancellationToken = default)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return client.CallMethodAsync<Message>(MethodNames.SendSticker, args, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendSticker(this ITelegramBotClient client, long chatId, InputFile sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendSticker, args);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendSticker(this ITelegramBotClient client, long chatId, string sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendSticker, args);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendSticker(this ITelegramBotClient client, string chatId, InputFile sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendSticker, args);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendSticker(this ITelegramBotClient client, string chatId, string sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendSticker, args);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendStickerAsync(this ITelegramBotClient client, long chatId, InputFile sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.SendSticker, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendStickerAsync(this ITelegramBotClient client, long chatId, string sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.SendSticker, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendStickerAsync(this ITelegramBotClient client, string chatId, InputFile sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.SendSticker, args, cancellationToken);
	}

	/// <summary>
	/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="emoji">Emoji associated with the sticker; only for just uploaded stickers.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Task<Message> SendStickerAsync(this ITelegramBotClient client, string chatId, string sticker, int? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendStickerArgs(chatId, sticker)
		{
			MessageThreadId = messageThreadId,
			Emoji = emoji,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethodAsync<Message>(MethodNames.SendSticker, args, cancellationToken);
	}
}
