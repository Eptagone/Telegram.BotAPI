// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue with the reverse side of a document. The error is considered resolved when the file with reverse side of the document changes.
/// </summary>
public class PassportElementErrorReverseSide : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>reverse_side</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "reverse_side";

    /// <summary>
    /// The section of the user's Telegram Passport which has the issue, one of “driver_license”, “identity_card”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// Base64-encoded hash of the file with the reverse side of the document
    /// </summary>
    [JsonPropertyName(PropertyNames.FileHash)]
    public string FileHash { get; set; } = null!;
}
