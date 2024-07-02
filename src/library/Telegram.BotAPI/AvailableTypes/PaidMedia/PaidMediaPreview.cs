// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The paid media isn't available before the payment.
/// </summary>
public class PaidMediaPreview : PaidMedia
{
    /// <summary>
    /// Type of the paid media, always “preview”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "preview";

    /// <summary>
    /// Optional. Media width as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int? Width { get; set; }

    /// <summary>
    /// Optional. Media height as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int? Height { get; set; }

    /// <summary>
    /// Optional. Duration of the media in seconds as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Duration)]
    public int? Duration { get; set; }
}
