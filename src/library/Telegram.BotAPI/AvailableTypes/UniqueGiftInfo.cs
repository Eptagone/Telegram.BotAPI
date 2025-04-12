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
    /// Origin of the gift. Currently, either “upgrade” or “transfer”
    /// </summary>
    [JsonPropertyName(PropertyNames.Origin)]
    public string Origin { get; set; } = null!;

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
}
