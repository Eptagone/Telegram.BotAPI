// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Contains information about documents or other Telegram Passport elements shared with the bot by the user.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class EncryptedPassportElement : IEquatable<EncryptedPassportElement>
{
	/// <summary>Element type. One of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”, “phone_number”, “email”.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Type { get; set; }
	/// <summary>Optional. Base64-encoded encrypted Telegram Passport element data provided by the user, available for “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport” and “address” types. Can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
	[JsonPropertyName(PropertyNames.Data)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Data { get; set; }
	/// <summary>Optional. User's verified phone number, available only for “phone_number” type.</summary>
	[JsonPropertyName(PropertyNames.PhoneNumber)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string PhoneNumber { get; set; }
	/// <summary>Optional. User's verified email address, available only for “email” type.</summary>
	[JsonPropertyName(PropertyNames.Email)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Email { get; set; }
	/// <summary>Optional. Array of encrypted files with documents provided by the user, available for “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
	[JsonPropertyName(PropertyNames.Files)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<PassportFile> Files { get; set; }
	/// <summary>Optional. Encrypted file with the front side of the document, provided by the user. Available for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
	[JsonPropertyName(PropertyNames.FrontSide)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public PassportFile FrontSide { get; set; }
	/// <summary>Optional. Encrypted file with the reverse side of the document, provided by the user. Available for “driver_license” and “identity_card”. The file can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
	[JsonPropertyName(PropertyNames.ReverseSide)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public PassportFile ReverseSide { get; set; }
	/// <summary>Optional. Encrypted file with the selfie of the user holding a document, provided by the user; available for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
	[JsonPropertyName(PropertyNames.Selfie)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public PassportFile Selfie { get; set; }
	/// <summary>Optional. Array of encrypted files with translated versions of documents provided by the user. Available if requested for “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
	[JsonPropertyName(PropertyNames.Translation)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<PassportFile> Translation { get; set; }
	/// <summary>Base64-encoded element hash for using in PassportElementErrorUnspecified.</summary>
	[JsonPropertyName(PropertyNames.Hash)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Hash { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as EncryptedPassportElement);
	}
	/// <inheritdoc/>
	public bool Equals(EncryptedPassportElement? other)
	{
		return other != null &&
			   this.Type == other.Type &&
			   this.Data == other.Data &&
			   this.PhoneNumber == other.PhoneNumber &&
			   this.Email == other.Email &&
			   EqualityComparer<IEnumerable<PassportFile>>.Default.Equals(this.Files, other.Files) &&
			   EqualityComparer<PassportFile>.Default.Equals(this.FrontSide, other.FrontSide) &&
			   EqualityComparer<PassportFile>.Default.Equals(this.ReverseSide, other.ReverseSide) &&
			   EqualityComparer<PassportFile>.Default.Equals(this.Selfie, other.Selfie) &&
			   EqualityComparer<IEnumerable<PassportFile>>.Default.Equals(this.Translation, other.Translation) &&
			   this.Hash == other.Hash;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1603814458;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Data);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PhoneNumber);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Email);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<PassportFile>>.Default.GetHashCode(this.Files);
		hashCode = hashCode * -1521134295 + EqualityComparer<PassportFile>.Default.GetHashCode(this.FrontSide);
		hashCode = hashCode * -1521134295 + EqualityComparer<PassportFile>.Default.GetHashCode(this.ReverseSide);
		hashCode = hashCode * -1521134295 + EqualityComparer<PassportFile>.Default.GetHashCode(this.Selfie);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<PassportFile>>.Default.GetHashCode(this.Translation);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Hash);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(EncryptedPassportElement? left, EncryptedPassportElement? right)
	{
		return EqualityComparer<EncryptedPassportElement>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(EncryptedPassportElement? left, EncryptedPassportElement? right)
	{
		return !(left == right);
	}

}
