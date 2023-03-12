// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Contains information about why a request was unsuccessful.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ResponseParameters : IEquatable<ResponseParameters>
	{
		/// <summary>Optional. The group has been migrated to a supergroup with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
		[JsonPropertyName(PropertyNames.MigrateToChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public long MigrateToChatId { get; set; }
		/// <summary>Optional. In case of exceeding flood control, the number of seconds left to wait before the request can be repeated.</summary>
		[JsonPropertyName(PropertyNames.RetryAfter)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint RetryAfter { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ResponseParameters);
		}
		/// <inheritdoc/>
		public bool Equals(ResponseParameters? other)
		{
			return other != null &&
				   this.MigrateToChatId == other.MigrateToChatId &&
				   this.RetryAfter == other.RetryAfter;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1065444587;
			hashCode = hashCode * -1521134295 + this.MigrateToChatId.GetHashCode();
			hashCode = hashCode * -1521134295 + this.RetryAfter.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ResponseParameters? left, ResponseParameters? right)
		{
			return EqualityComparer<ResponseParameters>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ResponseParameters? left, ResponseParameters? right)
		{
			return !(left == right);
		}

	}
}
