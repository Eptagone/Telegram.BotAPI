// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Contains information about Telegram Passport data shared with the bot by the user.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class PassportData : IEquatable<PassportData>
{
	/// <summary>Array with information about documents and other Telegram Passport elements that was shared with the bot.</summary>
	[JsonPropertyName(PropertyNames.Data)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<EncryptedPassportElement> Data { get; set; }
	/// <summary>Encrypted credentials required to decrypt the data.</summary>
	[JsonPropertyName(PropertyNames.Credentials)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public EncryptedCredentials Credentials { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as PassportData);
	}
	/// <inheritdoc/>
	public bool Equals(PassportData? other)
	{
		return other != null &&
			   EqualityComparer<IEnumerable<EncryptedPassportElement>>.Default.Equals(this.Data, other.Data) &&
			   EqualityComparer<EncryptedCredentials>.Default.Equals(this.Credentials, other.Credentials);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -1529841922;
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<EncryptedPassportElement>>.Default.GetHashCode(this.Data);
		hashCode = hashCode * -1521134295 + EqualityComparer<EncryptedCredentials>.Default.GetHashCode(this.Credentials);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(PassportData? left, PassportData? right)
	{
		return EqualityComparer<PassportData>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(PassportData? left, PassportData? right)
	{
		return !(left == right);
	}

}
