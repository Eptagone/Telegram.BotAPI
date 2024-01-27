// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents an animation file (GIF or H.264/MPEG-4 AVC video without sound) to be sent.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InputMediaAnimation : InputMedia, IThumbnail<string>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InputMediaAnimation"/> class.
	/// </summary>
	/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
	public InputMediaAnimation(string media) : base(media)
	{
	}

	/// <summary>Type of the result, must be animation.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InputMediaType.Animation;
	/// <summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;.</summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Thumbnail { get; set; }
	/// <summary>Optional. Caption of the animation to be sent, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string? Caption { get; set; }
	/// <summary>Optional. Animation width.</summary>
	[JsonPropertyName(PropertyNames.Width)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Width { get; set; }
	/// <summary>Optional. Animation height.</summary>
	[JsonPropertyName(PropertyNames.Height)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Height { get; set; }
	/// <summary>Optional. Animation duration.</summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Duration { get; set; }
	/// <summary>Optional. Pass True if the animation needs to be covered with a spoiler animation.</summary>
	[JsonPropertyName(PropertyNames.HasSpoiler)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasSpoiler { get; set; }
}
