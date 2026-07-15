// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a chat being added to a community.
/// </summary>
public class CommunityChatAdded
{
    /// <summary>
    /// The new community to which the chat belongs
    /// </summary>
    [JsonPropertyName(PropertyNames.Community)]
    public Community Community { get; set; } = null!;
}
