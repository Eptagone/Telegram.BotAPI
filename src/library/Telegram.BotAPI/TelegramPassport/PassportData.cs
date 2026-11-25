// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Describes Telegram Passport data shared with the bot by the user.
/// </summary>
public class PassportData
{
    /// <summary>
    /// Array with information shared with the bot about documents and other Telegram Passport elements
    /// </summary>
    [JsonPropertyName(PropertyNames.Data)]
    public IEnumerable<EncryptedPassportElement> Data { get; set; } = null!;

    /// <summary>
    /// Encrypted credentials required to decrypt the data
    /// </summary>
    [JsonPropertyName(PropertyNames.Credentials)]
    public EncryptedCredentials Credentials { get; set; } = null!;
}
