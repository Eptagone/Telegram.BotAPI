// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The background is a freeform gradient that rotates after every message in the chat.
/// </summary>
public class BackgroundFillFreeformGradient : BackgroundFill
{
    /// <summary>
    /// Type of the background fill, always “freeform_gradient”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "freeform_gradient";

    /// <summary>
    /// A list of the 3 or 4 base colors that are used to generate the freeform gradient in the RGB24 format
    /// </summary>
    [JsonPropertyName(PropertyNames.Colors)]
    public IEnumerable<int> Colors { get; set; } = null!;
}
