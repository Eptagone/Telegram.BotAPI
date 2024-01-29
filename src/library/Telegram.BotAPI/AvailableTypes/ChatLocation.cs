// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a location to which a chat is connected.
/// </summary>
public class ChatLocation
{
    /// <summary>
    /// The location to which the supergroup is connected. Can't be a live location.
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location Location { get; set; } = null!;

    /// <summary>
    /// Location address; 1-64 characters, as defined by the chat owner
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; } = null!;
}
