// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>The member's status in the chat. Can be “creator”, “administrator”, “member”, “restricted”, “left” or “kicked”.</summary>
public static class ChatMemberStatus
{
	/// <summary>Creator.</summary>
	public const string Creator = "creator";
	/// <summary>Administrator.</summary>
	public const string Administrator = "administrator";
	/// <summary>Member.</summary>
	public const string Member = "member";
	/// <summary>Restricted.</summary>
	public const string Restricted = "restricted";
	/// <summary>Left.</summary>
	public const string Left = "left";
	/// <summary>Kicked.</summary>
	public const string Kicked = "kicked";
}
