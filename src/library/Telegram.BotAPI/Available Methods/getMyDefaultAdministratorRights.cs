// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to get the current default administrator rights of the bot. Returns ChatAdministratorRights on success.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="forChannels">Pass True to get default administrator rights of the bot in channels. Otherwise, default administrator rights of the bot for groups and supergroups will be returned.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static ChatAdministratorRights GetMyDefaultAdministratorRights(this ITelegramBotClient api, [Optional] bool? forChannels)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (forChannels is not null)
		{
			json.WriteBoolean(PropertyNames.ForChannels, (bool)forChannels);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<ChatAdministratorRights>(MethodNames.GetMyDefaultAdministratorRights, stream);
	}

	/// <summary>Use this method to get the current default administrator rights of the bot. Returns ChatAdministratorRights on success.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="forChannels">Pass True to get default administrator rights of the bot in channels. Otherwise, default administrator rights of the bot for groups and supergroups will be returned.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<ChatAdministratorRights> GetMyDefaultAdministratorRightsAsync(this ITelegramBotClient api, [Optional] bool? forChannels, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (forChannels is not null)
		{
			json.WriteBoolean(PropertyNames.ForChannels, (bool)forChannels);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<ChatAdministratorRights>(MethodNames.GetMyDefaultAdministratorRights, stream, cancellationToken).ConfigureAwait(false);
	}
}
