// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue with one of the files that constitute the translation of a document. The error is considered resolved when the file changes.
/// </summary>
public class PassportElementErrorTranslationFile : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>translation_file</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "translation_file";

    /// <summary>
    /// Type of element of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// Base64-encoded file hash
    /// </summary>
    [JsonPropertyName(PropertyNames.FileHash)]
    public string FileHash { get; set; } = null!;
}
