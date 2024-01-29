// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes that no specific value for the menu button was set.
/// </summary>
public class MenuButtonDefault : MenuButton
{
    /// <summary>
    /// Type of the button, must be <em>default</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "default";
}
