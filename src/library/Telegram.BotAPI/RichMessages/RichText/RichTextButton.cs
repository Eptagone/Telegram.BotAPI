// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A button.
/// </summary>
public class RichTextButton : RichText
{
    /// <summary>
    /// Type of the rich text, always “button”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "button";

    /// <summary>
    /// The button
    /// </summary>
    [JsonPropertyName(PropertyNames.Button)]
    public RichMessageButton Button { get; set; } = null!;
}
