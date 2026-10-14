using System.Diagnostics;
using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Plain text
/// </summary>
[JsonConverter(typeof(RichTextConverter))]
[DebuggerDisplay("{value}")]
public class RichTextPlainText(string plainText) : RichText
{
    /// <summary>
    /// Type of the rich text
    /// </summary>
    public override string Type => "RichTextPlainText";

    private readonly string value = plainText;

    /// <inheritdoc/>
    public override string ToString() => this.value;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE0023 // Use block body for conversion operator
    public static implicit operator RichTextPlainText(string value) => new(value);

    public static implicit operator string(RichTextPlainText instance) => instance.value;
}

public partial class RichText
{
    public static implicit operator RichText(string value) => new RichTextPlainText(value);
}

#pragma warning restore IDE0023 // Use block body for conversion operator
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
