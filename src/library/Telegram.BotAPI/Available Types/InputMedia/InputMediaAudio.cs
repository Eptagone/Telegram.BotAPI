// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents an audio file to be treated as music to be sent.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InputMediaAudio : InputMedia, IThumbnail<string>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InputMediaAudio"/> class.
	/// </summary>
	/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
	public InputMediaAudio(string media) : base(media)
	{
	}

	/// <summary>Type of the result, must be audio.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InputMediaType.Audio;
	/// <summary>
	/// Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.
	/// </summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Thumbnail { get; set; }
	/// <summary>Optional. Caption of the audio to be sent, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string? Caption { get; set; }
	/// <summary>Optional. Duration of the audio in seconds.</summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Duration { get; set; }
	/// <summary>Optional. Performer of the audio.</summary>
	[JsonPropertyName(PropertyNames.Performer)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Performer { get; set; }
	/// <summary>Optional. Title of the audio.</summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Title { get; set; }
}
