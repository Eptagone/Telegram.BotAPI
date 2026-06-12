// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Caption of a rich formatted block.
/// </summary>
public class RichBlockCaption
{
    /// <summary>
    /// Block caption
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;

    /// <summary>
    /// Optional. Block credit which corresponds to the HTML tag &lt;cite&gt;
    /// </summary>
    [JsonPropertyName(PropertyNames.Credit)]
    public RichText? Credit { get; set; }
}
