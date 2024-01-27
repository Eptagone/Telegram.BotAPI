// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents a photo to be sent.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InputMediaPhoto : InputMedia
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InputMediaPhoto"/> class.
	/// </summary>
	/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass �attach://&lt;file_attach_name&gt;� to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
	public InputMediaPhoto(string media) : base(media)
	{
	}

	/// <summary>Type of the result, must be photo.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InputMediaType.Photo;
	/// <summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string? Caption { get; set; }
	/// <summary>Optional. Pass True if the photo needs to be covered with a spoiler animation.</summary>
	[JsonPropertyName(PropertyNames.HasSpoiler)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasSpoiler { get; set; }
}
