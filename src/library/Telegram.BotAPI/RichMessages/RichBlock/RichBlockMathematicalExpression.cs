// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A block with a mathematical expression in LaTeX format, corresponding to the custom HTML tag <em>&lt;tg-math-block&gt;</em>.
/// </summary>
public class RichBlockMathematicalExpression : RichBlock
{
    /// <summary>
    /// Type of the block, always “mathematical_expression”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "mathematical_expression";

    /// <summary>
    /// The mathematical expression in LaTeX format
    /// </summary>
    [JsonPropertyName(PropertyNames.Expression)]
    public string Expression { get; set; } = null!;
}
