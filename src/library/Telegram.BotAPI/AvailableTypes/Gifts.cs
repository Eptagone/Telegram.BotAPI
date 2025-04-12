// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represent a list of gifts.
/// </summary>
public class Gifts
{
    /// <summary>
    /// The list of gifts
    /// </summary>
    [JsonPropertyName(PropertyNames.Gifts)]
    public IEnumerable<Gift> GiftList { get; set; } = null!;
}
