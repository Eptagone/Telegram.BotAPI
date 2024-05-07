// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The background is taken directly from a built-in chat theme.
/// </summary>
public class BackgroundTypeChatTheme : BackgroundType
{
    /// <summary>
    /// Type of the background, always “chat_theme”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "chat_theme";

    /// <summary>
    /// Name of the chat theme, which is usually an emoji
    /// </summary>
    [JsonPropertyName(PropertyNames.ThemeName)]
    public string ThemeName { get; set; } = null!;
}
