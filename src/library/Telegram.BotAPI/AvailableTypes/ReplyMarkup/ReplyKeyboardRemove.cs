// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Upon receiving a message with this object, Telegram clients will remove the current custom keyboard and display the default letter-keyboard. By default, custom keyboards are displayed until a new keyboard is sent by a bot. An exception is made for one-time keyboards that are hidden immediately after the user presses a button (see <see cref="ReplyKeyboardMarkup"/>). Not supported in channels and for messages sent on behalf of a Telegram Business account.
/// </summary>
public class ReplyKeyboardRemove : ReplyMarkup
{
    /// <summary>
    /// Requests clients to remove the custom keyboard (user will not be able to summon this keyboard; if you want to hide the keyboard from sight but keep it accessible, use <em>one_time_keyboard</em> in <see cref="ReplyKeyboardMarkup"/>)
    /// </summary>
    [JsonPropertyName(PropertyNames.RemoveKeyboard)]
    public bool RemoveKeyboard => true;

    /// <summary>
    /// Optional. Use this parameter if you want to remove the keyboard for specific users only. Targets: 1) users that are @mentioned in the <em>text</em> of the <see cref="Message"/> object; 2) if the bot's message is a reply to a message in the same chat and forum topic, sender of the original message.<br /><br /><em>Example:</em> A user votes in a poll, bot returns confirmation message in reply to the vote and removes the keyboard for that user, while still showing the keyboard with poll options to users who haven't voted yet.
    /// </summary>
    [JsonPropertyName(PropertyNames.Selective)]
    public bool? Selective { get; set; }
}
