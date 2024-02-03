// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Defines all available parse modes.
/// </summary>
/// <remarks>
/// See <see href="https://core.telegram.org/bots/api#formatting-options">formatting options</see> for more information.
/// </remarks>
public static class FormatStyles
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public const string HTML = "HTML";
	public const string Markdown = "Markdown";
	public const string MarkdownV2 = "MarkdownV2";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
