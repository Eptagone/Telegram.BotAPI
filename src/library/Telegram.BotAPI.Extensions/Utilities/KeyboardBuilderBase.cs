// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Collections;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Provides a base class for building keyboards with a fluent interface.
/// </summary>
/// <typeparam name="TBuilder">The type of the specific builder class that is derived from this base class.</typeparam>
/// <typeparam name="TButton">The type of the button that this builder creates.</typeparam>
public abstract class KeyboardBuilderBase<TBuilder, TButton> : IEnumerable<IEnumerable<TButton>>
    where TBuilder : KeyboardBuilderBase<TBuilder, TButton>
{
    private readonly List<IEnumerable<TButton>> rows;
    private List<TButton>? currentRow;

    protected KeyboardBuilderBase(IEnumerable<IEnumerable<TButton>>? keyboard = null)
    {
        this.rows = new(keyboard?.Where(k => k.Any()) ?? []);
        this.currentRow = this.rows.LastOrDefault()?.ToList();
    }

    /// <summary>
    /// Appends the specified button to the current row.
    /// </summary>
    /// <param name="button">The button to append.</param>
    /// <returns>The current builder instance.</returns>
    public TBuilder Append(TButton button)
    {
        if (this.currentRow is null)
        {
            this.currentRow = [];
            this.rows.Add(this.currentRow);
        }

        this.currentRow.Add(button);
        return (TBuilder)this;
    }

    /// <summary>
    /// Appends a new row to the keyboard.
    /// </summary>
    /// <returns>The current builder instance.</returns>
    public TBuilder AppendRow()
    {
        if (this.currentRow is not null && this.currentRow.Count > 0)
        {
            this.currentRow = null;
        }

        return (TBuilder)this;
    }

    IEnumerator<IEnumerable<TButton>> IEnumerable<IEnumerable<TButton>>.GetEnumerator() =>
        this.rows.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => this.rows.GetEnumerator();
}
