// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a Telegram user or bot.
/// </summary>
public class User
{
    /// <summary>
    /// Unique identifier for this user or bot. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public long Id { get; set; }

    /// <summary>
    /// <em>True</em>, if this user is a bot
    /// </summary>
    [JsonPropertyName(PropertyNames.IsBot)]
    public bool IsBot { get; set; }

    /// <summary>
    /// User's or bot's first name
    /// </summary>
    [JsonPropertyName(PropertyNames.FirstName)]
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Optional. User's or bot's last name
    /// </summary>
    [JsonPropertyName(PropertyNames.LastName)]
    public string? LastName { get; set; }

    /// <summary>
    /// Optional. User's or bot's username
    /// </summary>
    [JsonPropertyName(PropertyNames.Username)]
    public string? Username { get; set; }

    /// <summary>
    /// Optional. <a href="https://en.wikipedia.org/wiki/IETF_language_tag">IETF language tag</a> of the user's language
    /// </summary>
    [JsonPropertyName(PropertyNames.LanguageCode)]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if this user is a Telegram Premium user
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPremium)]
    public bool? IsPremium { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if this user added the bot to the attachment menu
    /// </summary>
    [JsonPropertyName(PropertyNames.AddedToAttachmentMenu)]
    public bool? AddedToAttachmentMenu { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the bot can be invited to groups. Returned only in <a href="https://core.telegram.org/bots/api#getme">getMe</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.CanJoinGroups)]
    public bool? CanJoinGroups { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if <a href="https://core.telegram.org/bots/features#privacy-mode">privacy mode</a> is disabled for the bot. Returned only in <a href="https://core.telegram.org/bots/api#getme">getMe</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.CanReadAllGroupMessages)]
    public bool? CanReadAllGroupMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the bot supports inline queries. Returned only in <a href="https://core.telegram.org/bots/api#getme">getMe</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsInlineQueries)]
    public bool? SupportsInlineQueries { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the bot can be connected to a Telegram Business account to receive its messages. Returned only in <a href="https://core.telegram.org/bots/api#getme">getMe</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.CanConnectToBusiness)]
    public bool? CanConnectToBusiness { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the bot has a main Web App. Returned only in <a href="https://core.telegram.org/bots/api#getme">getMe</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.HasMainWebApp)]
    public bool? HasMainWebApp { get; set; }
}
