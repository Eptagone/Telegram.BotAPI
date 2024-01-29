// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the arguments of the "AnswerWebAppQuery" method.
/// </summary>
public class AnswerWebAppQueryArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnswerWebAppQueryArgs"/> class.
    /// </summary>
    /// <param name="webAppQueryId">Unique identifier for the query to be answered</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    public AnswerWebAppQueryArgs(string webAppQueryId, InlineQueryResult result)
    {
        this.WebAppQueryId = webAppQueryId ?? throw new ArgumentNullException(nameof(webAppQueryId));
        this.Result = result ?? throw new ArgumentNullException(nameof(result));
    }

    /// <summary>
    /// Unique identifier for the query to be answered
    /// </summary>
    [JsonPropertyName(PropertyNames.WebAppQueryId)]
    public string WebAppQueryId { get; set; }

    /// <summary>
    /// A JSON-serialized object describing the message to be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.Result)]
    public InlineQueryResult Result { get; set; }
}
