// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The theme based on a unique gift owned by the user or the chat.
/// </summary>
public class ChatShareThemeUniqueGift : ChatShareTheme
{
    /// <summary>
    /// Type of the theme, always “unique_gift”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "unique_gift";

    /// <summary>
    /// The gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public UniqueGift Gift { get; set; } = null!;
}
