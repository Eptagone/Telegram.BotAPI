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
    /// Optional. Identifier of the user who will receive the message; required unless the message is sent as an ephemeral reply to a callback query. If omitted, then the parameter <em>chat_id</em> of the method is ignored. If specified together with <em>callback_query_id</em>, then it must be the identifier of the user who pressed the button. Must be omitted for messages sent in chats where the bot isn't a member, unless the message is a reply to an ephemeral message. It is not guaranteed that the user will receive the message, especially if they are offline. See <a href="https://core.telegram.org/bots/api#ephemeral-messages-and-commands">here</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReceiverUserId)]
    public long? ReceiverUserId { get; set; }

    /// <summary>
    /// Optional. Identifier of the callback query which triggered the message, if any. If specified and <em>receiver_user_id</em> is omitted, then the message is sent as an ephemeral reply to the callback query and will be shown only to the user who pressed the button. Ephemeral replies can't be sent to callback queries from messages in channel direct messages chats. The bot must still answer the callback query using <a href="https://core.telegram.org/bots/api#answercallbackquery">answerCallbackQuery</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackQueryId)]
    public string? CallbackQueryId { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if the ephemeral message must be shown in place of the original message. Must be <em>False</em> for callback queries from ephemeral messages, which must be edited using regular <em>editEphemeralMessage…</em> methods.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplaceCallbackQueryMessage)]
    public bool? ReplaceCallbackQueryMessage { get; set; }
}
