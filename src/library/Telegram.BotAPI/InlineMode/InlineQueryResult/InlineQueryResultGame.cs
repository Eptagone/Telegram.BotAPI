// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a <see cref="Game"/>.
/// </summary>
public class InlineQueryResultGame : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>game</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "game";

    /// <summary>
    /// Unique identifier for this result, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// Short name of the game
    /// </summary>
    [JsonPropertyName(PropertyNames.GameShortName)]
    public string GameShortName { get; set; } = null!;

    /// <summary>
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
