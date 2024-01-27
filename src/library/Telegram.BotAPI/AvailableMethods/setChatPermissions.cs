// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members administrator rights. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="permissions">A JSON-serialized object for new default chat permissions.</param>
	/// <param name="useIndependentChatPermissions">Pass True if chat permissions are set independently. Otherwise, the can_send_other_messages and can_add_web_page_previews permissions will imply the can_send_messages, can_send_audios, can_send_documents, can_send_photos, can_send_videos, can_send_video_notes, and can_send_voice_notes permissions; the can_send_polls permission will imply the can_send_messages permission.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetChatPermissions(this ITelegramBotClient api, long chatId, ChatPermissions permissions, [Optional] bool? useIndependentChatPermissions)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SetChatPermissionsArgs(chatId, permissions)
		{
			UseIndependentChatPermissions = useIndependentChatPermissions
		};
		return api.CallMethod<bool>(MethodNames.SetChatPermissions, args);
	}

	/// <summary>
	/// Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members administrator rights. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="permissions">A JSON-serialized object for new default chat permissions.</param>
	/// <param name="useIndependentChatPermissions">Pass True if chat permissions are set independently. Otherwise, the can_send_other_messages and can_add_web_page_previews permissions will imply the can_send_messages, can_send_audios, can_send_documents, can_send_photos, can_send_videos, can_send_video_notes, and can_send_voice_notes permissions; the can_send_polls permission will imply the can_send_messages permission.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetChatPermissions(this ITelegramBotClient api, string chatId, ChatPermissions permissions, [Optional] bool? useIndependentChatPermissions)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SetChatPermissionsArgs(chatId, permissions)
		{
			UseIndependentChatPermissions = useIndependentChatPermissions
		};
		return api.CallMethod<bool>(MethodNames.SetChatPermissions, args);
	}

	/// <summary>
	/// Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members administrator rights. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="permissions">A JSON-serialized object for new default chat permissions.</param>
	/// <param name="useIndependentChatPermissions">Pass True if chat permissions are set independently. Otherwise, the can_send_other_messages and can_add_web_page_previews permissions will imply the can_send_messages, can_send_audios, can_send_documents, can_send_photos, can_send_videos, can_send_video_notes, and can_send_voice_notes permissions; the can_send_polls permission will imply the can_send_messages permission.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetChatPermissionsAsync(this ITelegramBotClient api, long chatId, ChatPermissions permissions, [Optional] bool? useIndependentChatPermissions, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SetChatPermissionsArgs(chatId, permissions)
		{
			UseIndependentChatPermissions = useIndependentChatPermissions
		};
		return await api.CallMethodAsync<bool>(MethodNames.SetChatPermissions, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members administrator rights. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
	/// <param name="permissions">A JSON-serialized object for new default chat permissions.</param>
	/// <param name="useIndependentChatPermissions">Pass True if chat permissions are set independently. Otherwise, the can_send_other_messages and can_add_web_page_previews permissions will imply the can_send_messages, can_send_audios, can_send_documents, can_send_photos, can_send_videos, can_send_video_notes, and can_send_voice_notes permissions; the can_send_polls permission will imply the can_send_messages permission.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetChatPermissionsAsync(this ITelegramBotClient api, string chatId, ChatPermissions permissions, [Optional] bool? useIndependentChatPermissions, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SetChatPermissionsArgs(chatId, permissions)
		{
			UseIndependentChatPermissions = useIndependentChatPermissions
		};
		return await api.CallMethodAsync<bool>(MethodNames.SetChatPermissions, args, cancellationToken).ConfigureAwait(false);
	}
}
