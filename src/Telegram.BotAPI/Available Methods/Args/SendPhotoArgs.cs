// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>SendPhoto method arguments</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendPhotoArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage, IMultipartForm
	{
		/// <summary>
		/// Initialize a new isntance of <see cref="SendPhotoArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
		public SendPhotoArgs(long chatId, InputFile photo) : base(chatId)
		{
			this.Photo = photo;
		}

		/// <summary>
		/// Initialize a new isntance of <see cref="SendPhotoArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
		public SendPhotoArgs(string chatId, InputFile photo) : base(chatId)
		{
			this.Photo = photo;
		}

		/// <summary>
		/// Initialize a new isntance of <see cref="SendPhotoArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
		public SendPhotoArgs(long chatId, string photo) : base(chatId)
		{
			this.Photo = photo;
		}

		/// <summary>
		/// Initialize a new isntance of <see cref="SendPhotoArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
		public SendPhotoArgs(string chatId, string photo) : base(chatId)
		{
			this.Photo = photo;
		}

		/// <summary>
		/// InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.
		/// </summary>
		[JsonPropertyName(PropertyNames.Photo)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object Photo { get; }
		/// <summary>Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
		[JsonPropertyName(PropertyNames.ParseMode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ParseMode { get; set; }
		/// <summary>Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
		[JsonPropertyName(PropertyNames.CaptionEntities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
		/// <summary>
		/// Pass True if the photo needs to be covered with a spoiler animation
		/// </summary>
		[JsonPropertyName(PropertyNames.HasSpoiler)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? HasSpoiler { get; set; }

		/// <inheritdoc />
		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

		bool IMultipartForm.UseMultipart()
		{
			if (this.Photo != default)
			{
				if (this.Photo.GetType() == typeof(InputFile))
				{
					return true;
				}
			}

			return AttachedFiles.Any();
		}
	}
}
