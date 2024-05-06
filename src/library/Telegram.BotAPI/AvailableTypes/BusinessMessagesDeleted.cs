// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object is received when messages are deleted from a connected business account.
/// </summary>
public class BusinessMessagesDeleted
{
    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; } = null!;

    /// <summary>
    /// Information about a chat in the business account. The bot may not have access to the chat or the corresponding user.
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// The list of identifiers of deleted messages in the chat of the business account
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageIds)]
    public IEnumerable<int> MessageIds { get; set; } = null!;
}
