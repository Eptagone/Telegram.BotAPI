// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes an emoji. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="EmojiTypeEmoji"/></description></item>
/// <item><description><see cref="EmojiTypeCustomEmoji"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(EmojiTypeConverter))]
public abstract class EmojiType
{
    /// <summary>
    /// Type of the emoji
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
