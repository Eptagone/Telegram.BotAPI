// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// This object represents a block in a rich formatted message. Currently, it can be any of the following types:
/// <list type="bullet">
/// <item><description><see cref="RichBlockParagraph"/></description></item>
/// <item><description><see cref="RichBlockSectionHeading"/></description></item>
/// <item><description><see cref="RichBlockPreformatted"/></description></item>
/// <item><description><see cref="RichBlockFooter"/></description></item>
/// <item><description><see cref="RichBlockDivider"/></description></item>
/// <item><description><see cref="RichBlockMathematicalExpression"/></description></item>
/// <item><description><see cref="RichBlockAnchor"/></description></item>
/// <item><description><see cref="RichBlockList"/></description></item>
/// <item><description><see cref="RichBlockBlockQuotation"/></description></item>
/// <item><description><see cref="RichBlockPullQuotation"/></description></item>
/// <item><description><see cref="RichBlockCollage"/></description></item>
/// <item><description><see cref="RichBlockSlideshow"/></description></item>
/// <item><description><see cref="RichBlockTable"/></description></item>
/// <item><description><see cref="RichBlockDetails"/></description></item>
/// <item><description><see cref="RichBlockMap"/></description></item>
/// <item><description><see cref="RichBlockAnimation"/></description></item>
/// <item><description><see cref="RichBlockAudio"/></description></item>
/// <item><description><see cref="RichBlockPhoto"/></description></item>
/// <item><description><see cref="RichBlockVideo"/></description></item>
/// <item><description><see cref="RichBlockVoiceNote"/></description></item>
/// <item><description><see cref="RichBlockThinking"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(RichBlockConverter))]
public abstract class RichBlock
{
    /// <summary>
    /// Type of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
