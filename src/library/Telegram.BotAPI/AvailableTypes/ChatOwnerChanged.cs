// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about an ownership change in the chat.
/// </summary>
public class ChatOwnerChanged
{
    /// <summary>
    /// The new owner of the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.NewOwner)]
    public User NewOwner { get; set; } = null!;
}
