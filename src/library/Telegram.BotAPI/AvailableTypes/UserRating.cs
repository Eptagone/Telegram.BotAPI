// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the rating of a user based on their Telegram Star spendings.
/// </summary>
public class UserRating
{
    /// <summary>
    /// Current level of the user, indicating their reliability when purchasing digital goods and services. A higher level suggests a more trustworthy customer; a negative level is likely reason for concern.
    /// </summary>
    [JsonPropertyName(PropertyNames.Level)]
    public int Level { get; set; }

    /// <summary>
    /// Numerical value of the user's rating; the higher the rating, the better
    /// </summary>
    [JsonPropertyName(PropertyNames.Rating)]
    public int Rating { get; set; }

    /// <summary>
    /// The rating value required to get the current level
    /// </summary>
    [JsonPropertyName(PropertyNames.CurrentLevelRating)]
    public int CurrentLevelRating { get; set; }

    /// <summary>
    /// Optional. The rating value required to get to the next level; omitted if the maximum level was reached
    /// </summary>
    [JsonPropertyName(PropertyNames.NextLevelRating)]
    public int? NextLevelRating { get; set; }
}
