// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a service message about a video chat scheduled in the chat.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class VideoChatScheduled : IEquatable<VideoChatScheduled>
	{
		/// <summary>Point in time (Unix timestamp) when the voice chat is supposed to be started by a chat administrator.</summary>
		[JsonPropertyName(PropertyNames.StartDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint StartDate { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as VideoChatScheduled);
		}
		/// <inheritdoc/>
		public bool Equals(VideoChatScheduled? other)
		{
			return other != null &&
				   this.StartDate == other.StartDate;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return 1472038579 + this.StartDate.GetHashCode();
		}
		/// <inheritdoc/>
		public static bool operator ==(VideoChatScheduled? left, VideoChatScheduled? right)
		{
			return EqualityComparer<VideoChatScheduled>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(VideoChatScheduled? left, VideoChatScheduled? right)
		{
			return !(left == right);
		}

	}
}
