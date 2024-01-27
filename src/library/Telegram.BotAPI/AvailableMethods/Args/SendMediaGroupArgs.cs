// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendMediaGroud method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendMediaGroupArgs : AttachedFilesArgsBase
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendMediaGroupArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
	public SendMediaGroupArgs(long chatId, IEnumerable<InputMedia> media)
	{
		this.ChatId = chatId;
		this.Media = new HashSet<InputMedia>(media ?? throw new ArgumentNullException(nameof(media)));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendMediaGroupArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
	public SendMediaGroupArgs(string chatId, IEnumerable<InputMedia> media)
	{
		this.ChatId = chatId;
		this.Media = new HashSet<InputMedia>(media ?? throw new ArgumentNullException(nameof(media)));
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// A JSON-serialized array describing messages to be sent, must include 2-10 items
	/// </summary>
	[JsonPropertyName(PropertyNames.Media)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<InputMedia> Media { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// Sends messages silently. Users will receive a notification with no sound.
	/// </summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>
	/// Protects the contents of the sent messages from forwarding and saving
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
}
