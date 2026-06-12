// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Formatted date and time.
/// </summary>
public class RichTextDateTime : RichText
{
    /// <summary>
    /// Type of the rich text, always “date_time”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "date_time";

    /// <summary>
    /// The text
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// The Unix time associated with the entity
    /// </summary>
    [JsonPropertyName(PropertyNames.UnixTime)]
    public int UnixTime { get; set; }

    /// <summary>
    /// The string that defines the formatting of the date and time. See <a href="https://core.telegram.org/bots/api#date-time-entity-formatting">date-time entity formatting</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.DateTimeFormat)]
    public string DateTimeFormat { get; set; } = null!;
}
