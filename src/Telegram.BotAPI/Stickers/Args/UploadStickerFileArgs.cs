// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>UploadStickerFile method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class UploadStickerFileArgs
{
	/// <summary>
	/// Initialize a new instance of the <see cref="UploadStickerFileArgs"/> class.
	/// </summary>
	/// <param name="userId">User identifier of sticker file owner.</param>
	/// <param name="sticker"> A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See https://core.telegram.org/stickers for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
	/// <param name="stickerFormat">Format of the sticker, must be one of “static”, “animated”, “video”</param>
	/// <exception cref="ArgumentNullException"></exception>
	public UploadStickerFileArgs(long userId, InputFile sticker, string stickerFormat)
	{
		this.UserId = userId;
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
		this.StickerFormat = stickerFormat ?? throw new ArgumentNullException(nameof(stickerFormat));
	}

	/// <summary>User identifier of sticker file owner.</summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long UserId { get; }
	/// <summary>
	/// A file with the sticker in .WEBP, .PNG, .TGS, or .WEBM format. See https://core.telegram.org/stickers for technical requirements. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
	/// </summary>
	[JsonPropertyName(PropertyNames.Sticker)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputFile Sticker { get; }
	/// <summary>
	/// Format of the sticker, must be one of “static”, “animated”, “video”
	/// </summary>
	[JsonPropertyName(PropertyNames.StickerFormat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string StickerFormat { get; }
}
