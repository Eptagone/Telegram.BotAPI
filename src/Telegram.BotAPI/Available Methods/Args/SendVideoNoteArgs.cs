// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendVideoNote method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendVideoNoteArgs : SendMessageWithReplyMarkupBase, IMultipartForm
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(long chatId, InputFile videoNote) : base(chatId)
	{
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(long chatId, string videoNote) : base(chatId)
	{
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(string chatId, InputFile videoNote) : base(chatId)
	{
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(string chatId, string videoNote) : base(chatId)
	{
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}

	/// <summary>Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</summary>
	[JsonPropertyName(PropertyNames.VideoNote)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object VideoNote { get; }
	/// <summary>Optional. Duration of sent video in seconds.</summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Duration { get; set; }
	/// <summary>Optional. Video width and height, i.e. diameter of the video message.</summary>
	[JsonPropertyName(PropertyNames.Length)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Length { get; set; }
	/// <summary>
	/// Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.
	/// </summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? Thumbnail { get; set; }

	/// <inheritdoc />
	[System.Text.Json.Serialization.JsonIgnore]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

	bool IMultipartForm.UseMultipart()
	{
		if (this.VideoNote != default && this.VideoNote.GetType() == typeof(InputFile))
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
