// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a service message about a video chat ended in the chat.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class VideoChatEnded : IEquatable<VideoChatEnded>
	{
		/// <summary>Video chat duration in seconds.</summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Duration { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as VideoChatEnded);
		}
		/// <inheritdoc/>
		public bool Equals(VideoChatEnded? other)
		{
			return other != null &&
				   this.Duration == other.Duration;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return -1943557835 + this.Duration.GetHashCode();
		}
		/// <inheritdoc/>
		public static bool operator ==(VideoChatEnded? left, VideoChatEnded? right)
		{
			return EqualityComparer<VideoChatEnded>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(VideoChatEnded? left, VideoChatEnded? right)
		{
			return !(left == right);
		}


	}
}
