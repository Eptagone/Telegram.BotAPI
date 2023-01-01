// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="permissions">New default chat permissions.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool SetChatPermissions(this BotClient? bot, long chatId, ChatPermissions permissions)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (permissions == null)
			{
				throw new ArgumentNullException(nameof(permissions));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteStartObject(PropertyNames.Permissions);
			if (permissions.CanSendMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMessages, true);
			}

			if (permissions.CanSendMediaMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMediaMessages, true);
			}

			if (permissions.CanSendPolls != null)
			{
				json.WriteBoolean(PropertyNames.CanSendPolls, true);
			}

			if (permissions.CanSendOtherMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendOtherMessages, true);
			}

			if (permissions.CanAddWebPagePreviews != null)
			{
				json.WriteBoolean(PropertyNames.CanAddWebPagePreviews, true);
			}

			if (permissions.CanChangeInfo != null)
			{
				json.WriteBoolean(PropertyNames.CanChangeInfo, true);
			}

			if (permissions.CanInviteUsers != null)
			{
				json.WriteBoolean(PropertyNames.CanInviteUsers, true);
			}

			if (permissions.CanPinMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanPinMessages, true);
			}

			json.WriteEndObject();
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<bool>(MethodNames.SetChatPermissions, stream);
		}
		/// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="permissions">New default chat permissions.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool SetChatPermissions(this BotClient? bot, string chatId, ChatPermissions permissions)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (permissions == default)
			{
				throw new ArgumentNullException(nameof(permissions));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteStartObject(PropertyNames.Permissions);
			if (permissions.CanSendMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMessages, true);
			}

			if (permissions.CanSendMediaMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMediaMessages, true);
			}

			if (permissions.CanSendPolls != null)
			{
				json.WriteBoolean(PropertyNames.CanSendPolls, true);
			}

			if (permissions.CanSendOtherMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendOtherMessages, true);
			}

			if (permissions.CanAddWebPagePreviews != null)
			{
				json.WriteBoolean(PropertyNames.CanAddWebPagePreviews, true);
			}

			if (permissions.CanChangeInfo != null)
			{
				json.WriteBoolean(PropertyNames.CanChangeInfo, true);
			}

			if (permissions.CanInviteUsers != null)
			{
				json.WriteBoolean(PropertyNames.CanInviteUsers, true);
			}

			if (permissions.CanPinMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanPinMessages, true);
			}

			json.WriteEndObject();
			json.WriteEndObject();
			json.Flush(); json.Dispose();
			stream.Seek(0, SeekOrigin.Begin);
			return bot.RPC<bool>(MethodNames.SetChatPermissions, stream);
		}
		/// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="permissions">New default chat permissions.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> SetChatPermissionsAsync(this BotClient? bot, long chatId, ChatPermissions permissions, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (permissions == default)
			{
				throw new ArgumentNullException(nameof(permissions));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteNumber(PropertyNames.ChatId, chatId);
			json.WriteStartObject(PropertyNames.Permissions);
			if (permissions.CanSendMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMessages, true);
			}

			if (permissions.CanSendMediaMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMediaMessages, true);
			}

			if (permissions.CanSendPolls != null)
			{
				json.WriteBoolean(PropertyNames.CanSendPolls, true);
			}

			if (permissions.CanSendOtherMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendOtherMessages, true);
			}

			if (permissions.CanAddWebPagePreviews != null)
			{
				json.WriteBoolean(PropertyNames.CanAddWebPagePreviews, true);
			}

			if (permissions.CanChangeInfo != null)
			{
				json.WriteBoolean(PropertyNames.CanChangeInfo, true);
			}

			if (permissions.CanInviteUsers != null)
			{
				json.WriteBoolean(PropertyNames.CanInviteUsers, true);
			}

			if (permissions.CanPinMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanPinMessages, true);
			}

			json.WriteEndObject();
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<bool>(MethodNames.SetChatPermissions, stream, cancellationToken).ConfigureAwait(false);
		}
		/// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
		/// <param name="permissions">New default chat permissions.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> SetChatPermissionsAsync(this BotClient? bot, string chatId, ChatPermissions permissions, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (permissions == default)
			{
				throw new ArgumentNullException(nameof(permissions));
			}

			var stream = new MemoryStream();
			using var json = new Utf8JsonWriter(stream);
			json.WriteStartObject();
			json.WriteString(PropertyNames.ChatId, chatId);
			json.WriteStartObject(PropertyNames.Permissions);
			if (permissions.CanSendMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMessages, true);
			}

			if (permissions.CanSendMediaMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendMediaMessages, true);
			}

			if (permissions.CanSendPolls != null)
			{
				json.WriteBoolean(PropertyNames.CanSendPolls, true);
			}

			if (permissions.CanSendOtherMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanSendOtherMessages, true);
			}

			if (permissions.CanAddWebPagePreviews != null)
			{
				json.WriteBoolean(PropertyNames.CanAddWebPagePreviews, true);
			}

			if (permissions.CanChangeInfo != null)
			{
				json.WriteBoolean(PropertyNames.CanChangeInfo, true);
			}

			if (permissions.CanInviteUsers != null)
			{
				json.WriteBoolean(PropertyNames.CanInviteUsers, true);
			}

			if (permissions.CanPinMessages != null)
			{
				json.WriteBoolean(PropertyNames.CanPinMessages, true);
			}

			json.WriteEndObject();
			json.WriteEndObject();
			await json.FlushAsync(cancellationToken).ConfigureAwait(false);
			await json.DisposeAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);
			return await bot.RPCA<bool>(MethodNames.SetChatPermissions, stream, cancellationToken).ConfigureAwait(false);
		}
	}
}
