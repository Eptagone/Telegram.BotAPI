// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// This object represents one result of an inline query. Telegram clients currently support results of the following 20 types:
/// <strong>Note:</strong> All URLs passed in inline query results will be available to end users and therefore must be assumed to be <strong>public</strong>.
/// <list type="bullet">
/// <item><description><see cref="InlineQueryResultCachedAudio"/></description></item>
/// <item><description><see cref="InlineQueryResultCachedDocument"/></description></item>
/// <item><description><see cref="InlineQueryResultCachedGif"/></description></item>
/// <item><description><see cref="InlineQueryResultCachedMpeg4Gif"/></description></item>
/// <item><description><see cref="InlineQueryResultCachedPhoto"/></description></item>
/// <item><description><see cref="InlineQueryResultCachedSticker"/></description></item>
/// <item><description><see cref="InlineQueryResultCachedVideo"/></description></item>
/// <item><description><see cref="InlineQueryResultCachedVoice"/></description></item>
/// <item><description><see cref="InlineQueryResultArticle"/></description></item>
/// <item><description><see cref="InlineQueryResultAudio"/></description></item>
/// <item><description><see cref="InlineQueryResultContact"/></description></item>
/// <item><description><see cref="InlineQueryResultGame"/></description></item>
/// <item><description><see cref="InlineQueryResultDocument"/></description></item>
/// <item><description><see cref="InlineQueryResultGif"/></description></item>
/// <item><description><see cref="InlineQueryResultLocation"/></description></item>
/// <item><description><see cref="InlineQueryResultMpeg4Gif"/></description></item>
/// <item><description><see cref="InlineQueryResultPhoto"/></description></item>
/// <item><description><see cref="InlineQueryResultVenue"/></description></item>
/// <item><description><see cref="InlineQueryResultVideo"/></description></item>
/// <item><description><see cref="InlineQueryResultVoice"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InlineQueryResultConverter))]
public abstract class InlineQueryResult
{
    /// <summary>
    /// Type of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }

    /// <summary>
    /// Unique identifier for this result
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public abstract string Id { get; set; }

    /// <summary>
    /// No description available
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public abstract InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
