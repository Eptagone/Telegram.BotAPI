// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions;

public static class TelegramUserExtensions
{
	/// <summary>
	/// Get the fullname from a telegram user.
	/// </summary>
	/// <param name="user">The telegram user.</param>
	/// <returns><see cref="string"/></returns>
	public static string GetFullname(this ITelegramUser user)
	{
		if (string.IsNullOrEmpty(user.LastName))
		{
			return user.FirstName;
		}
		else
		{
			return string.Format("{0} {1}", user.FirstName, user.LastName);
		}
	}

	/// <summary>
	/// Creates a user mention using Html.
	/// </summary>
	/// <param name="user">The telegram user.</param>
	/// <returns><see cref="string"/></returns>
	public static string GetHtmlMention(this ITelegramUser user)
	{
		return user.GetFullname().AsHtmlTextMention(user.Id);
	}

	/// <summary>
	/// Check if the user data is the same as another user.
	/// </summary>
	/// <typeparam name="TUser">User type.</typeparam>
	/// <param name="user">User data.</param>
	/// <param name="anotherUser">Another chat.</param>
	/// <returns>True, is data of the users aren't the same.</returns>
	public static bool HasChanges<TUser>(this TUser user, ITelegramUser anotherUser)
		where TUser : ITelegramUser
	{
		var hasChanges = user.FirstName != anotherUser.FirstName ||
			user.LastName != anotherUser.LastName ||
			user.Username != anotherUser.Username ||
			user.LanguageCode != anotherUser.LanguageCode;

		return hasChanges;
	}

	/// <summary>
	/// Merge user data from one user with another user.
	/// </summary>
	/// <typeparam name="TUser">User type.</typeparam>
	/// <param name="user">User data.</param>
	/// <param name="anotherUser">Another user.</param>
	/// <returns>Updated user data.</returns>
	public static TUser Merge<TUser>(this TUser user, ITelegramUser anotherUser)
		where TUser : ITelegramUser
	{
		var mergeLang = string.IsNullOrEmpty(anotherUser.LanguageCode) && anotherUser.LanguageCode != user.LanguageCode;

		user.FirstName = anotherUser.FirstName;
		user.LastName = anotherUser.LastName;
		user.Username = anotherUser.Username;

		if (mergeLang)
		{
			user.LanguageCode = anotherUser.LanguageCode;
		}

		return user;
	}
}
