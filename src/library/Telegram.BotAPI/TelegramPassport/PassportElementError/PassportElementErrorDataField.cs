// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue in one of the data fields that was provided by the user. The error is considered resolved when the field's value changes.
/// </summary>
public class PassportElementErrorDataField : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>data</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "data";

    /// <summary>
    /// The section of the user's Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// Name of the data field which has the error
    /// </summary>
    [JsonPropertyName(PropertyNames.FieldName)]
    public string FieldName { get; set; } = null!;

    /// <summary>
    /// Base64-encoded data hash
    /// </summary>
    [JsonPropertyName(PropertyNames.DataHash)]
    public string DataHash { get; set; } = null!;
}
