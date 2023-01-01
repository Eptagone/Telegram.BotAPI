// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
	/// <summary>StopPoll method parameters.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class StopPollArgs
	{
		/// <summary>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object ChatId { get; set; }
		/// <summary>Identifier of the original message with the poll.</summary>
		[JsonPropertyName(PropertyNames.MessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int MessageId { get; set; }
		/// <summary>Optional. A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</summary>
		[JsonPropertyName(PropertyNames.ReplyMarkup)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InlineKeyboardMarkup ReplyMarkup { get; set; }
	}
}
