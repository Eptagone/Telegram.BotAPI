// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about the chat owner leaving the chat.
/// </summary>
public class ChatOwnerLeft
{
    /// <summary>
    /// Optional. The user which will be the new owner of the chat if the previous owner does not return to the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.NewOwner)]
    public User? NewOwner { get; set; }
}
