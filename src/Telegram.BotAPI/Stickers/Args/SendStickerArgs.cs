// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>SendSticker method arguments</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendStickerArgs : SendMessageWithReplyMarkupBase, IMultipartForm
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(long chatId, InputFile sticker) : base(chatId)
	{
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(long chatId, string sticker) : base(chatId)
	{
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(string chatId, InputFile sticker) : base(chatId)
	{
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendStickerArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendStickerArgs(string chatId, string sticker) : base(chatId)
	{
		this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
	}

	/// <summary>Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</summary>
	[JsonPropertyName(PropertyNames.Sticker)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object Sticker { get; set; }
	/// <summary>
	/// Emoji associated with the sticker; only for just uploaded stickers
	/// </summary>
	[JsonPropertyName(PropertyNames.Emoji)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Emoji { get; set; }

	/// <inheritdoc />
	[System.Text.Json.Serialization.JsonIgnore]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

	bool IMultipartForm.UseMultipart()
	{
		if (this.Sticker != default)
		{
			if (this.Sticker.GetType() == typeof(InputFile))
			{
				return true;
			}
		}

		return this.AttachedFiles.Any();
	}
}
