// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Represents a location to which a chat is connected.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ChatLocation : IEquatable<ChatLocation>
	{
		/// <summary>The location to which the supergroup is connected. Can't be a live location.</summary>
		[JsonPropertyName(PropertyNames.Location)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Location Location { get; set; }
		/// <summary>Location address; 1-64 characters, as defined by the chat owner.</summary>
		[JsonPropertyName(PropertyNames.Address)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Address { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ChatLocation);
		}
		/// <inheritdoc/>
		public bool Equals(ChatLocation? other)
		{
			return other != null &&
				   EqualityComparer<Location>.Default.Equals(this.Location, other.Location) &&
				   this.Address == other.Address;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1045638231;
			hashCode = hashCode * -1521134295 + EqualityComparer<Location>.Default.GetHashCode(this.Location);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Address);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ChatLocation? left, ChatLocation? right)
		{
			return EqualityComparer<ChatLocation>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ChatLocation? left, ChatLocation? right)
		{
			return !(left == right);
		}

	}
}