// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>SendMediaGroud method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SendMediaGroupArgs : SendMessageBase, IMultipartForm
{
	/// <summary>
	/// Initialize a new instance of <see cref="SendMediaGroupArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
	public SendMediaGroupArgs(long chatId, IEnumerable<InputMedia> media) : base(chatId)
	{
		this.Media = new HashSet<InputMedia>(media ?? throw new ArgumentNullException(nameof(media)));
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SendMediaGroupArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
	public SendMediaGroupArgs(string chatId, IEnumerable<InputMedia> media) : base(chatId)
	{
		this.Media = new HashSet<InputMedia>(media ?? throw new ArgumentNullException(nameof(media)));
	}

	/// <summary>An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</summary>
	[JsonPropertyName(PropertyNames.Media)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ICollection<InputMedia> Media { get; }

	/// <inheritdoc />
	[System.Text.Json.Serialization.JsonIgnore]
	public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

	bool IMultipartForm.UseMultipart()
	{
		return this.AttachedFiles.Any();
	}
}
