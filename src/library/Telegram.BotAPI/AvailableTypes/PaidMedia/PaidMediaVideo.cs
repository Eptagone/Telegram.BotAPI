// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The paid media is a video.
/// </summary>
public class PaidMediaVideo : PaidMedia
{
    /// <summary>
    /// Type of the paid media, always “video”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "video";

    /// <summary>
    /// The video
    /// </summary>
    [JsonPropertyName(PropertyNames.Video)]
    public Video Video { get; set; } = null!;
}
