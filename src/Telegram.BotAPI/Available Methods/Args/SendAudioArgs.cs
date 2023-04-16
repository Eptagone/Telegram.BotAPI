// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendAudio method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendAudioArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage, IMultipartForm, IThumbnail<object>
{
	/// <summary>Initialize a new instance of <see cref="SendAudioArgs"/>.</summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendAudioArgs(long chatId, InputFile audio) : base(chatId)
	{
		this.Audio = audio ?? throw new ArgumentNullException(nameof(audio));
	}
	/// <summary>Initialize a new instance of <see cref="SendAudioArgs"/>.</summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendAudioArgs(long chatId, string audio) : base(chatId)
	{
		this.Audio = audio ?? throw new ArgumentNullException(nameof(audio));
	}
	/// <summary>Initialize a new instance of <see cref="SendAudioArgs"/>.</summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendAudioArgs(string chatId, InputFile audio) : base(chatId)
	{
		this.Audio = audio ?? throw new ArgumentNullException(nameof(audio));
	}
	/// <summary>Initialize a new instance of <see cref="SendAudioArgs"/>.</summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendAudioArgs(string chatId, string audio) : base(chatId)
	{
		this.Audio = audio ?? throw new ArgumentNullException(nameof(audio));
	}

	/// <summary>
	/// Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data.
	/// </summary>
	[JsonPropertyName(PropertyNames.Audio)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object Audio { get; }
	/// <summary>Audio caption, 0-1024 characters</summary>
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
	/// <summary>Optional. Duration of the audio in seconds.</summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Duration { get; set; }
	/// <summary>Optional. Performer.</summary>
	[JsonPropertyName(PropertyNames.Performer)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Performer { get; set; }
	/// <summary>Optional. Track name.</summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Title { get; set; }
	/// <summary>Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? Thumbnail { get; set; }

	/// <inheritdoc />
	[System.Text.Json.Serialization.JsonIgnore]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

	bool IMultipartForm.UseMultipart()
	{
		if (this.Audio != default && this.Audio.GetType() == typeof(InputFile))
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
