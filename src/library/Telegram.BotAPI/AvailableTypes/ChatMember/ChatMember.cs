// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about one member of a chat. Currently, the following 6 types of chat members are supported:
/// <list type="bullet">
/// <item><description><see cref="ChatMemberOwner"/></description></item>
/// <item><description><see cref="ChatMemberAdministrator"/></description></item>
/// <item><description><see cref="ChatMemberMember"/></description></item>
/// <item><description><see cref="ChatMemberRestricted"/></description></item>
/// <item><description><see cref="ChatMemberLeft"/></description></item>
/// <item><description><see cref="ChatMemberBanned"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(ChatMemberConverter))]
public abstract class ChatMember
{
    /// <summary>
    /// The member's status in the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.Status)]
    public abstract string Status { get; }

    /// <summary>
    /// Information about the user
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;
}
