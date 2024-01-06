// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// SetStickerSetThumb method arguments.
/// </summary>
/// <param name="name">Sticker set name</param>
/// <param name="userId">User identifier of the sticker set owner</param>
/// <exception cref="ArgumentNullException"></exception>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetStickerSetThumbnailArgs(string name, long userId) : AttachedFilesArgsBase
{
	/// <summary>Sticker set name</summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
	/// <summary>User identifier of the sticker set owner</summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long UserId { get; } = userId;
	/// <summary>
	/// Optional. A .WEBP or .PNG image with the thumbnail, must be up to 128 kilobytes in size and have a width and height of exactly 100px, or a .TGS animation with a thumbnail up to 32 kilobytes in size (see https://core.telegram.org/stickers#animated-sticker-requirements for animated sticker technical requirements), or a WEBM video with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/stickers#video-sticker-requirements for video sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Animated and video sticker set thumbnails can't be uploaded via HTTP URL. If omitted, then the thumbnail is dropped and the first sticker is used as the thumbnail.
	/// </summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? Thumbnail { get; set; }
}
