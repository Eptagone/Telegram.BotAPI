// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;

namespace Telegram.BotAPI;

internal static class Tools
{
	internal static async Task<Stream> SerializeAsStreamAsync(
		object args,
		[Optional] JsonSerializerOptions options,
		[Optional] CancellationToken cancellationToken
	)
	{
		if (options == default)
		{
			options = TelegramBotClient.SerializerOptions;
		}
		var stream = new MemoryStream();
		await JsonSerializer
			.SerializeAsync(stream, args, args.GetType(), options, cancellationToken)
			.ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return stream;
	}
}
