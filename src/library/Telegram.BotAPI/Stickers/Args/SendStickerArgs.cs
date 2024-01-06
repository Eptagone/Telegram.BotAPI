// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>SendSticker method arguments</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendStickerArgs : AttachedFilesArgsBase
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(long chatId, InputFile sticker)
	{
		this.ChatId = chatId;
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(long chatId, string sticker)
	{
		this.ChatId = chatId;
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(string chatId, InputFile sticker)
	{
		this.ChatId = chatId;
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(string chatId, string sticker)
	{
		this.ChatId = chatId;
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP sticker from the Internet, or upload a new .WEBP or .TGS sticker using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Video stickers can only be sent by a file_id. Animated stickers can't be sent via an HTTP URL.
	/// </summary>
	[JsonPropertyName(PropertyNames.Sticker)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object Sticker { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// Emoji associated with the sticker; only for just uploaded stickers
	/// </summary>
	[JsonPropertyName(PropertyNames.Emoji)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Emoji { get; set; }
	/// <summary>
	/// Sends the message silently. Users will receive a notification with no sound.
	/// </summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>
	/// Protects the contents of the sent message from forwarding and saving
	/// </summary>
	[JsonPropertyName(PropertyNames.ProtectContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ProtectContent { get; set; }
	/// <summary>
	/// Description of the message to reply to
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyParameters)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyParameters? ReplyParameters { get; set; }
	/// <summary>
	/// Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyMarkup? ReplyMarkup { get; set; }
}
