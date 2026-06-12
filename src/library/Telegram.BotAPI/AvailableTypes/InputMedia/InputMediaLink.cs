// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents an HTTP link to be sent.
/// </summary>
public class InputMediaLink : InputMedia
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputMediaLink"/> class.
    /// </summary>
    /// <param name="url">HTTP URL of the link</param>
    public InputMediaLink(string url)
    {
        this.Url = url ?? throw new ArgumentNullException(nameof(url));
    }

    /// <summary>
    /// Type of the result, must be <em>link</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "link";

    /// <summary>
    /// HTTP URL of the link
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; }
}
