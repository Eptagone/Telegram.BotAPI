// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games;

/// <summary>
/// This object represents one row of the high scores table for a game.
/// </summary>
public class GameHighScore
{
    /// <summary>
    /// Position in high score table for the game
    /// </summary>
    [JsonPropertyName(PropertyNames.Position)]
    public int Position { get; set; }

    /// <summary>
    /// User
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;

    /// <summary>
    /// Score
    /// </summary>
    [JsonPropertyName(PropertyNames.Score)]
    public int Score { get; set; }
}
