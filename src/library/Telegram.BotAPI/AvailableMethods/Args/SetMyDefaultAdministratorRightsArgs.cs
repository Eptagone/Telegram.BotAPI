// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetMyDefaultAdministratorRights" method.
/// </summary>
public class SetMyDefaultAdministratorRightsArgs
{
    /// <summary>
    /// A JSON-serialized object describing new default administrator rights. If not specified, the default administrator rights will be cleared.
    /// </summary>
    [JsonPropertyName(PropertyNames.Rights)]
    public ChatAdministratorRights? Rights { get; set; }

    /// <summary>
    /// Pass <em>True</em> to change the default administrator rights of the bot in channels. Otherwise, the default administrator rights of the bot for groups and supergroups will be changed.
    /// </summary>
    [JsonPropertyName(PropertyNames.ForChannels)]
    public bool? ForChannels { get; set; }
}
