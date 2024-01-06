// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Represents an issue in an unspecified place. The error is considered resolved when new data is added.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class PassportElementErrorUnspecified : PassportElementError, IEquatable<PassportElementErrorUnspecified>
{
	/// <summary>Error source, must be unspecified.</summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Source => PassportElementErrorSource.Unspecified;
	/// <summary>Type of element of the user's Telegram Passport which has the issue.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>Base64-encoded element hash.</summary>
	[JsonPropertyName(PropertyNames.ElementHash)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ElementHash { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as PassportElementErrorUnspecified);
	}
	/// <inheritdoc/>
	public bool Equals(PassportElementErrorUnspecified? other)
	{
		return other != null &&
			   this.Source == other.Source &&
			   this.Type == other.Type &&
			   this.Message == other.Message &&
			   this.Source == other.Source &&
			   this.Type == other.Type &&
			   this.ElementHash == other.ElementHash;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1806438429;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Message);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ElementHash);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(PassportElementErrorUnspecified? left, PassportElementErrorUnspecified? right)
	{
		return EqualityComparer<PassportElementErrorUnspecified>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(PassportElementErrorUnspecified? left, PassportElementErrorUnspecified? right)
	{
		return !(left == right);
	}

}
