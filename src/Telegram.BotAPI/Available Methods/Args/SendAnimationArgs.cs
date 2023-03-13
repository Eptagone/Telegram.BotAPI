// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>SendAnimation method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendAnimationArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage, IMultipartForm, IThumbnail<object>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SendAnimationArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
		public SendAnimationArgs(long chatId, InputFile animation) : base(chatId)
		{
			this.Animation = animation;
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendAnimationArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
		public SendAnimationArgs(long chatId, string animation) : base(chatId)
		{
			this.Animation = animation;
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendAnimationArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
		public SendAnimationArgs(string chatId, InputFile animation) : base(chatId)
		{
			this.Animation = animation;
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendAnimationArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
		public SendAnimationArgs(string chatId, string animation) : base(chatId)
		{
			this.Animation = animation;
		}

		/// <summary>
		/// Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
		/// </summary>
		[JsonPropertyName(PropertyNames.Animation)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object Animation { get; set; }
		/// <summary>
		/// Duration of sent animation in seconds
		/// </summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? Duration { get; set; }
		/// <summary>
		/// Animation width
		/// </summary>
		[JsonPropertyName(PropertyNames.Width)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? Width { get; set; }
		/// <summary>
		/// Animation height
		/// </summary>
		[JsonPropertyName(PropertyNames.Height)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? Height { get; set; }
		/// <summary>
		/// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
		/// </summary>
		[JsonPropertyName(PropertyNames.Thumbnail)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object? Thumbnail { get; set; }
		/// <summary>
		/// Animation caption (may also be used when resending animation by file_id), 0-1024 characters after entities parsing
		/// </summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>
		/// Mode for parsing entities in the animation caption. See formatting options for more details.
		/// </summary>
		[JsonPropertyName(PropertyNames.ParseMode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ParseMode { get; set; }
		/// <summary>
		/// A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode
		/// </summary>
		[JsonPropertyName(PropertyNames.CaptionEntities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
		/// <summary>
		/// Pass True if the animation needs to be covered with a spoiler animation
		/// </summary>
		[JsonPropertyName(PropertyNames.HasSpoiler)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? HasSpoiler { get; set; }

		/// <inheritdoc />
		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

		bool IMultipartForm.UseMultipart()
		{
			if (this.Animation != default && this.Animation.GetType() == typeof(InputFile))
			{
				return true;
			}

			if (this.Thumbnail != default && this.Thumbnail.GetType() == typeof(InputFile))
			{
				return true;
			}

			return this.AttachedFiles.Any();
		}
	}
}
