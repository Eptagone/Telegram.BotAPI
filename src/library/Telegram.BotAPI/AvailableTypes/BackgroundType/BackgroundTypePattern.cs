// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The background is a PNG or TGV (gzipped subset of SVG with MIME type “application/x-tgwallpattern”) pattern to be combined with the background fill chosen by the user.
/// </summary>
public class BackgroundTypePattern : BackgroundType
{
    /// <summary>
    /// Type of the background, always “pattern”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "pattern";

    /// <summary>
    /// Document with the pattern
    /// </summary>
    [JsonPropertyName(PropertyNames.Document)]
    public Document Document { get; set; } = null!;

    /// <summary>
    /// The background fill that is combined with the pattern
    /// </summary>
    [JsonPropertyName(PropertyNames.Fill)]
    public BackgroundFill Fill { get; set; } = null!;

    /// <summary>
    /// Intensity of the pattern when it is shown above the filled background; 0-100
    /// </summary>
    [JsonPropertyName(PropertyNames.Intensity)]
    public int Intensity { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the background fill must be applied only to the pattern itself. All other pixels are black in this case. For dark themes only
    /// </summary>
    [JsonPropertyName(PropertyNames.IsInverted)]
    public bool? IsInverted { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the background moves slightly when the device is tilted
    /// </summary>
    [JsonPropertyName(PropertyNames.IsMoving)]
    public bool? IsMoving { get; set; }
}
