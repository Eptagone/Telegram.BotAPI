// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the options used for link preview generation.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class LinkPreviewOptions
{
	/// <summary>
	/// Optional. True, if the link preview is disabled
	/// </summary>
	[JsonPropertyName(PropertyNames.IsDisabled)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsDisabled { get; set; }
	/// <summary>
	/// Optional. URL to use for the link preview. If empty, then the first URL found in the message text will be used
	/// </summary>
	[JsonPropertyName(PropertyNames.Url)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Url { get; set; }
	/// <summary>
	/// Optional. True, if the media in the link preview is suppposed to be shrunk; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
	/// </summary>
	[JsonPropertyName(PropertyNames.PreferSmallMedia)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? PreferSmallMedia { get; set; }
	/// <summary>
	/// Optional. True, if the media in the link preview is suppposed to be enlarged; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
	/// </summary>
	[JsonPropertyName(PropertyNames.PreferLargeMedia)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? PreferLargeMedia { get; set; }
	/// <summary>
	/// Optional. True, if the link preview must be shown above the message text; otherwise, the link preview will be shown below the message text
	/// </summary>
	[JsonPropertyName(PropertyNames.ShowAboveText)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ShowAboveText { get; set; }
}
