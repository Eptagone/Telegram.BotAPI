// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// This object represents a block in a rich formatted message to be sent. Currently, it can be any of the following types:
/// <list type="bullet">
/// <item><description><see cref="InputRichBlockParagraph"/></description></item>
/// <item><description><see cref="InputRichBlockSectionHeading"/></description></item>
/// <item><description><see cref="InputRichBlockPreformatted"/></description></item>
/// <item><description><see cref="InputRichBlockFooter"/></description></item>
/// <item><description><see cref="InputRichBlockDivider"/></description></item>
/// <item><description><see cref="InputRichBlockMathematicalExpression"/></description></item>
/// <item><description><see cref="InputRichBlockAnchor"/></description></item>
/// <item><description><see cref="InputRichBlockList"/></description></item>
/// <item><description><see cref="InputRichBlockBlockQuotation"/></description></item>
/// <item><description><see cref="InputRichBlockExpandableBlockQuotation"/></description></item>
/// <item><description><see cref="InputRichBlockPullQuotation"/></description></item>
/// <item><description><see cref="InputRichBlockCollage"/></description></item>
/// <item><description><see cref="InputRichBlockSlideshow"/></description></item>
/// <item><description><see cref="InputRichBlockTable"/></description></item>
/// <item><description><see cref="InputRichBlockDetails"/></description></item>
/// <item><description><see cref="InputRichBlockMap"/></description></item>
/// <item><description><see cref="InputRichBlockButtons"/></description></item>
/// <item><description><see cref="InputRichBlockAnimation"/></description></item>
/// <item><description><see cref="InputRichBlockAudio"/></description></item>
/// <item><description><see cref="InputRichBlockDocument"/></description></item>
/// <item><description><see cref="InputRichBlockPhoto"/></description></item>
/// <item><description><see cref="InputRichBlockVideo"/></description></item>
/// <item><description><see cref="InputRichBlockVoiceNote"/></description></item>
/// <item><description><see cref="InputRichBlockThinking"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(InputRichBlockConverter))]
public abstract class InputRichBlock
{
    /// <summary>
    /// Type of the block
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
