// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a unique gift that was sent or received.
/// </summary>
public class UniqueGiftInfo
{
    /// <summary>
    /// Information about the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public UniqueGift Gift { get; set; } = null!;

    /// <summary>
    /// Origin of the gift. Currently, either “upgrade” for gifts upgraded from regular gifts, “transfer” for gifts transferred from other users or channels, or “resale” for gifts bought from other users
    /// </summary>
    [JsonPropertyName(PropertyNames.Origin)]
    public string Origin { get; set; } = null!;

    /// <summary>
    /// Optional. For gifts bought from other users, the price paid for the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.LastResaleStarCount)]
    public int? LastResaleStarCount { get; set; }

    /// <summary>
    /// Optional. Unique identifier of the received gift for the bot; only present for gifts received on behalf of business accounts
    /// </summary>
    [JsonPropertyName(PropertyNames.OwnedGiftId)]
    public string? OwnedGiftId { get; set; }

    /// <summary>
    /// Optional. Number of Telegram Stars that must be paid to transfer the gift; omitted if the bot cannot transfer the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.TransferStarCount)]
    public int? TransferStarCount { get; set; }

    /// <summary>
    /// Optional. Point in time (Unix timestamp) when the gift can be transferred. If it is in the past, then the gift can be transferred now
    /// </summary>
    [JsonPropertyName(PropertyNames.NextTransferDate)]
    public int? NextTransferDate { get; set; }
}
