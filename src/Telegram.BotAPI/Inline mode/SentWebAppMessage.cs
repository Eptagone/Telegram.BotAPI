// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Contains information about an inline message sent by a Web App on behalf of a user.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class SentWebAppMessage
	{
		/// <summary>
		/// Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message.
		/// </summary>
		[JsonPropertyName(PropertyNames.InlineMessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? InlineMessageId { get; set; }
	}
}
