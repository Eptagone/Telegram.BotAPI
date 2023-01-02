// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>Use this method to change the bot's menu button in a private chat, or the default menu button. Returns True on success.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be changed.</param>
		/// <param name="menuButton">A JSON-serialized object for the new bot's menu button. Defaults to MenuButtonDefault.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool SetChatMenuButton(this BotClient? api, [Optional] long? chatId, [Optional] MenuButton? menuButton)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new SetChatMenuButtonArgs()
			{
				ChatId = chatId,
				MenuButton = menuButton
			};
			return api.RPC<bool>(MethodNames.SetChatMenuButton, args);
		}

		/// <summary>Use this method to change the bot's menu button in a private chat, or the default menu button. Returns True on success.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be changed.</param>
		/// <param name="menuButton">A JSON-serialized object for the new bot's menu button. Defaults to MenuButtonDefault.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> SetChatMenuButtonAsync(this BotClient? api, [Optional] long? chatId, [Optional] MenuButton? menuButton, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new SetChatMenuButtonArgs()
			{
				ChatId = chatId,
				MenuButton = menuButton
			};
			return await api.RPCA<bool>(MethodNames.SetChatMenuButton, args, cancellationToken).ConfigureAwait(false);
		}
	}
}
