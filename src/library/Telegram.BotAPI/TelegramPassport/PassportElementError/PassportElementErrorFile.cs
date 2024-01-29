// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue with a document scan. The error is considered resolved when the file with the document scan changes.
/// </summary>
public class PassportElementErrorFile : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>file</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "file";

    /// <summary>
    /// The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// Base64-encoded file hash
    /// </summary>
    [JsonPropertyName(PropertyNames.FileHash)]
    public string FileHash { get; set; } = null!;
}
