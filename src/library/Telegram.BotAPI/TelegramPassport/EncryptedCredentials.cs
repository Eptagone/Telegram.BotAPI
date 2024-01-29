// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Describes data required for decrypting and authenticating <see cref="EncryptedPassportElement"/>. See the <a href="https://core.telegram.org/passport#receiving-information">Telegram Passport Documentation</a> for a complete description of the data decryption and authentication processes.
/// </summary>
public class EncryptedCredentials
{
    /// <summary>
    /// Base64-encoded encrypted JSON-serialized data with unique user's payload, data hashes and secrets required for <see cref="EncryptedPassportElement"/> decryption and authentication
    /// </summary>
    [JsonPropertyName(PropertyNames.Data)]
    public string Data { get; set; } = null!;

    /// <summary>
    /// Base64-encoded data hash for data authentication
    /// </summary>
    [JsonPropertyName(PropertyNames.Hash)]
    public string Hash { get; set; } = null!;

    /// <summary>
    /// Base64-encoded secret, encrypted with the bot's public RSA key, required for data decryption
    /// </summary>
    [JsonPropertyName(PropertyNames.Secret)]
    public string Secret { get; set; } = null!;
}
