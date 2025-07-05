// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a unique gift received and owned by a user or a chat.
/// </summary>
public class OwnedGiftUnique : OwnedGift
{
    /// <summary>
    /// Type of the gift, always “unique”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "unique";

    /// <summary>
    /// Information about the unique gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public UniqueGift Gift { get; set; } = null!;

    /// <summary>
    /// Optional. Unique identifier of the received gift for the bot; for gifts received on behalf of business accounts only
    /// </summary>
    [JsonPropertyName(PropertyNames.OwnedGiftId)]
    public override string? OwnedGiftId { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the gift can be transferred to another owner; for gifts received on behalf of business accounts only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanBeTransferred)]
    public bool? CanBeTransferred { get; set; }

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
