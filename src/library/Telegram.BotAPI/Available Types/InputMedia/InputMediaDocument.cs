// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents a general file to be sent.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InputMediaDocument : InputMedia, IThumbnail<string>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InputMediaDocument"/> class.
	/// </summary>
	/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
	public InputMediaDocument(string media) : base(media)
	{
	}

	/// <summary>Type of the result, must be document.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InputMediaType.Document;
	/// <summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Thumbnail { get; set; }
	/// <summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string? Caption { get; set; }
	/// <summary>Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</summary>
	[JsonPropertyName(PropertyNames.DisableContentTypeDetection)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableContentTypeDetection { get; set; }
}
