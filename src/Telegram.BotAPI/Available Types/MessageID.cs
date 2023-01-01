// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a unique message identifier.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class MessageID : IEquatable<MessageID>
	{
		/// <summary>Unique message identifier.</summary>
		[JsonPropertyName(PropertyNames.MessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int MessageId { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as MessageID);
		}
		/// <inheritdoc/>
		public bool Equals(MessageID? other)
		{
			return other != null &&
				   this.MessageId == other.MessageId;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return 212258449 + this.MessageId.GetHashCode();
		}
		/// <inheritdoc/>
		public static bool operator ==(MessageID? left, MessageID? right)
		{
			return EqualityComparer<MessageID>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(MessageID? left, MessageID? right)
		{
			return !(left == right);
		}

	}
}
