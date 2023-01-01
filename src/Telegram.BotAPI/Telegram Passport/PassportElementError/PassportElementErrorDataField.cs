// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
	/// <summary>Represents an issue in one of the data fields that was provided by the user. The error is considered resolved when the field's value changes.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class PassportElementErrorDataField : PassportElementError, IEquatable<PassportElementErrorDataField>
	{
		/// <summary>Error source, must be data.</summary>
		[JsonPropertyName(PropertyNames.Source)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Source => PassportElementErrorSource.Data;
		/// <summary>The section of the user's Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type { get; set; }
		/// <summary>Name of the data field which has the error.</summary>
		[JsonPropertyName(PropertyNames.FieldName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FieldName { get; set; }
		/// <summary>Base64-encoded data hash.</summary>
		[JsonPropertyName(PropertyNames.DataHash)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string DataHash { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as PassportElementErrorDataField);
		}
		/// <inheritdoc/>
		public bool Equals(PassportElementErrorDataField? other)
		{
			return other != null &&
				   this.Source == other.Source &&
				   this.Type == other.Type &&
				   this.Message == other.Message &&
				   this.Source == other.Source &&
				   this.Type == other.Type &&
				   this.FieldName == other.FieldName &&
				   this.DataHash == other.DataHash;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -2002396357;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Message);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FieldName);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.DataHash);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(PassportElementErrorDataField? left, PassportElementErrorDataField? right)
		{
			return EqualityComparer<PassportElementErrorDataField>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(PassportElementErrorDataField? left, PassportElementErrorDataField? right)
		{
			return !(left == right);
		}

	}
}
