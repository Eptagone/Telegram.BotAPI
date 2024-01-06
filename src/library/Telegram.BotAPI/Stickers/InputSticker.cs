// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// This object describes a sticker to be added to a sticker set.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InputSticker
{
	/// <summary>
	/// Initialize a new instance of <see cref="InputSticker"/>.
	/// </summary>
	/// <param name="sticker">The added sticker. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. Animated and video stickers can't be uploaded via HTTP URL. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
	/// <param name="emojiList">List of 1-20 emoji associated with the sticker</param>
	/// <exception cref="ArgumentNullException"></exception>
	public InputSticker(string sticker, IEnumerable<string> emojiList)
	{
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
		this.EmojiList = emojiList ?? throw new ArgumentNullException(nameof(emojiList));
	}

	/// <summary>
	/// The added sticker. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. Animated and video stickers can't be uploaded via HTTP URL. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
	/// </summary>
	[JsonPropertyName(PropertyNames.Sticker)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Sticker { get; }
	/// <summary>
	/// List of 1-20 emoji associated with the sticker
	/// </summary>
	[JsonPropertyName(PropertyNames.EmojiList)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<string> EmojiList { get; }
	/// <summary>
	/// Optional. Position where the mask should be placed on faces. For “mask” stickers only.
	/// </summary>
	[JsonPropertyName(PropertyNames.MaskPosition)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MaskPosition? MaskPosition { get; set; }
	/// <summary>
	/// Optional. List of 0-20 search keywords for the sticker with total length of up to 64 characters. For “regular” and “custom_emoji” stickers only.
	/// </summary>
	[JsonPropertyName(PropertyNames.Keywords)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<string>? Keywords { get; set; }
}
