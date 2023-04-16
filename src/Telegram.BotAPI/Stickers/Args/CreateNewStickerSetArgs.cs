// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>CreateNewStickerSet method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class CreateNewStickerSetArgs : IMultipartForm
{
	/// <summary>
	/// Initialize a new instance of <see cref="CreateNewStickerSetArgs"/>.
	/// </summary>
	/// <param name="userId">User identifier of created sticker set owner.</param>
	/// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
	/// <param name="title">Sticker set title, 1-64 characters.</param>
	/// <param name="stickers">A <see cref="InputSticker"/> list of 1-50 initial stickers to be added to the sticker set.</param>
	/// <param name="stickerFormat">Format of stickers in the set, must be one of “static”, “animated”, “video”.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public CreateNewStickerSetArgs(long userId, string name, string title, IEnumerable<InputSticker> stickers, string stickerFormat)
	{
		this.UserId = userId;
		this.Name = name ?? throw new ArgumentNullException(nameof(name));
		this.Title = title ?? throw new ArgumentNullException(nameof(title));
		this.Stickers = stickers ?? throw new ArgumentNullException(nameof(stickers));
		this.StickerFormat = stickerFormat ?? throw new ArgumentNullException(nameof(stickerFormat));
	}

	/// <summary>
	/// User identifier of created sticker set owner.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long UserId { get; }
	/// <summary>
	/// Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.
	/// </summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; }
	/// <summary>
	/// Sticker set title, 1-64 characters.
	/// </summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Title { get; }
	/// <summary>
	/// A <see cref="InputSticker"/> list of 1-50 initial stickers to be added to the sticker set.
	/// </summary>
	[JsonPropertyName(PropertyNames.Stickers)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<InputSticker> Stickers { get; }
	/// <summary>
	/// Format of stickers in the set, must be one of “static”, “animated”, “video”.
	/// </summary>
	[JsonPropertyName(PropertyNames.StickerFormat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string StickerFormat { get; }
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

	/// <inheritdoc />
	[System.Text.Json.Serialization.JsonIgnore]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

	/// <inheritdoc />
	public bool UseMultipart() => this.AttachedFiles.Any();
}
