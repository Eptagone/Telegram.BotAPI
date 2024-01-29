// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object represents one shipping option.
/// </summary>
public class ShippingOption
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShippingOption"/> class.
    /// </summary>
    /// <param name="id">Shipping option identifier</param>
    /// <param name="title">Option title</param>
    /// <param name="prices">List of price portions</param>
    public ShippingOption(string id, string title, IEnumerable<LabeledPrice> prices)
    {
        this.Id = id ?? throw new ArgumentNullException(nameof(id));
        this.Title = title ?? throw new ArgumentNullException(nameof(title));
        this.Prices = prices ?? throw new ArgumentNullException(nameof(prices));
    }

    /// <summary>
    /// Shipping option identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; }

    /// <summary>
    /// Option title
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; }

    /// <summary>
    /// List of price portions
    /// </summary>
    [JsonPropertyName(PropertyNames.Prices)]
    public IEnumerable<LabeledPrice> Prices { get; set; }
}
