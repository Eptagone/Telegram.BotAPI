// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a phone contact.
/// </summary>
public class Contact
{
    /// <summary>
    /// Contact's phone number
    /// </summary>
    [JsonPropertyName(PropertyNames.PhoneNumber)]
    public string PhoneNumber { get; set; } = null!;

    /// <summary>
    /// Contact's first name
    /// </summary>
    [JsonPropertyName(PropertyNames.FirstName)]
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Optional. Contact's last name
    /// </summary>
    [JsonPropertyName(PropertyNames.LastName)]
    public string? LastName { get; set; }

    /// <summary>
    /// Optional. Contact's user identifier in Telegram. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long? UserId { get; set; }

    /// <summary>
    /// Optional. Additional data about the contact in the form of a <a href="https://en.wikipedia.org/wiki/VCard">vCard</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Vcard)]
    public string? Vcard { get; set; }
}
