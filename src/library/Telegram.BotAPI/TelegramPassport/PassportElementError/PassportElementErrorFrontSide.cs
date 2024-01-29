// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue with the front side of a document. The error is considered resolved when the file with the front side of the document changes.
/// </summary>
public class PassportElementErrorFrontSide : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>front_side</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "front_side";

    /// <summary>
    /// The section of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// Base64-encoded hash of the file with the front side of the document
    /// </summary>
    [JsonPropertyName(PropertyNames.FileHash)]
    public string FileHash { get; set; } = null!;
}
