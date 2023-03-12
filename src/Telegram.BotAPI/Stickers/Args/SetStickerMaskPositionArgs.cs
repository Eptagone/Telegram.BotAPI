// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Stickers
{
	/// <summary>SetStickerMaskPosition method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SetStickerMaskPositionArgs
	{
		/// <summary>
		/// Initialize a new instance of the <see cref="SetStickerMaskPositionArgs"/> class.
		/// </summary>
		/// <param name="sticker">File identifier of the sticker.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SetStickerMaskPositionArgs(string sticker)
		{
			this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
		}

		/// <summary>
		/// File identifier of the sticker.
		/// </summary>
		[JsonPropertyName(PropertyNames.Sticker)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Sticker { get; }
		/// <summary>
		/// A <see cref="MaskPosition"/> object with the position where the mask should be placed on faces. Omit the parameter to remove the mask position.
		/// </summary>
		[JsonPropertyName(PropertyNames.MaskPosition)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public MaskPosition? MaskPosition { get; set; }
	}
}
