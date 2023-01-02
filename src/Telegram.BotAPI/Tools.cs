// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI
{
	internal static class Tools
	{
		internal static async Task<Stream> SerializeAsStreamAsync(object args, [Optional] JsonSerializerOptions options, [Optional] CancellationToken cancellationToken)
		{
			if (options == default)
			{
				options = BotClient.DefaultSerializerOptions;
			}
			var stream = new MemoryStream();
			await JsonSerializer.SerializeAsync(stream, args, args.GetType(), options, cancellationToken).ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return stream;
		}

		internal static bool IsNumber(this object value)
		{
			return value is sbyte
					|| value is byte
					|| value is short
					|| value is ushort
					|| value is int
					|| value is uint
					|| value is long
					|| value is ulong
					|| value is float
					|| value is double
					|| value is decimal;
		}
	}
}
