// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Represents an issue with a list of scans. The error is considered resolved when the list of files containing the scans changes.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class PassportElementErrorFiles : PassportElementError, IEquatable<PassportElementErrorFiles>
{
	/// <summary>Error source, must be files.</summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Source => PassportElementErrorSource.Files;
	/// <summary>The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>List of base64-encoded file hashes.</summary>
	[JsonPropertyName(PropertyNames.FileHashes)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<string> FileHashes { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as PassportElementErrorFiles);
	}
	/// <inheritdoc/>
	public bool Equals(PassportElementErrorFiles? other)
	{
		return other != null &&
			   this.Source == other.Source &&
			   this.Type == other.Type &&
			   this.Message == other.Message &&
			   this.Source == other.Source &&
			   this.Type == other.Type &&
			   EqualityComparer<IEnumerable<string>>.Default.Equals(this.FileHashes, other.FileHashes);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -1313300663;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Message);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<string>>.Default.GetHashCode(this.FileHashes);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(PassportElementErrorFiles? left, PassportElementErrorFiles? right)
	{
		return EqualityComparer<PassportElementErrorFiles>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(PassportElementErrorFiles? left, PassportElementErrorFiles? right)
	{
		return !(left == right);
	}

}
