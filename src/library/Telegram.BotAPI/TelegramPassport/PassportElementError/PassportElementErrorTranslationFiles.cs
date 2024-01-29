// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue with the translated version of a document. The error is considered resolved when a file with the document translation change.
/// </summary>
public class PassportElementErrorTranslationFiles : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>translation_files</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "translation_files";

    /// <summary>
    /// Type of element of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// List of base64-encoded file hashes
    /// </summary>
    [JsonPropertyName(PropertyNames.FileHashes)]
    public IEnumerable<string> FileHashes { get; set; } = null!;
}
