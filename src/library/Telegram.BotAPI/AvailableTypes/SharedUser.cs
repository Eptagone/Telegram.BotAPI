// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about a user that was shared with the bot using a <see cref="KeyboardButtonRequestUsers"/> button.
/// </summary>
public class SharedUser
{
    /// <summary>
    /// Identifier of the shared user. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so 64-bit integers or double-precision float types are safe for storing these identifiers. The bot may not have access to the user and could be unable to use this identifier, unless the user is already known to the bot by some other means.
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Optional. First name of the user, if the name was requested by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.FirstName)]
    public string? FirstName { get; set; }

    /// <summary>
    /// Optional. Last name of the user, if the name was requested by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.LastName)]
    public string? LastName { get; set; }

    /// <summary>
    /// Optional. Username of the user, if the username was requested by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.Username)]
    public string? Username { get; set; }

    /// <summary>
    /// Optional. Available sizes of the chat photo, if the photo was requested by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public IEnumerable<PhotoSize>? Photo { get; set; }
}
