// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a <a href="https://core.telegram.org/bots/api#inlinequeryresult">result</a> of an inline query that was chosen by the user and sent to their chat partner.
/// </summary>
public class ChosenInlineResult
{
    /// <summary>
    /// The unique identifier for the result that was chosen
    /// </summary>
    [JsonPropertyName(PropertyNames.ResultId)]
    public string ResultId { get; set; } = null!;

    /// <summary>
    /// The user that chose the result
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User From { get; set; } = null!;

    /// <summary>
    /// Optional. Sender location, only for bots that require user location
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location? Location { get; set; }

    /// <summary>
    /// Optional. Identifier of the sent inline message. Available only if there is an <a href="https://core.telegram.org/bots/api#inlinekeyboardmarkup">inline keyboard</a> attached to the message. Will be also received in <a href="https://core.telegram.org/bots/api#callbackquery">callback queries</a> and can be used to <a href="https://core.telegram.org/bots/api#updating-messages">edit</a> the message.
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }

    /// <summary>
    /// The query that was used to obtain the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Query)]
    public string Query { get; set; } = null!;
}
