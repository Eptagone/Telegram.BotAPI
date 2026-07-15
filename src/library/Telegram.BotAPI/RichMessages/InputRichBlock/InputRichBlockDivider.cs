// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A divider, corresponding to the HTML tag <em>&lt;hr/&gt;</em>.
/// </summary>
public class InputRichBlockDivider : InputRichBlock
{
    /// <summary>
    /// Type of the block, always “divider”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "divider";
}
