// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a> that appears right next to the message it belongs to.
/// </summary>
public class InlineKeyboardMarkup : ReplyMarkup
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InlineKeyboardMarkup"/> class.
    /// </summary>
    /// <param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects</param>
    public InlineKeyboardMarkup(IEnumerable<IEnumerable<InlineKeyboardButton>> inlineKeyboard)
    {
        this.InlineKeyboard = inlineKeyboard ?? throw new ArgumentNullException(nameof(inlineKeyboard));
    }

    /// <summary>
    /// Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineKeyboard)]
    public IEnumerable<IEnumerable<InlineKeyboardButton>> InlineKeyboard { get; set; }
}
