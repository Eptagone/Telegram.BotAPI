﻿// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object contains information about the chat whose identifier was shared with the bot using a KeyboardButtonRequestChat button.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChatShared
	{
		/// <summary>
		/// Identifier of the request.
		/// </summary>
		[JsonPropertyName(PropertyNames.RequestId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int RequestId { get; set; }
		/// <summary>
		/// Identifier of the shared chat. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier. The bot may not have access to the chat and could be unable to use this identifier, unless the chat is already known to the bot by some other means.
		/// </summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long ChatId { get; set; }
	}
}
