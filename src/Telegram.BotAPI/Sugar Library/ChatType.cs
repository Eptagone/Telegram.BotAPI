// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Type of chat, can be either “private”, “group”, “supergroup” or “channel”. Can be either “sender” for a private chat with the inline query sender.
/// </summary>
public static class ChatType
{
	/// <summary>Private chat with the inline query sender</summary>
	public const string Sender = "sender";
	/// <summary>Private chat</summary>
	public const string Private = "private";
	/// <summary>Group chat</summary>
	public const string Group = "group";
	/// <summary>Supergroup chat</summary>
	public const string Supergroup = "supergroup";
	/// <summary>Channel chat</summary>
	public const string Channel = "channel";
}
