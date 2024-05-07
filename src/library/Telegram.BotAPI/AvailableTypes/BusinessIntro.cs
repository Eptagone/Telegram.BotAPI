// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Contains information about the start page settings of a Telegram Business account.
/// </summary>
public class BusinessIntro
{
    /// <summary>
    /// Optional. Title text of the business intro
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string? Title { get; set; }

    /// <summary>
    /// Optional. Message text of the business intro
    /// </summary>
    [JsonPropertyName(PropertyNames.Message)]
    public string? Message { get; set; }

    /// <summary>
    /// Optional. Sticker of the business intro
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public Sticker? Sticker { get; set; }
}
