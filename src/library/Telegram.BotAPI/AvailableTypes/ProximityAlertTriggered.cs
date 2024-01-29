// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the content of a service message, sent whenever a user in the chat triggers a proximity alert set by another user.
/// </summary>
public class ProximityAlertTriggered
{
    /// <summary>
    /// User that triggered the alert
    /// </summary>
    [JsonPropertyName(PropertyNames.Traveler)]
    public User Traveler { get; set; } = null!;

    /// <summary>
    /// User that set the alert
    /// </summary>
    [JsonPropertyName(PropertyNames.Watcher)]
    public User Watcher { get; set; } = null!;

    /// <summary>
    /// The distance between the users
    /// </summary>
    [JsonPropertyName(PropertyNames.Distance)]
    public int Distance { get; set; }
}
