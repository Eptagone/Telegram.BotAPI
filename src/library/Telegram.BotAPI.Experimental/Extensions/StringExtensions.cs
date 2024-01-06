// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableMethods.FormattingOptions;

namespace Telegram.BotAPI.Extensions;

public static class StringExtensions
{
	private static readonly IStyleParser _parser = StyleParser.Default;
	private static readonly FormattingHelper<IStyleParser> _formattingHelper = new(_parser);

	/// <summary>
	/// Replaces symbols that are not part of an HTML tag or entity with HTML entities
	///     (&lt; with &amp;lt;, &gt; with &amp;gt; and &amp; with &amp;amp;).
	/// </summary>
	/// <param name="text">Input text.</param>
	/// <returns>The parsed <see cref="string"/>.</returns>
	public static string ParseHtmlTags(this string text) => _parser.ToHTML(text);

	/// <summary>
	/// Format text using HTML. Bold.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlBoldText(this string input) => _formattingHelper.Bold(input, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Code.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlCodeText(this string input) => _formattingHelper.Code(input, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Italic.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlItalicText(this string input) => _formattingHelper.Code(input, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Pre.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlPreText(this string input) => _formattingHelper.Pre(input, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Pre.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <param name="language">Programming language. Ex: python</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlPreText(this string input, string language) => _formattingHelper.Pre(input, language, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Spoiler.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlSpoiler(this string input) => _formattingHelper.Spoiler(input);

	/// <summary>
	/// Format text using HTML. Strikethrough.
	/// </summary>
	/// <param name="input">Input text</param>
	/// <returns></returns>
	public static string AsHtmlStrikethrough(this string input) => _formattingHelper.Strikethrough(input, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Text link.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <param name="url">Url.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlTextLink(this string input, string url) => _formattingHelper.TextLink(input, url, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Text Mention.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <param name="userId">Unique identifier for this user or bot.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlTextMention(this string input, long userId) => _formattingHelper.TextMention(input, userId, ParseModeKind.HTML);

	/// <summary>
	/// Format text using HTML. Underline.
	/// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>Stylized <see cref="string"/>.</returns>
	public static string AsHtmlUnderline(this string input) => _formattingHelper.Underline(input, ParseModeKind.HTML);
}
