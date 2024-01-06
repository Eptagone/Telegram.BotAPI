// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes;

public static class ChatMemberExtensions
{
	public static bool IsOwner(this ChatMember member) => member is ChatMemberOwner;
	public static bool IsAdmin(this ChatMember member) => member is ChatMemberAdministrator;
	public static bool IsAdminOrOwner(this ChatMember member) => IsAdmin(member) || IsOwner(member);
	public static bool IsMember(this ChatMember member) => member is ChatMemberMember;
	public static bool IsMemberOrAdmin(this ChatMember member) => member is ChatMemberMember || IsAdmin(member);
	public static bool IsMemberOrAdminOrOwner(this ChatMember member) => member is ChatMemberMember || IsAdminOrOwner(member);
	public static bool IsRestricted(this ChatMember member) => member is ChatMemberRestricted;
	public static bool IsBanned(this ChatMember member) => member is ChatMemberBanned;
	public static bool IsLeft(this ChatMember member) => member is ChatMemberLeft;
}
