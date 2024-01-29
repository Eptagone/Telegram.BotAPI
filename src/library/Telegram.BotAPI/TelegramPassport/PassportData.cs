// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// Describes Telegram Passport data shared with the bot by the user.
/// </summary>
public class PassportData
{
    /// <summary>
    /// Array with information about documents and other Telegram Passport elements that was shared with the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.Data)]
    public IEnumerable<EncryptedPassportElement> Data { get; set; } = null!;

    /// <summary>
    /// Encrypted credentials required to decrypt the data
    /// </summary>
    [JsonPropertyName(PropertyNames.Credentials)]
    public EncryptedCredentials Credentials { get; set; } = null!;
}
