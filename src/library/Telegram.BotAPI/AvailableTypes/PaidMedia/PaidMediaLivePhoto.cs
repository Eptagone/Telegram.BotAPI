// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The paid media is a <a href="https://core.telegram.org/bots/api#livephoto">live photo</a>.
/// </summary>
public class PaidMediaLivePhoto : PaidMedia
{
    /// <summary>
    /// Type of the paid media, always “live_photo”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "live_photo";

    /// <summary>
    /// The photo
    /// </summary>
    [JsonPropertyName(PropertyNames.LivePhoto)]
    public LivePhoto LivePhoto { get; set; } = null!;
}
