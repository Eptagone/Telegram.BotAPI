// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent on behalf of a chat to a group chat.
/// </summary>
public class MessageOriginChat : MessageOrigin
{
    /// <summary>
    /// Type of the message origin, always “chat”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "chat";

    /// <summary>
    /// Chat that sent the message originally
    /// </summary>
    [JsonPropertyName(PropertyNames.SenderChat)]
    public Chat SenderChat { get; set; } = null!;

    /// <summary>
    /// Optional. For messages originally sent by an anonymous chat administrator, original message author signature
    /// </summary>
    [JsonPropertyName(PropertyNames.AuthorSignature)]
    public string? AuthorSignature { get; set; }
}
