// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Rich formatted message.
/// </summary>
public class RichMessage
{
    /// <summary>
    /// Content of the message
    /// </summary>
    [JsonPropertyName(PropertyNames.Blocks)]
    public IEnumerable<RichBlock> Blocks { get; set; } = null!;

    /// <summary>
    /// Optional. <em>True</em>, if the rich message must be shown right-to-left
    /// </summary>
    [JsonPropertyName(PropertyNames.IsRtl)]
    public bool? IsRtl { get; set; }
}
