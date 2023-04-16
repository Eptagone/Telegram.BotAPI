// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>SetStickerSetThumb method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetStickerSetThumbnailArgs : IMultipartForm
{
	/// <summary>
	/// Initialize a new instance of the <see cref="SetStickerSetThumbnailArgs"/> class using required parameters.
	/// </summary>
	/// <param name="name">Sticker set name</param>
	/// <param name="userId">User identifier of the sticker set owner</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SetStickerSetThumbnailArgs(string name, long userId)
	{
		this.Name = name ?? throw new ArgumentNullException(nameof(name));
		this.UserId = userId;
	}

	/// <summary>Sticker set name</summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; }
	/// <summary>User identifier of the sticker set owner</summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long UserId { get; }
	/// <summary>
	/// Optional. A .WEBP or .PNG image with the thumbnail, must be up to 128 kilobytes in size and have a width and height of exactly 100px, or a .TGS animation with a thumbnail up to 32 kilobytes in size (see https://core.telegram.org/stickers#animated-sticker-requirements for animated sticker technical requirements), or a WEBM video with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/stickers#video-sticker-requirements for video sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ». Animated and video sticker set thumbnails can't be uploaded via HTTP URL. If omitted, then the thumbnail is dropped and the first sticker is used as the thumbnail.
	/// </summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? Thumbnail { get; set; }

	/// <inheritdoc />
	[System.Text.Json.Serialization.JsonIgnore]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

	bool IMultipartForm.UseMultipart()
	{
		if (this.Thumbnail != default && this.Thumbnail.GetType() == typeof(InputFile))
		{
			return true;
		}

		return this.AttachedFiles.Any();
	}
}
