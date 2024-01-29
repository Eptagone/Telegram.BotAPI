// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Represents the arguments of the "AnswerShippingQuery" method.
/// </summary>
public class AnswerShippingQueryArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnswerShippingQueryArgs"/> class.
    /// </summary>
    /// <param name="shippingQueryId">Unique identifier for the query to be answered</param>
    /// <param name="ok">Pass <em>True</em> if delivery to the specified address is possible and <em>False</em> if there are any problems (for example, if delivery to the specified address is not possible)</param>
    public AnswerShippingQueryArgs(string shippingQueryId, bool ok)
    {
        this.ShippingQueryId = shippingQueryId ?? throw new ArgumentNullException(nameof(shippingQueryId));
        this.Ok = ok;
    }

    /// <summary>
    /// Unique identifier for the query to be answered
    /// </summary>
    [JsonPropertyName(PropertyNames.ShippingQueryId)]
    public string ShippingQueryId { get; set; }

    /// <summary>
    /// Pass <em>True</em> if delivery to the specified address is possible and <em>False</em> if there are any problems (for example, if delivery to the specified address is not possible)
    /// </summary>
    [JsonPropertyName(PropertyNames.Ok)]
    public bool Ok { get; set; }

    /// <summary>
    /// Required if <em>ok</em> is <em>True</em>. A JSON-serialized array of available shipping options.
    /// </summary>
    [JsonPropertyName(PropertyNames.ShippingOptions)]
    public IEnumerable<ShippingOption>? ShippingOptions { get; set; }

    /// <summary>
    /// Required if <em>ok</em> is <em>False</em>. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.
    /// </summary>
    [JsonPropertyName(PropertyNames.ErrorMessage)]
    public string? ErrorMessage { get; set; }
}
