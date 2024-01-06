// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// AddStickerToSet method arguments.
/// </summary>
/// <param name="userId">User identifier of sticker set owner.</param>
/// <param name="name">Sticker set name.</param>
/// <param name="sticker">A <see cref="InputSticker"/> object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.</param>
/// <exception cref="ArgumentNullException"></exception>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class AddStickerToSetArgs(long userId, string name, InputSticker sticker) : AttachedFilesArgsBase
{
	/// <summary>User identifier of sticker set owner.</summary>
	[JsonPropertyName(PropertyNames.UserId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long UserId { get; } = userId;
	/// <summary>Sticker set name.</summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
	/// <summary>
	/// A <see cref="InputSticker"/> object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.
	/// </summary>
	[JsonPropertyName(PropertyNames.Sticker)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputSticker Sticker { get; } = sticker ?? throw new ArgumentNullException(nameof(sticker));
}
