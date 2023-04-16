// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to get a list of profile pictures for a user.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="offset">Optional. Sequential number of the first photo to be returned. By default, all photos are returned.</param>
	/// <param name="limit">Optional. Limits the number of photos to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>UserProfilePhotos Object.</returns>
	public static UserProfilePhotos GetUserProfilePhotos(
		this BotClient? bot,
		long userId,
		[Optional] int? offset,
		[Optional] ushort? limit)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.UserId, userId);
		if (offset != null)
		{
			json.WriteNumber(PropertyNames.Offset, (int)offset);
		}

		if (limit != null)
		{
			json.WriteNumber(PropertyNames.Limit, (ushort)limit);
		}

		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<UserProfilePhotos>(MethodNames.GetUserProfilePhotos, stream);
	}
	/// <summary>Use this method to get a list of profile pictures for a user.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
	/// <param name="limit">Limits the number of photos to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>UserProfilePhotos Object.</returns>
	public static async Task<UserProfilePhotos> GetUserProfilePhotosAsync(
		this BotClient? bot,
		long userId,
		[Optional] int? offset,
		[Optional] ushort? limit,
		[Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.UserId, userId);
		if (offset != null)
		{
			json.WriteNumber(PropertyNames.Offset, (int)offset);
		}

		if (limit != null)
		{
			json.WriteNumber(PropertyNames.Limit, (ushort)limit);
		}

		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<UserProfilePhotos>(MethodNames.GetUserProfilePhotos, stream, cancellationToken).ConfigureAwait(false);
	}
}