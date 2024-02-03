// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent to a channel chat.
/// </summary>
public class MessageOriginChannel : MessageOrigin
{
    /// <summary>
    /// Type of the message origin, always “channel”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "channel";

    /// <summary>
    /// Channel chat to which the message was originally sent
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Unique message identifier inside the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// Optional. Signature of the original post author
    /// </summary>
    [JsonPropertyName(PropertyNames.AuthorSignature)]
    public string? AuthorSignature { get; set; }
}
