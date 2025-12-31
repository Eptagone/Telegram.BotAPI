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
    /// Optional. <em>True</em>, if the gift can only be purchased by Telegram Premium subscribers
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPremium)]
    public bool? IsPremium { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the gift can be used (after being upgraded) to customize a user's appearance
    /// </summary>
    [JsonPropertyName(PropertyNames.HasColors)]
    public bool? HasColors { get; set; }

    /// <summary>
    /// Optional. The total number of gifts of this type that can be sent by all users; for limited gifts only
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalCount)]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Optional. The number of remaining gifts of this type that can be sent by all users; for limited gifts only
    /// </summary>
    [JsonPropertyName(PropertyNames.RemainingCount)]
    public int? RemainingCount { get; set; }

    /// <summary>
    /// Optional. The total number of gifts of this type that can be sent by the bot; for limited gifts only
    /// </summary>
    [JsonPropertyName(PropertyNames.PersonalTotalCount)]
    public int? PersonalTotalCount { get; set; }

    /// <summary>
    /// Optional. The number of remaining gifts of this type that can be sent by the bot; for limited gifts only
    /// </summary>
    [JsonPropertyName(PropertyNames.PersonalRemainingCount)]
    public int? PersonalRemainingCount { get; set; }

    /// <summary>
    /// Optional. Background of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Background)]
    public GiftBackground? Background { get; set; }

    /// <summary>
    /// Optional. The total number of different unique gifts that can be obtained by upgrading the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.UniqueGiftVariantCount)]
    public int? UniqueGiftVariantCount { get; set; }

    /// <summary>
    /// Optional. Information about the chat that published the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.PublisherChat)]
    public Chat? PublisherChat { get; set; }
}
