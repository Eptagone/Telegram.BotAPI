// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a gift received and owned by a user or a chat. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="OwnedGiftRegular"/></description></item>
/// <item><description><see cref="OwnedGiftUnique"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(OwnedGiftConverter))]
public abstract class OwnedGift
{
    /// <summary>
    /// Type of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }

    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.OwnedGiftId)]
    public abstract string? OwnedGiftId { get; set; }

    /// <summary>
    /// Optional. Sender of the gift if it is a known user
    /// </summary>
    [JsonPropertyName(PropertyNames.SenderUser)]
    public User? SenderUser { get; set; }

    /// <summary>
    /// Date the gift was sent in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.SendDate)]
    public int SendDate { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the gift is displayed on the account's profile page; for gifts received on behalf of business accounts only
    /// </summary>
    [JsonPropertyName(PropertyNames.IsSaved)]
    public bool? IsSaved { get; set; }
}
