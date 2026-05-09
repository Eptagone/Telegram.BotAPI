// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SavePreparedKeyboardButton" method.
/// </summary>
public class SavePreparedKeyboardButtonArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SavePreparedKeyboardButtonArgs"/> class.
    /// </summary>
    /// <param name="userId">Unique identifier of the target user that can use the button</param>
    /// <param name="button">A JSON-serialized object describing the button to be saved. The button must be of the type <em>request_users</em>, <em>request_chat</em>, or <em>request_managed_bot</em></param>
    public SavePreparedKeyboardButtonArgs(long userId, KeyboardButton button)
    {
        this.UserId = userId;
        this.Button = button ?? throw new ArgumentNullException(nameof(button));
    }

    /// <summary>
    /// Unique identifier of the target user that can use the button
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// A JSON-serialized object describing the button to be saved. The button must be of the type <em>request_users</em>, <em>request_chat</em>, or <em>request_managed_bot</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Button)]
    public KeyboardButton Button { get; set; }
}
