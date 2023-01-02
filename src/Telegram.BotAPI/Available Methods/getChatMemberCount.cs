// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static uint GetChatMemberCount(this BotClient? bot, long chatId)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<uint>(MethodNames.GetChatMemberCount, stream);
		}
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static uint GetChatMemberCount(this BotClient? bot, string chatId)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<uint>(MethodNames.GetChatMemberCount, stream);
		}
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<uint> GetChatMemberCountAsync(this BotClient? bot, long chatId, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<uint>(MethodNames.GetChatMemberCount, stream, cancellationToken).ConfigureAwait(false);
		}
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<uint> GetChatMemberCountAsync(this BotClient? bot, string chatId, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<uint>(MethodNames.GetChatMemberCount, stream, cancellationToken).ConfigureAwait(false);
		}

		#region getChatMembersCount Obsolete
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		[Obsolete("This method has been replaced by GetChatMemberCount and will be removed in future releases.")]
		public static uint GetChatMembersCount(this BotClient? bot, long chatId)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<uint>(MethodNames.GetChatMembersCount, stream);
		}
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		[Obsolete("This method has been replaced by GetChatMemberCount and will be removed in future releases.")]
		public static uint GetChatMembersCount(this BotClient? bot, string chatId)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<uint>(MethodNames.GetChatMembersCount, stream);
		}
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		[Obsolete("This method has been replaced by GetChatMemberCountAsync and will be removed in future releases.")]
		public static async Task<uint> GetChatMembersCountAsync(this BotClient? bot, long chatId, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<uint>(MethodNames.GetChatMembersCount, stream, cancellationToken).ConfigureAwait(false);
		}
		/// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		[Obsolete("This method has been replaced by GetChatMemberCountAsync and will be removed in future releases.")]
		public static async Task<uint> GetChatMembersCountAsync(this BotClient? bot, string chatId, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<uint>(MethodNames.GetChatMembersCount, stream, cancellationToken).ConfigureAwait(false);
		}
		#endregion
	}
}