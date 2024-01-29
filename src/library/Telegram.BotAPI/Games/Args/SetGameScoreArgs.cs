// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Games;

/// <summary>
/// Represents the arguments of the "SetGameScore" method.
/// </summary>
public class SetGameScoreArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetGameScoreArgs"/> class.
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <param name="score">New score, must be non-negative</param>
    public SetGameScoreArgs(long userId, int score)
    {
        this.UserId = userId;
        this.Score = score;
    }

    /// <summary>
    /// User identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// New score, must be non-negative
    /// </summary>
    [JsonPropertyName(PropertyNames.Score)]
    public int Score { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters
    /// </summary>
    [JsonPropertyName(PropertyNames.Force)]
    public bool? Force { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the game message should not be automatically edited to include the current scoreboard
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableEditMessage)]
    public bool? DisableEditMessage { get; set; }

    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public long? ChatId { get; set; }

    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Identifier of the sent message
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int? MessageId { get; set; }

    /// <summary>
    /// Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }
}
