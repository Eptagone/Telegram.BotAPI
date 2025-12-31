// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "GetChatGifts" method.
/// </summary>
public class GetChatGiftsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetChatGiftsArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    public GetChatGiftsArgs(long chatId)
    {
        this.ChatId = chatId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GetChatGiftsArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    public GetChatGiftsArgs(string chatId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that aren't saved to the chat's profile page. Always <em>True</em>, unless the bot has the <em>can_post_messages</em> administrator right in the channel.
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeUnsaved)]
    public bool? ExcludeUnsaved { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that are saved to the chat's profile page. Always <em>False</em>, unless the bot has the <em>can_post_messages</em> administrator right in the channel.
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeSaved)]
    public bool? ExcludeSaved { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that can be purchased an unlimited number of times
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeUnlimited)]
    public bool? ExcludeUnlimited { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that can be purchased a limited number of times and can be upgraded to unique
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeLimitedUpgradable)]
    public bool? ExcludeLimitedUpgradable { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that can be purchased a limited number of times and can't be upgraded to unique
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeLimitedNonUpgradable)]
    public bool? ExcludeLimitedNonUpgradable { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude gifts that were assigned from the TON blockchain and can't be resold or transferred in Telegram
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeFromBlockchain)]
    public bool? ExcludeFromBlockchain { get; set; }

    /// <summary>
    /// Pass <em>True</em> to exclude unique gifts
    /// </summary>
    [JsonPropertyName(PropertyNames.ExcludeUnique)]
    public bool? ExcludeUnique { get; set; }

    /// <summary>
    /// Pass <em>True</em> to sort results by gift price instead of send date. Sorting is applied before pagination.
    /// </summary>
    [JsonPropertyName(PropertyNames.SortByPrice)]
    public bool? SortByPrice { get; set; }

    /// <summary>
    /// Offset of the first entry to return as received from the previous request; use an empty string to get the first chunk of results
    /// </summary>
    [JsonPropertyName(PropertyNames.Offset)]
    public string? Offset { get; set; }

    /// <summary>
    /// The maximum number of gifts to be returned; 1-100. Defaults to 100
    /// </summary>
    [JsonPropertyName(PropertyNames.Limit)]
    public int? Limit { get; set; }
}
