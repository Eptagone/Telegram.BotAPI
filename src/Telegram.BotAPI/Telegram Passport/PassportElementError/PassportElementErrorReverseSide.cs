// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
	/// <summary>Represents an issue with the reverse side of a document. The error is considered resolved when the file with reverse side of the document changes.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class PassportElementErrorReverseSide : PassportElementError, IEquatable<PassportElementErrorReverseSide>
	{
		/// <summary>Error source, must be reverse_side.</summary>
		[JsonPropertyName(PropertyNames.Source)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Source => PassportElementErrorSource.ReverseSide;
		/// <summary>The section of the user's Telegram Passport which has the issue, one of “driver_license”, “identity_card”.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type { get; set; }
		/// <summary>Base64-encoded hash of the file with the reverse side of the document.</summary>
		[JsonPropertyName(PropertyNames.FileHash)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FileHash { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as PassportElementErrorReverseSide);
		}
		/// <inheritdoc/>
		public bool Equals(PassportElementErrorReverseSide? other)
		{
			return other != null &&
				   this.Source == other.Source &&
				   this.Type == other.Type &&
				   this.Message == other.Message &&
				   this.Source == other.Source &&
				   this.Type == other.Type &&
				   this.FileHash == other.FileHash;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -539630311;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Message);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileHash);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(PassportElementErrorReverseSide? left, PassportElementErrorReverseSide? right)
		{
			return EqualityComparer<PassportElementErrorReverseSide>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(PassportElementErrorReverseSide? left, PassportElementErrorReverseSide? right)
		{
			return !(left == right);
		}

	}
}
