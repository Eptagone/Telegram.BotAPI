// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the access settings of a bot.
/// </summary>
public class BotAccessSettings
{
    /// <summary>
    /// <em>True</em>, if only selected users can access the bot. The bot's owner can always access it.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAccessRestricted)]
    public bool IsAccessRestricted { get; set; }

    /// <summary>
    /// Optional. The list of other users who have access to the bot if the access is restricted
    /// </summary>
    [JsonPropertyName(PropertyNames.AddedUsers)]
    public IEnumerable<User>? AddedUsers { get; set; }
}
