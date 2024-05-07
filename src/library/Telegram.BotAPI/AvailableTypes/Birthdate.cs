// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the birthdate of a user.
/// </summary>
public class Birthdate
{
    /// <summary>
    /// Day of the user's birth; 1-31
    /// </summary>
    [JsonPropertyName(PropertyNames.Day)]
    public int Day { get; set; }

    /// <summary>
    /// Month of the user's birth; 1-12
    /// </summary>
    [JsonPropertyName(PropertyNames.Month)]
    public int Month { get; set; }

    /// <summary>
    /// Optional. Year of the user's birth
    /// </summary>
    [JsonPropertyName(PropertyNames.Year)]
    public int? Year { get; set; }
}
