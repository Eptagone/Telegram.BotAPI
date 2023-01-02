// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a link to an MP3 audio file stored on the Telegram servers. By default, this audio file will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the audio.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultCachedAudio : InlineQueryResultWithEntities, ICaption
	{
		/// <summary>Type of the result, must be audio.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Audio;
		/// <summary>A valid file identifier for the audio file.</summary>
		[JsonPropertyName(PropertyNames.AudioFileId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string AudioFileId { get; set; }
		/// <summary>Optional. Caption, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent? InputMessageContent { get; set; }
	}
}
