// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a “Thinking…” placeholder, corresponding to the custom HTML tag <em>&lt;tg-thinking&gt;</em>. The block may be used only in <a href="https://core.telegram.org/bots/api#sendrichmessagedraft">sendRichMessageDraft</a>, therefore it can't be received in messages. See <a href="https://t.me/addemoji/AIActions"></a><a href="https://t.me/addemoji/AIActions">https://t.me/addemoji/AIActions</a> for examples of custom emoji, which are recommended for usage in the block.
/// </summary>
public class RichBlockThinking : RichBlock
{
    /// <summary>
    /// Type of the block, always “thinking”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "thinking";

    /// <summary>
    /// Text of the block. See <a href="https://t.me/addemoji/AIActions"></a><a href="https://t.me/addemoji/AIActions">https://t.me/addemoji/AIActions</a> for examples of custom emoji, which are recommended for usage in the block.
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public RichText Text { get; set; } = null!;
}
