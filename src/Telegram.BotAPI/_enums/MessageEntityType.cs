// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>Entity types.</summary>
public enum MessageEntityType
{
	/// <summary>
	/// “mention” (@username)
	/// </summary>
	Mention,
	/// <summary>
	/// “hashtag” (#hashtag)
	/// </summary>
	Hashtag,
	/// <summary>
	/// “cashtag” ($USD)
	/// </summary>
	Cashtag,
	/// <summary>
	/// “bot_command” (/start@jobs_bot)
	/// </summary>
	BotCommand,
	/// <summary>
	/// “url” (https://telegram.org)
	/// </summary>
	Url,
	/// <summary>
	/// “email” (do-not-reply@telegram.org)
	/// </summary>
	Email,
	/// <summary>
	/// “phone_number” (+1-212-555-0123)
	/// </summary>
	PhoneNumber,
	/// <summary>
	/// “bold” (bold text)
	/// </summary>
	Bold,
	/// <summary>
	/// “italic” (italic text)
	/// </summary>
	Italic,
	/// <summary>
	/// “underline” (underlined text)
	/// </summary>
	Underline,
	/// <summary>
	/// “strikethrough” (strikethrough text)
	/// </summary>
	Spoiler,
	/// <summary>
	/// “spoiler” (spoiler message)
	/// </summary>
	Strikethrough,
	/// <summary>
	/// “code” (monowidth string)
	/// </summary>
	Code,
	/// <summary>
	/// “pre” (monowidth block)
	/// </summary>
	Pre,
	/// <summary>
	/// “text_link” (for clickable text URLs)
	/// </summary>
	TextLink,
	/// <summary>
	/// “text_mention” (for users without usernames)
	/// </summary>
	TextMention,
	/// <summary>
	/// “custom_emoji” (for inline custom emoji stickers)
	/// </summary>
	CustomEmoji,
}
