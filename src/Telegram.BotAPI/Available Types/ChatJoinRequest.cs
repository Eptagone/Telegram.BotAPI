// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Represents a join request sent to a chat.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChatJoinRequest
	{
		/// <summary>
		/// Chat to which the request was sent
		/// </summary>
		[JsonPropertyName(PropertyNames.Chat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Chat Chat { get; set; } = null!;
		/// <summary>
		/// User that sent the join request
		/// </summary>
		[JsonPropertyName(PropertyNames.From)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User From { get; set; } = null!;
		/// <summary>
		/// Identifier of a private chat with the user who sent the join request. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier. The bot can use this identifier for 24 hours to send messages until the join request is processed, assuming no other administrator contacted the user.
		/// </summary>
		[JsonPropertyName(PropertyNames.UserChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long UserChatId { get; set; }
		/// <summary>
		/// Date the request was sent in Unix time
		/// </summary>
		[JsonPropertyName(PropertyNames.Date)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Date { get; set; }
		/// <summary>
		/// Optional. Bio of the user.
		/// </summary>
		[JsonPropertyName(PropertyNames.Bio)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Bio { get; set; }
		/// <summary>
		/// Optional. Chat invite link that was used by the user to send the join request
		/// </summary>
		[JsonPropertyName(PropertyNames.InviteLink)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ChatInviteLink? InviteLink { get; set; }
	}
}
