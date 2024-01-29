// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue with a list of scans. The error is considered resolved when the list of files containing the scans changes.
/// </summary>
public class PassportElementErrorFiles : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>files</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "files";

    /// <summary>
    /// The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// List of base64-encoded file hashes
    /// </summary>
    [JsonPropertyName(PropertyNames.FileHashes)]
    public IEnumerable<string> FileHashes { get; set; } = null!;
}
