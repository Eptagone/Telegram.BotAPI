// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Defines all available entity types.
/// </summary>
/// <remarks>
/// Currently, can be “mention” (@username), “hashtag” (#hashtag), “cashtag” ($USD), “bot_command” (/start@jobs_bot), “url” (https://telegram.org), “email” (do-not-reply@telegram.org), “phone_number” (+1-212-555-0123), “bold” (bold text), “italic” (italic text), “underline” (underlined text), “strikethrough” (strikethrough text), “spoiler” (spoiler message), “blockquote” (block quotation), “code” (monowidth string), “pre” (monowidth block), “text_link” (for clickable text URLs), “text_mention” (for users without usernames), “custom_emoji” (for inline custom emoji stickers).
/// </remarks>
public static class MessageEntityTypes
{
	/// <summary>
	/// “mention” (@username)
	/// </summary>
	public const string Mention = "mention";

	/// <summary>
	/// “hashtag” (#hashtag)
	/// </summary>
	public const string Hashtag = "hashtag";

	/// <summary>
	/// “cashtag” ($USD)
	/// </summary>
	public const string Cashtag = "cashtag";

	/// <summary>
	/// “bot_command” (/start@jobs_bot)
	/// </summary>
	public const string BotCommand = "bot_command";

	/// <summary>
	/// “url” (https://telegram.org)
	/// </summary>
	public const string Url = "url";

	/// <summary>
	/// “email” (do-not-reply@telegram.org)
	/// </summary>
	public const string Email = "email";

	/// <summary>
	/// “phone_number” (+1-212-555-0123)
	/// </summary>
	public const string PhoneNumber = "phone_number";

	/// <summary>
	/// “bold” (bold text)
	/// </summary>
	public const string Bold = "bold";

	/// <summary>
	/// “italic” (italic text)
	/// </summary>
	public const string Italic = "italic";

	/// <summary>
	/// “underline” (underlined text)
	/// </summary>
	public const string Underline = "underline";

	/// <summary>
	/// “strikethrough” (strikethrough text)
	/// </summary>
	public const string Strikethrough = "strikethrough";

	/// <summary>
	/// “spoiler” (spoiler message)
	/// </summary>
	public const string Spoiler = "spoiler";

	/// <summary>
	/// “blockquote” (block quotation)
	/// </summary>
	public const string Blockquote = "blockquote";

	/// <summary>
	/// “code” (monowidth string)
	/// </summary>
	public const string Code = "code";

	/// <summary>
	/// “pre” (monowidth block)
	/// </summary>
	public const string Pre = "pre";

	/// <summary>
	/// “text_link” (for clickable text URLs)
	/// </summary>
	public const string TextLink = "text_link";

	/// <summary>
	/// “text_mention” (for users without usernames)
	/// </summary>
	public const string TextMention = "text_mention";

	/// <summary>
	/// “custom_emoji” (for inline custom emoji stickers)
	/// </summary>
	public const string CustomEmoji = "custom_emoji";
}
