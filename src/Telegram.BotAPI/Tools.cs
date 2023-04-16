// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI;

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

	/// <summary>
	/// Gets the depth of an enumerable.
	/// </summary>
	/// <typeparam name="T">Type of the enumerable</typeparam>
	/// <param name="enumerable">The enumerable value</param>
	/// <returns>The depth of the enumerator.</returns>
	internal static uint GetDepth<T>(IEnumerable<T> enumerable)
	{
		// Base case: if the enumerable is empty or null, return 0
		if (enumerable == null || !enumerable.Any())
			return 0;

		// Get the first element of the enumerable
		var first = enumerable.First();

		// If the first element is also an IEnumerable, add 1 and recurse on it
		if (first is IEnumerable<object> innerEnumerable)
			return 1u + GetDepth(innerEnumerable);

		// Otherwise, return 1 as the depth of the enumerable
		return 1;
	}
}
