// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	///<summary>Represents a join request sent to a chat.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChatJoinRequest : IEquatable<ChatJoinRequest>
	{
		///<summary>Chat to which the request was sent.</summary>
		[JsonPropertyName(PropertyNames.Chat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Chat Chat { get; set; }
		///<summary>User that sent the join request.</summary>
		[JsonPropertyName(PropertyNames.From)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public User From { get; set; }
		///<summary>Date the request was sent in Unix time.</summary>
		[JsonPropertyName(PropertyNames.Date)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Date { get; set; }
		///<summary>Optional. Bio of the user.</summary>
		[JsonPropertyName(PropertyNames.Bio)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Bio { get; set; }
		///<summary>Optional. Chat invite link that was used by the user to send the join request.</summary>
		[JsonPropertyName(PropertyNames.InviteLink)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string InviteLink { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ChatJoinRequest);
		}
		/// <inheritdoc/>
		public bool Equals(ChatJoinRequest? other)
		{
			return other != null &&
				   EqualityComparer<Chat>.Default.Equals(this.Chat, other.Chat) &&
				   EqualityComparer<User>.Default.Equals(this.From, other.From) &&
				   this.Date == other.Date &&
				   this.Bio == other.Bio &&
				   this.InviteLink == other.InviteLink;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1061456070;
			hashCode = hashCode * -1521134295 + EqualityComparer<Chat>.Default.GetHashCode(this.Chat);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.From);
			hashCode = hashCode * -1521134295 + this.Date.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Bio);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.InviteLink);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ChatJoinRequest? left, ChatJoinRequest? right)
		{
			return EqualityComparer<ChatJoinRequest>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ChatJoinRequest? left, ChatJoinRequest? right)
		{
			return !(left == right);
		}

	}
}
