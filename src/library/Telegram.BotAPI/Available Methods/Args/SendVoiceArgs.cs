// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendVoice method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendVoiceArgs : AttachedFilesArgsBase
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVoiceArgs(long chatId, InputFile voice)
	{
		this.ChatId = chatId;
		this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVoiceArgs(long chatId, string voice)
	{
		this.ChatId = chatId;
		this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVoiceArgs(string chatId, InputFile voice)
	{
		this.ChatId = chatId;
		this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendVoiceArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="voice">Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SendVoiceArgs(string chatId, string voice)
	{
		this.ChatId = chatId;
		this.Voice = voice ?? throw new ArgumentNullException(nameof(voice));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files »
	/// </summary>
	[JsonPropertyName(PropertyNames.Voice)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object Voice { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// Voice message caption, 0-1024 characters after entities parsing
	/// </summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Caption { get; set; }
	/// <summary>
	/// Mode for parsing entities in the voice message caption. See formatting options for more details.
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
	/// Duration of the voice message in seconds
	/// </summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Duration { get; set; }
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
