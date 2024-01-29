// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about new members invited to a video chat.
/// </summary>
public class VideoChatParticipantsInvited
{
    /// <summary>
    /// New members that were invited to the video chat
    /// </summary>
    [JsonPropertyName(PropertyNames.Users)]
    public IEnumerable<User> Users { get; set; } = null!;
}
