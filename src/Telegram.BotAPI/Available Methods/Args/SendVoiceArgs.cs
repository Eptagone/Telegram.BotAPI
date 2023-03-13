// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>SendVoice method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SendVoiceArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage, IMultipartForm
	{
		/// <summary>
		/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendVoiceArgs(long chatId, InputFile voice) : base(chatId)
		{
			this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendVoiceArgs(long chatId, string voice) : base(chatId)
		{
			this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendVoiceArgs(string chatId, InputFile voice) : base(chatId)
		{
			this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
		}
		/// <summary>
		/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public SendVoiceArgs(string chatId, string voice) : base(chatId)
		{
			this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
		}

		/// <summary>Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
		[JsonPropertyName(PropertyNames.Voice)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object Voice { get; }
		/// <summary>Voice message caption, 0-1024 characters.</summary>
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
		/// <summary>Optional. Duration of the voice message in seconds.</summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? Duration { get; set; }

		/// <inheritdoc />
		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

		/// <summary>Attached files.</summary>
		bool IMultipartForm.UseMultipart()
		{
			if (this.Voice != default)
			{
				if (this.Voice.GetType() == typeof(InputFile))
				{
					return true;
				}
			}

			return this.AttachedFiles.Any();
		}
	}
}
