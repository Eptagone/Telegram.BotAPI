// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.ComponentModel.DataAnnotations;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Abstractions;

public abstract class TelegramChat : ITelegramChat
{
	public TelegramChat()
	{
	}

	public TelegramChat(ITelegramChat chat)
	{
		this.Id = chat.Id;
		this.Title = chat.Title;
		this.Username = chat.Username;
		this.Description = chat.Description;
		this.InviteLink = chat.InviteLink;
		this.LinkedChatId = chat.LinkedChatId;
		this.Type = chat.Type;
	}

	public long Id { get; set; }
	[MaxLength(128)]
	public string Title { get; set; } = null!;
	public string Type { get; set; } = null!;
	public string? Username { get; set; }
	public string? Description { get; set; }
	public string? InviteLink { get; set; }
	public long? LinkedChatId { get; set; }
}
