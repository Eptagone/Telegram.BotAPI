// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "GetBusinessAccountGifts" method.
/// </summary>
public class GetBusinessAccountGiftsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetBusinessAccountGiftsArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    public GetBusinessAccountGiftsArgs(string businessConnectionId)
    {
        this.BusinessConnectionId =
            businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
    }

    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that aren't saved to the account's profile page
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeUnsaved)]
    public bool? ExcludeUnsaved { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that are saved to the account's profile page
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeSaved)]
    public bool? ExcludeSaved { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that can be purchased an unlimited number of times
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeUnlimited)]
    public bool? ExcludeUnlimited { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that can be purchased a limited number of times
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeLimited)]
    public bool? ExcludeLimited { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude unique gifts
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeUnique)]
    public bool? ExcludeUnique { get; set; }

    /// <summary>
    /// Pass <em>True</em> to sort results by gift price instead of send date. Sorting is applied before pagination.
    /// </summary>
    [JsonPropertyName(PropertyNames.SortByPrice)]
    public bool? SortByPrice { get; set; }

    /// <summary>
    /// Offset of the first entry to return as received from the previous request; use empty string to get the first chunk of results
    /// </summary>
    [JsonPropertyName(PropertyNames.Offset)]
    public string? Offset { get; set; }

    /// <summary>
    /// The maximum number of gifts to be returned; 1-100. Defaults to 100
    /// </summary>
    [JsonPropertyName(PropertyNames.Limit)]
    public int? Limit { get; set; }
}
