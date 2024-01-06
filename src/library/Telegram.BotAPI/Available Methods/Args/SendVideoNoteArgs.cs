// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendVideoNote method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendVideoNoteArgs : AttachedFilesArgsBase
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(long chatId, InputFile videoNote)
	{
		this.ChatId = chatId;
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(long chatId, string videoNote)
	{
		this.ChatId = chatId;
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(string chatId, InputFile videoNote)
	{
		this.ChatId = chatId;
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVideoNoteArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="videoNote">Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVideoNoteArgs(string chatId, string videoNote)
	{
		this.ChatId = chatId;
		this.VideoNote = videoNote ?? throw new ArgumentNullException(nameof(videoNote));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending video notes by a URL is currently unsupported
	/// </summary>
	[JsonPropertyName(PropertyNames.VideoNote)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object VideoNote { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// Duration of sent video in seconds
	/// </summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Duration { get; set; }
	/// <summary>
	/// Video width and height, i.e. diameter of the video message
	/// </summary>
	[JsonPropertyName(PropertyNames.Length)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Length { get; set; }
	/// <summary>
	/// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
	/// </summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? Thumbnail { get; set; }
	/// <summary>
	/// Sends the message silently. Users will receive a notification with no sound.
	/// </summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>
	/// Protects the contents of the sent message from forwarding and saving
	/// </summary>
	[JsonPropertyName(PropertyNames.ProtectContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ProtectContent { get; set; }
	/// <summary>
	/// Description of the message to reply to
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyParameters)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyParameters? ReplyParameters { get; set; }
	/// <summary>
	/// Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyMarkup? ReplyMarkup { get; set; }
}
