// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains a list of backdrops, which can be used as the background of a theme of the screen for sharing a link to a user or a chat.
/// </summary>
public class ChatShareThemeBackdrops
{
    /// <summary>
    /// The list of backdrops
    /// </summary>
    [JsonPropertyName(PropertyNames.Backdrops)]
    public IEnumerable<ChatShareThemeBackdrop> Backdrops { get; set; } = null!;
}
