// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A cashtag.
/// </summary>
public class RichTextCashtag : RichText
{
    /// <summary>
    /// Type of the rich text, always “cashtag”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "cashtag";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The cashtag
    /// </summary>
    [JsonPropertyName(PropertyNames.Cashtag)]
    public string Cashtag { get; set; } = null!;
}
