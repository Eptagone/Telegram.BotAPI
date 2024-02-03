// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#inputmessagecontent">content</a> of a contact message to be sent as the result of an inline query.
/// </summary>
public class InputContactMessageContent : InputMessageContent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputContactMessageContent"/> class.
    /// </summary>
    /// <param name="phoneNumber">Contact's phone number</param>
    /// <param name="firstName">Contact's first name</param>
    public InputContactMessageContent(string phoneNumber, string firstName)
    {
        this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
        this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
    }

    /// <summary>
    /// Contact's phone number
    /// </summary>
    [JsonPropertyName(PropertyNames.PhoneNumber)]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Contact's first name
    /// </summary>
    [JsonPropertyName(PropertyNames.FirstName)]
    public string FirstName { get; set; }

    /// <summary>
    /// Optional. Contact's last name
    /// </summary>
    [JsonPropertyName(PropertyNames.LastName)]
    public string? LastName { get; set; }

    /// <summary>
    /// Optional. Additional data about the contact in the form of a <a href="https://en.wikipedia.org/wiki/VCard">vCard</a>, 0-2048 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Vcard)]
    public string? Vcard { get; set; }
}
