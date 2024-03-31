// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the users whose identifiers were shared with the bot using a <see cref="KeyboardButtonRequestUsers"/> button.
/// </summary>
public class UsersShared
{
    /// <summary>
    /// Identifier of the request
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestId)]
    public int RequestId { get; set; }

    /// <summary>
    /// Information about users shared with the bot.
    /// </summary>
    [JsonPropertyName(PropertyNames.Users)]
    public IEnumerable<SharedUser> Users { get; set; } = null!;
}
