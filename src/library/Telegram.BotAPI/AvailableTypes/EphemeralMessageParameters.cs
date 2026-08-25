// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// No description available
/// </summary>
public class EphemeralMessageParameters
{
    /// <summary>
    /// Identifier of the user who will receive the message. It is not guaranteed that the user will receive the message, especially if they are offline. See <a href="https://core.telegram.org/bots/api#ephemeral-messages-and-commands">here</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReceiverUserId)]
    public long ReceiverUserId { get; set; }

    /// <summary>
    /// Optional. Identifier of the callback query which triggered the message, if any
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackQueryId)]
    public string? CallbackQueryId { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if the ephemeral message must be shown in place of the original message. Must be <em>False</em> for callback queries from ephemeral messages, which must be edited using regular <em>editEphemeralMessage…</em> methods.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplaceCallbackQueryMessage)]
    public bool? ReplaceCallbackQueryMessage { get; set; }
}
