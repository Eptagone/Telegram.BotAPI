// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// This object represents an error in the Telegram Passport element which was submitted that should be resolved by the user. It should be one of:
/// <list type="bullet">
/// <item><description><see cref="PassportElementErrorDataField"/></description></item>
/// <item><description><see cref="PassportElementErrorFrontSide"/></description></item>
/// <item><description><see cref="PassportElementErrorReverseSide"/></description></item>
/// <item><description><see cref="PassportElementErrorSelfie"/></description></item>
/// <item><description><see cref="PassportElementErrorFile"/></description></item>
/// <item><description><see cref="PassportElementErrorFiles"/></description></item>
/// <item><description><see cref="PassportElementErrorTranslationFile"/></description></item>
/// <item><description><see cref="PassportElementErrorTranslationFiles"/></description></item>
/// <item><description><see cref="PassportElementErrorUnspecified"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(PassportElementErrorConverter))]
public abstract class PassportElementError
{
    /// <summary>
    /// Error source
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public abstract string Source { get; }

    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    [JsonPropertyName(PropertyNames.Message)]
    public string Message { get; set; } = null!;
}
