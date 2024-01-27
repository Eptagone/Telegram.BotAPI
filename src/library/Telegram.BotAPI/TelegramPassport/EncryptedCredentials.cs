// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Contains data required for decrypting and authenticating EncryptedPassportElement. See the <a href="https://core.telegram.org/passport#receiving-information">Telegram Passport Documentation</a> for a complete description of the data decryption and authentication processes.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class EncryptedCredentials : IEquatable<EncryptedCredentials>
{
	/// <summary>Base64-encoded encrypted JSON-serialized data with unique user's payload, data hashes and secrets required for EncryptedPassportElement decryption and authentication.</summary>
	[JsonPropertyName(PropertyNames.Data)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Data { get; set; }
	/// <summary>Base64-encoded data hash for data authentication.</summary>
	[JsonPropertyName(PropertyNames.Hash)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Hash { get; set; }
	/// <summary>Base64-encoded secret, encrypted with the bot's public RSA key, required for data decryption.</summary>
	[JsonPropertyName(PropertyNames.Secret)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Secret { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as EncryptedCredentials);
	}
	/// <inheritdoc/>
	public bool Equals(EncryptedCredentials? other)
	{
		return other != null &&
			   this.Data == other.Data &&
			   this.Hash == other.Hash &&
			   this.Secret == other.Secret;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 651824479;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Data);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Hash);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Secret);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(EncryptedCredentials? left, EncryptedCredentials? right)
	{
		return EqualityComparer<EncryptedCredentials>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(EncryptedCredentials? left, EncryptedCredentials? right)
	{
		return !(left == right);
	}

}
