// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a gift that can be sent by the bot.
/// </summary>
public class Gift
{
    /// <summary>
    /// Unique identifier of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The sticker that represents the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public Sticker Sticker { get; set; } = null!;

    /// <summary>
    /// The number of Telegram Stars that must be paid to send the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.StarCount)]
    public int StarCount { get; set; }

    /// <summary>
    /// Optional. The number of Telegram Stars that must be paid to upgrade the gift to a unique one
    /// </summary>
    [JsonPropertyName(PropertyNames.UpgradeStarCount)]
    public int? UpgradeStarCount { get; set; }

    /// <summary>
    /// Optional. The total number of the gifts of this type that can be sent; for limited gifts only
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalCount)]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Optional. The number of remaining gifts of this type that can be sent; for limited gifts only
    /// </summary>
    [JsonPropertyName(PropertyNames.RemainingCount)]
    public int? RemainingCount { get; set; }
}
