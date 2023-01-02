// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>Available types of <see cref="MenuButton"/>.</summary>
	public static class MenuButtonType
	{
		/// <summary>Represents a menu button, which opens the bot's list of commands.</summary>
		public const string Commands = "commands";
		/// <summary>Describes that no specific value for the menu button was set.</summary>
		public const string Default = "default";
		/// <summary>Represents a menu button, which launches a Web App.</summary>
		public const string WebApp = CommonNames.WebApp;
	}
}
