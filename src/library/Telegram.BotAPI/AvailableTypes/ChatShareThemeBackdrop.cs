// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a backdrop, which can be used as the background of a theme of the screen for sharing a link to a user or a chat.
/// </summary>
public class ChatShareThemeBackdrop
{
    /// <summary>
    /// Unique identifier of the backdrop
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public int Id { get; set; }

    /// <summary>
    /// Name of the backdrop
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Colors of the backdrop
    /// </summary>
    [JsonPropertyName(PropertyNames.Colors)]
    public UniqueGiftBackdropColors Colors { get; set; } = null!;
}
