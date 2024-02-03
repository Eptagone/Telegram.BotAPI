// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableMethods.FormattingOptions;

/// <summary>
/// Define a set of useful methods for parsing text to be used with styles.
/// </summary>
[Obsolete("Use Telegram.BotAPI.Extensions.HtmlTextFormatter instead.")]
public interface IStyleParser
{
	/// <summary>Parse specified text with wrong style tags.</summary>
	/// <param name="input">Input text.</param>
	/// <param name="parseMode">Style to be applied to the new text.</param>
	/// <returns><see cref="string"/></returns>
	string To(string input, ParseModeKind parseMode);

	/// <summary>Replaces symbols that are not part of an HTML tag or entity with HTML entities (&lt; with &amp;lt;, &gt; with &amp;gt; and &amp; with &amp;amp;).</summary>
	/// <param name="input">Input text.</param>
	/// <returns>String with HTML entities.</returns>
	/// <returns><see cref="string"/></returns>
	string ToHTML(string input);

	/// <summary>Prepends the character '\' for the escape characters: '_', '*', '`', '['.</summary>
	/// <param name="input">Input text.</param>
	/// <returns><see cref="string"/></returns>
	string ToMarkdown(string input);

	/// <summary>Prepends the character '\' for the escape characters: '_', '*', '[', ']', '(', ')', '~', '`', '>', '#', '+', '-', '=', '|', '{', '}', '.', '!'.</summary>
	/// <param name="input">Input text.</param>
	/// <returns><see cref="string"/></returns>
	string ToMarkdownV2(string input);
}
