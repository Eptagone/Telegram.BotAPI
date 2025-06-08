// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an inline keyboard button that copies specified text to the clipboard.
/// </summary>
public class CopyTextButton
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CopyTextButton"/> class.
    /// </summary>
    /// <param name="text">The text to be copied to the clipboard; 1-256 characters</param>
    public CopyTextButton(string text)
    {
        this.Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    /// <summary>
    /// The text to be copied to the clipboard; 1-256 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; }
}
