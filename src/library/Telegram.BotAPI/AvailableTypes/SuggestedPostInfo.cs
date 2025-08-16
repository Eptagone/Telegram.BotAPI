// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Contains information about a suggested post.
/// </summary>
public class SuggestedPostInfo
{
    /// <summary>
    /// State of the suggested post. Currently, it can be one of “pending”, “approved”, “declined”.
    /// </summary>
    [JsonPropertyName(PropertyNames.State)]
    public string State { get; set; } = null!;

    /// <summary>
    /// Optional. Proposed price of the post. If the field is omitted, then the post is unpaid.
    /// </summary>
    [JsonPropertyName(PropertyNames.Price)]
    public SuggestedPostPrice? Price { get; set; }

    /// <summary>
    /// Optional. Proposed send date of the post. If the field is omitted, then the post can be published at any time within 30 days at the sole discretion of the user or administrator who approves it.
    /// </summary>
    [JsonPropertyName(PropertyNames.SendDate)]
    public int? SendDate { get; set; }
}
