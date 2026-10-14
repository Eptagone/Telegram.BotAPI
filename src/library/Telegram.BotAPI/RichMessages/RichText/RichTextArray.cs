using System.Collections;
using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Represents an array of <see cref="RichText"/>.
/// </summary>
[JsonConverter(typeof(RichTextConverter))]
public class RichTextArray(IEnumerable<RichText> items) : RichText, IEnumerable<RichText>
{
    /// <summary>
    /// Type of the rich text
    /// </summary>
    public override string Type => "RichTextArray";

    private readonly IEnumerable<RichText> items = items;

    /// <inheritdoc/>
    public IEnumerator<RichText> GetEnumerator() => this.items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}

public partial class RichText
{
#pragma warning disable IDE0023 // Use block body for conversion operator
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static implicit operator RichText(RichText[] value) => new RichTextArray(value);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore IDE0023 // Use block body for conversion operator
}
