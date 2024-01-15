// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Defines methods to format text.
/// </summary>
public interface ITextFormatter
{
    /// <summary>
    /// Create a new stylized text from message entities.
    /// </summary>
    /// <param name="input">Input text.</param>
    /// <param name="entities">Message entities.</param>
    string FromEntities(string input, IEnumerable<MessageEntity> entities);

	/// <summary>
    /// Convert the given text to bold.  
    /// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>Stylized <see cref="string"/></returns>
	string Bold(string input);

	/// <summary>
    /// Convert the given text to italic.
    /// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>The text in italic.</returns>
	string Italic(string input);

	/// <summary>
    /// Convert the given text to underline.
    /// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>The text underlined.</returns>
	string Underline(string input);

	/// <summary>
    /// Convert the given text to strikethrough.
    /// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>A strikethrough text</returns>
	string Strikethrough(string input);

	/// <summary>Conver the fiven text into a spoiler.</summary>
	/// <param name="input">Input text.</param>
	/// <returns>The spoiler</returns>
	string Spoiler(string input);

	/// <summary>Convert the text into a code block</summary>
	/// <param name="input">Input text.</param>
	/// <returns>A code block</returns>
	string Code(string input);

	/// <summary>
    /// Convert the given text into a block of pre-formatted text.
    /// </summary>
	/// <param name="input">Input text.</param>
	/// <returns>A pre-formatted text</returns>
	string Pre(string input, string? language = null);

	/// <summary>
    /// Create a new text with a hyperlink.
    /// </summary>
	/// <param name="input">Input text.</param>
	/// <param name="url">Url.</param>
	/// <returns>A text link</returns>
	string TextLink(string input, string url);

	/// <summary>
    /// Create a new text with a mention.
    /// </summary>
	/// <param name="input">Input text.</param>
	/// <param name="userId">Unique identifier for this user or bot.</param>
	/// <returns>The text mention</returns>
	string TextMention(string input, long userId);

	/// <summary>
	/// Create a new text with a custom emoji.
	/// </summary>
	/// <param name="customEmojiId">Unique identifier of the custom emoji.</param>
	/// <param name="emoji">The emoji.</param>
	/// <returns>A custom emoji text</returns>
	string CustomEmoji(string customEmojiId, string emoji);
}