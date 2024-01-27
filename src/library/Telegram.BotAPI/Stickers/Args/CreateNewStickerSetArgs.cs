// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;

namespace Telegram.BotAPI.Stickers;

/// <summary>CreateNewStickerSet method arguments.</summary>
/// <param name="userId">User identifier of created sticker set owner.</param>
/// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
/// <param name="title">Sticker set title, 1-64 characters.</param>
/// <param name="stickers">A <see cref="InputSticker"/> list of 1-50 initial stickers to be added to the sticker set.</param>
/// <param name="stickerFormat">Format of stickers in the set, must be one of “static”, “animated”, “video”.</param>
/// <exception cref="ArgumentNullException"></exception>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class CreateNewStickerSetArgs(long userId, string name, string title, IEnumerable<InputSticker> stickers, string stickerFormat) : AttachedFilesArgsBase
{
	/// <summary>
	/// User identifier of created sticker set owner.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long UserId { get; } = userId;
	/// <summary>
	/// Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.
	/// </summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
	/// <summary>
	/// Sticker set title, 1-64 characters.
	/// </summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Title { get; } = title ?? throw new ArgumentNullException(nameof(title));
	/// <summary>
	/// A <see cref="InputSticker"/> list of 1-50 initial stickers to be added to the sticker set.
	/// </summary>
	[JsonPropertyName(PropertyNames.Stickers)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<InputSticker> Stickers { get; } = stickers ?? throw new ArgumentNullException(nameof(stickers));
	/// <summary>
	/// Format of stickers in the set, must be one of “static”, “animated”, “video”.
	/// </summary>
	[JsonPropertyName(PropertyNames.StickerFormat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string StickerFormat { get; } = stickerFormat ?? throw new ArgumentNullException(nameof(stickerFormat));
	/// <summary>
	/// Optional. Type of stickers in the set, pass “regular”, “mask”, or “custom_emoji”. By default, a regular sticker set is created.
	/// </summary>
	[JsonPropertyName(PropertyNames.StickerType)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? StickerType { get; set; }
	/// <summary>
	/// Optional. Pass True if stickers in the sticker set must be repainted to the color of text when used in messages, the accent color if used as emoji status, white on chat photos, or another appropriate color based on context; for custom emoji sticker sets only.
	/// </summary>
	[JsonPropertyName(PropertyNames.NeedsRepainting)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? NeedsRepainting { get; set; }
}