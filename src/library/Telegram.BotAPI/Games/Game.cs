// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games;

/// <summary>
/// This object represents a game. Use BotFather to create and edit games, their short names will act as unique identifiers.
/// </summary>
public class Game
{
    /// <summary>
    /// Title of the game
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Description of the game
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string Description { get; set; } = null!;

    /// <summary>
    /// Photo that will be displayed in the game message in chats.
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public IEnumerable<PhotoSize> Photo { get; set; } = null!;

    /// <summary>
    /// Optional. Brief description of the game or high scores included in the game message. Can be automatically edited to include current high scores for the game when the bot calls <a href="https://core.telegram.org/bots/api#setgamescore">setGameScore</a>, or manually edited using <a href="https://core.telegram.org/bots/api#editmessagetext">editMessageText</a>. 0-4096 characters.
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string? Text { get; set; }

    /// <summary>
    /// Optional. Special entities that appear in <em>text</em>, such as usernames, URLs, bot commands, etc.
    /// </summary>
    [JsonPropertyName(PropertyNames.TextEntities)]
    public IEnumerable<MessageEntity>? TextEntities { get; set; }

    /// <summary>
    /// Optional. Animation that will be displayed in the game message in chats. Upload via <a href="https://t.me/botfather">BotFather</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Animation)]
    public Animation? Animation { get; set; }
}
