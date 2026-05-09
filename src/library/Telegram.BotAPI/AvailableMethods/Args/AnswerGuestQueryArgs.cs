// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.InlineMode;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "AnswerGuestQuery" method.
/// </summary>
public class AnswerGuestQueryArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnswerGuestQueryArgs"/> class.
    /// </summary>
    /// <param name="guestQueryId">Unique identifier for the query to be answered</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    public AnswerGuestQueryArgs(string guestQueryId, InlineQueryResult result)
    {
        this.GuestQueryId = guestQueryId ?? throw new ArgumentNullException(nameof(guestQueryId));
        this.Result = result ?? throw new ArgumentNullException(nameof(result));
    }

    /// <summary>
    /// Unique identifier for the query to be answered
    /// </summary>
    [JsonPropertyName(PropertyNames.GuestQueryId)]
    public string GuestQueryId { get; set; }

    /// <summary>
    /// A JSON-serialized object describing the message to be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.Result)]
    public InlineQueryResult Result { get; set; }
}
