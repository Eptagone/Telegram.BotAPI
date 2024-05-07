// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a <a href="https://core.telegram.org/bots/features#keyboards">custom keyboard</a> with reply options (see <a href="https://core.telegram.org/bots/features#keyboards">Introduction to bots</a> for details and examples). Not supported in channels and for messages sent on behalf of a Telegram Business account.
/// </summary>
public class ReplyKeyboardMarkup : ReplyMarkup
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReplyKeyboardMarkup"/> class.
    /// </summary>
    /// <param name="keyboard">Array of button rows, each represented by an Array of <see cref="KeyboardButton"/> objects</param>
    public ReplyKeyboardMarkup(IEnumerable<IEnumerable<KeyboardButton>> keyboard)
    {
        this.Keyboard = keyboard ?? throw new ArgumentNullException(nameof(keyboard));
    }

    /// <summary>
    /// Array of button rows, each represented by an Array of <see cref="KeyboardButton"/> objects
    /// </summary>
    [JsonPropertyName(PropertyNames.Keyboard)]
    public IEnumerable<IEnumerable<KeyboardButton>> Keyboard { get; set; }

    /// <summary>
    /// Optional. Requests clients to always show the keyboard when the regular keyboard is hidden. Defaults to <em>false</em>, in which case the custom keyboard can be hidden and opened with a keyboard icon.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPersistent)]
    public bool? IsPersistent { get; set; }

    /// <summary>
    /// Optional. Requests clients to resize the keyboard vertically for optimal fit (e.g., make the keyboard smaller if there are just two rows of buttons). Defaults to <em>false</em>, in which case the custom keyboard is always of the same height as the app's standard keyboard.
    /// </summary>
    [JsonPropertyName(PropertyNames.ResizeKeyboard)]
    public bool? ResizeKeyboard { get; set; }

    /// <summary>
    /// Optional. Requests clients to hide the keyboard as soon as it's been used. The keyboard will still be available, but clients will automatically display the usual letter-keyboard in the chat - the user can press a special button in the input field to see the custom keyboard again. Defaults to <em>false</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.OneTimeKeyboard)]
    public bool? OneTimeKeyboard { get; set; }

    /// <summary>
    /// Optional. The placeholder to be shown in the input field when the keyboard is active; 1-64 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.InputFieldPlaceholder)]
    public string? InputFieldPlaceholder { get; set; }

    /// <summary>
    /// Optional. Use this parameter if you want to show the keyboard to specific users only. Targets: 1) users that are @mentioned in the <em>text</em> of the <see cref="Message"/> object; 2) if the bot's message is a reply to a message in the same chat and forum topic, sender of the original message.<br /><br /><em>Example:</em> A user requests to change the bot's language, bot replies to the request with a keyboard to select the new language. Other users in the group don't see the keyboard.
    /// </summary>
    [JsonPropertyName(PropertyNames.Selective)]
    public bool? Selective { get; set; }
}
