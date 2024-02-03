// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents type of a poll, which is allowed to be created and sent when the corresponding button is pressed.
/// </summary>
public class KeyboardButtonPollType
{
    /// <summary>
    /// Optional. If <em>quiz</em> is passed, the user will be allowed to create only polls in the quiz mode. If <em>regular</em> is passed, only regular polls will be allowed. Otherwise, the user will be allowed to create a poll of any type.
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public string? Type { get; set; }
}
