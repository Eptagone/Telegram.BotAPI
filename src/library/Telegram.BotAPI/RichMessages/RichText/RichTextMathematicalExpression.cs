// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A mathematical expression.
/// </summary>
public class RichTextMathematicalExpression : RichText
{
    /// <summary>
    /// Type of the rich text, always “mathematical_expression”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "mathematical_expression";

    /// <summary>
    /// The expression in LaTeX format
    /// </summary>
    [JsonPropertyName(PropertyNames.Expression)]
    public string Expression { get; set; } = null!;
}
