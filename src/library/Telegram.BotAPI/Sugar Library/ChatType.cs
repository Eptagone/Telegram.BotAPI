// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Type of chat, can be either “private”, “group”, “supergroup” or “channel”. Can be either “sender” for a private chat with the inline query sender.
/// </summary>
[Obsolete("Use Telegram.BotAPI.ChatTypes instead.")]
public static class ChatType
{
	/// <summary>
	/// Private chat with the inline query sender
	/// </summary>
	public const string Sender = ChatTypes.Sender;

	/// <summary>
	/// Private chat
	/// </summary>
	public const string Private = ChatTypes.Private;

	/// <summary>
	/// Group chat
	/// </summary>
	public const string Group = ChatTypes.Group;

	/// <summary>
	/// Supergroup chat
	/// </summary>
	public const string Supergroup = ChatTypes.Supergroup;

	/// <summary>
	/// Channel chat
	/// </summary>
	public const string Channel = ChatTypes.Channel;
}
