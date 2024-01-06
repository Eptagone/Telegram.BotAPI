// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to change the default administrator rights requested by the bot when it's added as an administrator to groups or channels. These rights will be suggested to users, but they are are free to modify the list before adding the bot. Returns True on success.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="rights">A JSON-serialized object describing new default administrator rights. If not specified, the default administrator rights will be cleared.</param>
	/// <param name="forChannels">Pass True to change the default administrator rights of the bot in channels. Otherwise, the default administrator rights of the bot for groups and supergroups will be changed.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetMyDefaultAdministratorRights(this ITelegramBotClient api, [Optional] ChatAdministratorRights? rights, [Optional] bool? forChannels)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SetMyDefaultAdministratorRightsArgs()
		{
			Rights = rights,
			ForChannels = forChannels
		};
		return api.CallMethod<bool>(MethodNames.SetMyDefaultAdministratorRights, args);
	}

	/// <summary>Use this method to change the default administrator rights requested by the bot when it's added as an administrator to groups or channels. These rights will be suggested to users, but they are are free to modify the list before adding the bot. Returns True on success.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="rights">A JSON-serialized object describing new default administrator rights. If not specified, the default administrator rights will be cleared.</param>
	/// <param name="forChannels">Pass True to change the default administrator rights of the bot in channels. Otherwise, the default administrator rights of the bot for groups and supergroups will be changed.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetMyDefaultAdministratorRightsAsync(this ITelegramBotClient api, [Optional] ChatAdministratorRights? rights, [Optional] bool? forChannels, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SetMyDefaultAdministratorRightsArgs()
		{
			Rights = rights,
			ForChannels = forChannels
		};
		return await api.CallMethodAsync<bool>(MethodNames.SetMyDefaultAdministratorRights, args, cancellationToken).ConfigureAwait(false);
	}
}
