// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>AddStickerToSet method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class AddStickerToSetArgs : IMultipartForm
{
	/// <summary>
	/// Initialize a new instance of <see cref="AddStickerToSetArgs"/>.
	/// </summary>
	/// <param name="userId">User identifier of sticker set owner.</param>
	/// <param name="name">Sticker set name.</param>
	/// <param name="sticker">A <see cref="InputSticker"/> object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public AddStickerToSetArgs(long userId, string name, InputSticker sticker)
	{
		this.UserId = userId;
		this.Name = name ?? throw new ArgumentNullException(nameof(name));
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}

	/// <summary>User identifier of sticker set owner.</summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long UserId { get; }
	/// <summary>Sticker set name.</summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; }
	/// <summary>
	/// A <see cref="InputSticker"/> object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.
	/// </summary>
	[JsonPropertyName(PropertyNames.Sticker)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputSticker Sticker { get; }

	/// <inheritdoc />
	[System.Text.Json.Serialization.JsonIgnore]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

	/// <inheritdoc />
	bool IMultipartForm.UseMultipart() => this.AttachedFiles.Any();
}
