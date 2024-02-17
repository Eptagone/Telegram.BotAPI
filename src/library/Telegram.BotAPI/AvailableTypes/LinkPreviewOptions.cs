// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the options used for link preview generation.
/// </summary>
public class LinkPreviewOptions
{
    /// <summary>
    /// Optional. <em>True</em>, if the link preview is disabled
    /// </summary>
    [JsonPropertyName(PropertyNames.IsDisabled)]
    public bool? IsDisabled { get; set; }

    /// <summary>
    /// Optional. URL to use for the link preview. If empty, then the first URL found in the message text will be used
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string? Url { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the media in the link preview is supposed to be shrunk; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    /// </summary>
    [JsonPropertyName(PropertyNames.PreferSmallMedia)]
    public bool? PreferSmallMedia { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the media in the link preview is supposed to be enlarged; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    /// </summary>
    [JsonPropertyName(PropertyNames.PreferLargeMedia)]
    public bool? PreferLargeMedia { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the link preview must be shown above the message text; otherwise, the link preview will be shown below the message text
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowAboveText)]
    public bool? ShowAboveText { get; set; }
}
