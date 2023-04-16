// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>This object represents a sticker set.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class StickerSet
{
	/// <summary>
	/// Initializes a new instance of the <see cref="StickerSet"/> class.
	/// </summary>
	public StickerSet()
	{
		this.Name = null!;
		this.Title = null!;
		this.StickerType = null!;
		this.Stickers = null!;
	}

	/// <summary>Sticker set name.</summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; set; }
	/// <summary>Sticker set title.</summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Title { get; set; }
	/// <summary>
	/// Type of stickers in the set, currently one of "regular", "mask", "custom_emoji".
	/// </summary>
	/// <completionlist cref="StickerTypes"/>
	[JsonPropertyName(PropertyNames.StickerType)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string StickerType { get; set; }
	/// <summary>True, if the sticker is animated.</summary>
	[JsonPropertyName(PropertyNames.IsAnimated)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool IsAnimated { get; set; }
	/// <summary>True, if the sticker set contains video stickers.</summary>
	[JsonPropertyName(PropertyNames.IsVideo)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool IsVideo { get; set; }
	/// <summary>List of all set stickers.</summary>
	[JsonPropertyName(PropertyNames.Stickers)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<Sticker> Stickers { get; set; }
	/// <summary>Optional. Sticker set thumbnail in the .WEBP or .TGS format.</summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public PhotoSize? Thumbnail { get; set; }
}
