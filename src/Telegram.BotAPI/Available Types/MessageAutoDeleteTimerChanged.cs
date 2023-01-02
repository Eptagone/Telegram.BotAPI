// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a service message about a change in auto-delete timer settings.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class MessageAutoDeleteTimerChanged : IEquatable<MessageAutoDeleteTimerChanged>
	{
		/// <summary>New auto-delete time for messages in the chat.</summary>
		[JsonPropertyName(PropertyNames.MessageAutoDeleteTime)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint MessageAutoDeleteTime { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as MessageAutoDeleteTimerChanged);
		}
		/// <inheritdoc/>
		public bool Equals(MessageAutoDeleteTimerChanged? other)
		{
			return other != null &&
				   this.MessageAutoDeleteTime == other.MessageAutoDeleteTime;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return -523407135 + this.MessageAutoDeleteTime.GetHashCode();
		}
		/// <inheritdoc/>
		public static bool operator ==(MessageAutoDeleteTimerChanged? left, MessageAutoDeleteTimerChanged? right)
		{
			return EqualityComparer<MessageAutoDeleteTimerChanged>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(MessageAutoDeleteTimerChanged? left, MessageAutoDeleteTimerChanged? right)
		{
			return !(left == right);
		}


	}
}
