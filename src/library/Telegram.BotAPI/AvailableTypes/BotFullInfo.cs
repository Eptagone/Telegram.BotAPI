// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains full information about the bot itself.
/// </summary>
public class BotFullInfo
{
    /// <summary>
    /// Unique identifier for this bot. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type is safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public long Id { get; set; }

    /// <summary>
    /// Always <em>True</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.IsBot)]
    public bool IsBot => true;

    /// <summary>
    /// Bot's first name
    /// </summary>
    [JsonPropertyName(PropertyNames.FirstName)]
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Optional. Bot's username
    /// </summary>
    [JsonPropertyName(PropertyNames.Username)]
    public string? Username { get; set; }

    /// <summary>
    /// Optional. If non-empty, the list of all <a href="https://telegram.org/blog/topics-in-groups-collectible-usernames#collectible-usernames">active usernames</a> of the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.ActiveUsernames)]
    public IEnumerable<string>? ActiveUsernames { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot can be added to groups
    /// </summary>
    [JsonPropertyName(PropertyNames.CanJoinGroups)]
    public bool CanJoinGroups { get; set; }

    /// <summary>
    /// <em>True</em>, if <a href="https://core.telegram.org/bots/features#privacy-mode">privacy mode</a> is disabled for the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.CanReadAllGroupMessages)]
    public bool CanReadAllGroupMessages { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot supports guest queries from chats it is not a member of
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsGuestQueries)]
    public bool SupportsGuestQueries { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot supports inline queries
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsInlineQueries)]
    public bool SupportsInlineQueries { get; set; }

    /// <summary>
    /// Optional. Placeholder for inline queries, which is shown in the input field after the bot's username; omitted if the default placeholder is used
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineQueryPlaceholder)]
    public string? InlineQueryPlaceholder { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot requests the location of the user with every inline query
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedsInlineQueryLocation)]
    public bool NeedsInlineQueryLocation { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot can be connected to a user account to manage it
    /// </summary>
    [JsonPropertyName(PropertyNames.CanConnectToBusiness)]
    public bool CanConnectToBusiness { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot has a main Web App
    /// </summary>
    [JsonPropertyName(PropertyNames.HasMainWebApp)]
    public bool HasMainWebApp { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot has forum topic mode enabled in private chats
    /// </summary>
    [JsonPropertyName(PropertyNames.HasTopicsEnabled)]
    public bool HasTopicsEnabled { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot allows users to create and delete topics in private chats
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowsUsersToCreateTopics)]
    public bool AllowsUsersToCreateTopics { get; set; }

    /// <summary>
    /// <em>True</em>, if topics in private chats with the bot are shown in a sidebar
    /// </summary>
    [JsonPropertyName(PropertyNames.HasTopicSidebar)]
    public bool HasTopicSidebar { get; set; }

    /// <summary>
    /// <em>True</em>, if other bots can be created to be controlled by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageBots)]
    public bool CanManageBots { get; set; }

    /// <summary>
    /// <em>True</em>, if the bot supports join request queries and can be assigned to process them
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsJoinRequestQueries)]
    public bool SupportsJoinRequestQueries { get; set; }
}
