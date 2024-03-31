// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Describes documents or other Telegram Passport elements shared with the bot by the user.
/// </summary>
public class EncryptedPassportElement
{
    /// <summary>
    /// Element type. One of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”, “phone_number”, “email”.
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public string Type { get; set; } = null!;

    /// <summary>
    /// Optional. Base64-encoded encrypted Telegram Passport element data provided by the user; available only for “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport” and “address” types. Can be decrypted and verified using the accompanying <see cref="EncryptedCredentials"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Data)]
    public string? Data { get; set; }

    /// <summary>
    /// Optional. User's verified phone number; available only for “phone_number” type
    /// </summary>
    [JsonPropertyName(PropertyNames.PhoneNumber)]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Optional. User's verified email address; available only for “email” type
    /// </summary>
    [JsonPropertyName(PropertyNames.Email)]
    public string? Email { get; set; }

    /// <summary>
    /// Optional. Array of encrypted files with documents provided by the user; available only for “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying <see cref="EncryptedCredentials"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Files)]
    public IEnumerable<PassportFile>? Files { get; set; }

    /// <summary>
    /// Optional. Encrypted file with the front side of the document, provided by the user; available only for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying <see cref="EncryptedCredentials"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.FrontSide)]
    public PassportFile? FrontSide { get; set; }

    /// <summary>
    /// Optional. Encrypted file with the reverse side of the document, provided by the user; available only for “driver_license” and “identity_card”. The file can be decrypted and verified using the accompanying <see cref="EncryptedCredentials"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReverseSide)]
    public PassportFile? ReverseSide { get; set; }

    /// <summary>
    /// Optional. Encrypted file with the selfie of the user holding a document, provided by the user; available if requested for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying <see cref="EncryptedCredentials"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Selfie)]
    public PassportFile? Selfie { get; set; }

    /// <summary>
    /// Optional. Array of encrypted files with translated versions of documents provided by the user; available if requested for “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying <see cref="EncryptedCredentials"/>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Translation)]
    public IEnumerable<PassportFile>? Translation { get; set; }

    /// <summary>
    /// Base64-encoded element hash for using in <see cref="PassportElementErrorUnspecified"/>
    /// </summary>
    [JsonPropertyName(PropertyNames.Hash)]
    public string Hash { get; set; } = null!;
}
