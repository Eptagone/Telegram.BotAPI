// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the arguments of the "AnswerInlineQuery" method.
/// </summary>
public class AnswerInlineQueryArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnswerInlineQueryArgs"/> class.
    /// </summary>
    /// <param name="inlineQueryId">Unique identifier for the answered query</param>
    /// <param name="results">A JSON-serialized array of results for the inline query</param>
    public AnswerInlineQueryArgs(string inlineQueryId, IEnumerable<InlineQueryResult> results)
    {
        this.InlineQueryId = inlineQueryId ?? throw new ArgumentNullException(nameof(inlineQueryId));
        this.Results = results ?? throw new ArgumentNullException(nameof(results));
    }

    /// <summary>
    /// Unique identifier for the answered query
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineQueryId)]
    public string InlineQueryId { get; set; }

    /// <summary>
    /// A JSON-serialized array of results for the inline query
    /// </summary>
    [JsonPropertyName(PropertyNames.Results)]
    public IEnumerable<InlineQueryResult> Results { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds that the result of the inline query may be cached on the server. Defaults to 300.
    /// </summary>
    [JsonPropertyName(PropertyNames.CacheTime)]
    public int? CacheTime { get; set; }

    /// <summary>
    /// Pass <em>True</em> if results may be cached on the server side only for the user that sent the query. By default, results may be returned to any user who sends the same query.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPersonal)]
    public bool? IsPersonal { get; set; }

    /// <summary>
    /// Pass the offset that a client should send in the next query with the same text to receive more results. Pass an empty string if there are no more results or if you don't support pagination. Offset length can't exceed 64 bytes.
    /// </summary>
    [JsonPropertyName(PropertyNames.NextOffset)]
    public string? NextOffset { get; set; }

    /// <summary>
    /// A JSON-serialized object describing a button to be shown above inline query results
    /// </summary>
    [JsonPropertyName(PropertyNames.Button)]
    public InlineQueryResultsButton? Button { get; set; }
}
