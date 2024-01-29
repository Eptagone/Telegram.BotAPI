// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Represents an issue in an unspecified place. The error is considered resolved when new data is added.
/// </summary>
public class PassportElementErrorUnspecified : PassportElementError
{
    /// <summary>
    /// Error source, must be <em>unspecified</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public override string Source => "unspecified";

    /// <summary>
    /// Type of element of the user's Telegram Passport which has the issue
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type { get; set; } = null!;

    /// <summary>
    /// Base64-encoded element hash
    /// </summary>
    [JsonPropertyName(PropertyNames.ElementHash)]
    public string ElementHash { get; set; } = null!;
}
