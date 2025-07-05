// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the types of gifts that can be gifted to a user or a chat.
/// </summary>
public class AcceptedGiftTypes
{
    /// <summary>
    /// <em>True</em>, if unlimited regular gifts are accepted
    /// </summary>
    [JsonPropertyName(PropertyNames.UnlimitedGifts)]
    public bool UnlimitedGifts { get; set; }

    /// <summary>
    /// <em>True</em>, if limited regular gifts are accepted
    /// </summary>
    [JsonPropertyName(PropertyNames.LimitedGifts)]
    public bool LimitedGifts { get; set; }

    /// <summary>
    /// <em>True</em>, if unique gifts or gifts that can be upgraded to unique for free are accepted
    /// </summary>
    [JsonPropertyName(PropertyNames.UniqueGifts)]
    public bool UniqueGifts { get; set; }

    /// <summary>
    /// <em>True</em>, if a Telegram Premium subscription is accepted
    /// </summary>
    [JsonPropertyName(PropertyNames.PremiumSubscription)]
    public bool PremiumSubscription { get; set; }
}
