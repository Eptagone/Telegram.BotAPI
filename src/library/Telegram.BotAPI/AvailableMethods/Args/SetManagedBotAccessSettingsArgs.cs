// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetManagedBotAccessSettings" method.
/// </summary>
public class SetManagedBotAccessSettingsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetManagedBotAccessSettingsArgs"/> class.
    /// </summary>
    /// <param name="userId">User identifier of the managed bot whose access settings will be changed</param>
    /// <param name="isAccessRestricted">Pass <em>True</em>, if only selected users can access the bot. The bot's owner can always access it.</param>
    public SetManagedBotAccessSettingsArgs(long userId, bool isAccessRestricted)
    {
        this.UserId = userId;
        this.IsAccessRestricted = isAccessRestricted;
    }

    /// <summary>
    /// User identifier of the managed bot whose access settings will be changed
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if only selected users can access the bot. The bot's owner can always access it.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAccessRestricted)]
    public bool IsAccessRestricted { get; set; }

    /// <summary>
    /// A JSON-serialized list of up to 10 identifiers of users who will have access to the bot in addition to its owner. Ignored if <em>is_access_restricted</em> is false.
    /// </summary>
    [JsonPropertyName(PropertyNames.AddedUserIds)]
    public IEnumerable<int>? AddedUserIds { get; set; }
}
