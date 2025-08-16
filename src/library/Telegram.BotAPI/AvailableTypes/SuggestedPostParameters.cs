// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Contains parameters of a post that is being suggested by the bot.
/// </summary>
public class SuggestedPostParameters
{
    /// <summary>
    /// Optional. Proposed price for the post. If the field is omitted, then the post is unpaid.
    /// </summary>
    [JsonPropertyName(PropertyNames.Price)]
    public SuggestedPostPrice? Price { get; set; }

    /// <summary>
    /// Optional. Proposed send date of the post. If specified, then the date must be between 300 second and 2678400 seconds (30 days) in the future. If the field is omitted, then the post can be published at any time within 30 days at the sole discretion of the user who approves it.
    /// </summary>
    [JsonPropertyName(PropertyNames.SendDate)]
    public int? SendDate { get; set; }
}
