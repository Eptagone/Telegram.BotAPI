// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Defines all the types of telegram chats.
/// </summary>
public static class ChatTypes
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public const string Sender = "sender";
	public const string Private = "private";
	public const string Group = "group";
	public const string Supergroup = "supergroup";
	public const string Channel = "channel";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
