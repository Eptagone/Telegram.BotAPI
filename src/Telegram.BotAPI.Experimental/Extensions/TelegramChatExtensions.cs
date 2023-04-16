// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions;

public static class TelegramChatExtensions
{
	/// <summary>
	/// Check if the chat data is the same as another chat.
	/// </summary>
	/// <typeparam name="TChat">Chat type.</typeparam>
	/// <param name="chat">Chat data.</param>
	/// <param name="anotherChat">Another chat.</param>
	/// <returns>True, is data of the chats aren't the same.</returns>
	public static bool HasChanges<TChat>(this TChat chat, ITelegramChat anotherChat)
		where TChat : ITelegramChat
	{
		var hasChanges = chat.Id != anotherChat.Id ||
			chat.Title != anotherChat.Title ||
			chat.Username != anotherChat.Username ||
			chat.Description != anotherChat.Description ||
			chat.InviteLink != anotherChat.InviteLink ||
			chat.LinkedChatId != anotherChat.LinkedChatId ||
			chat.Type != anotherChat.Type;

		return hasChanges;
	}

	/// <summary>
	/// Merge chat data from one chat with another chat.
	/// </summary>
	/// <typeparam name="TChat">Chat type.</typeparam>
	/// <param name="chat">Chat.</param>
	/// <param name="anotherChat">Another chat.</param>
	/// <returns>Updated chat data.</returns>
	public static TChat Merge<TChat>(this TChat chat, ITelegramChat anotherChat)
		where TChat : ITelegramChat
	{
		chat.Id = anotherChat.Id;
		chat.Title = anotherChat.Title;
		chat.Username = anotherChat.Username;
		chat.Description = anotherChat.Description;
		chat.InviteLink = anotherChat.InviteLink;
		chat.LinkedChatId = anotherChat.LinkedChatId;
		chat.Type = anotherChat.Type;

		return chat;
	}
}
