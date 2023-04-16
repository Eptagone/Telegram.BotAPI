// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using File = Telegram.BotAPI.AvailableTypes.File;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="fileId">File identifier to get info about.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="File"/></returns>
	public static File GetFile(this BotClient? bot, string fileId)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.FileId, fileId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<File>(MethodNames.GetFile, stream);
	}
	/// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="fileId">File identifier to get info about.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="File"/></returns>
	public static async Task<File> GetFileAsync(this BotClient? bot, string fileId, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.FileId, fileId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<File>(MethodNames.GetFile, stream, cancellationToken).ConfigureAwait(false);
	}
}