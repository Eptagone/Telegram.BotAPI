// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the theme of the screen for sharing a link to a user or a chat. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="ChatShareThemeEmoji"/></description></item>
/// <item><description><see cref="ChatShareThemeUniqueGift"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(ChatShareThemeConverter))]
public abstract class ChatShareTheme
{
    /// <summary>
    /// Type of the theme
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
