// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>Available Methods</summary>
public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to change the chosen reactions on a message. Service messages can't be reacted to. Automatically forwarded messages from a channel to its discussion group have the same available reactions as messages in the channel. In albums, bots must react to the first message. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the target message.</param>
	/// <param name="reaction">New list of reaction types to set on the message. Currently, as non-premium users, bots can set up to one reaction per message. A custom emoji reaction can be used if it is either already present on the message or explicitly allowed by chat administrators.</param>
	/// <param name="isBig">Pass True to set the reaction with a big animation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetMessageReaction(this ITelegramBotClient client, long chatId, int messageId, IEnumerable<ReactionType>? reaction = null, bool? isBig = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SetMessageReactionArgs(chatId, messageId)
		{
			Reaction = reaction,
			IsBig = isBig
		};
		return client.CallMethod<bool>(MethodNames.SetMessageReaction, args);
	}

	/// <summary>
	/// Use this method to change the chosen reactions on a message. Service messages can't be reacted to. Automatically forwarded messages from a channel to its discussion group have the same available reactions as messages in the channel. In albums, bots must react to the first message. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the target message.</param>
	/// <param name="reaction">New list of reaction types to set on the message. Currently, as non-premium users, bots can set up to one reaction per message. A custom emoji reaction can be used if it is either already present on the message or explicitly allowed by chat administrators.</param>
	/// <param name="isBig">Pass True to set the reaction with a big animation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool SetMessageReaction(this ITelegramBotClient client, string chatId, int messageId, IEnumerable<ReactionType>? reaction = null, bool? isBig = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SetMessageReactionArgs(chatId, messageId)
		{
			Reaction = reaction,
			IsBig = isBig
		};
		return client.CallMethod<bool>(MethodNames.SetMessageReaction, args);
	}

	/// <summary>
	/// Use this method to change the chosen reactions on a message. Service messages can't be reacted to. Automatically forwarded messages from a channel to its discussion group have the same available reactions as messages in the channel. In albums, bots must react to the first message. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the target message.</param>
	/// <param name="reaction">New list of reaction types to set on the message. Currently, as non-premium users, bots can set up to one reaction per message. A custom emoji reaction can be used if it is either already present on the message or explicitly allowed by chat administrators.</param>
	/// <param name="isBig">Pass True to set the reaction with a big animation.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetMessageReactionAsync(this ITelegramBotClient client, long chatId, int messageId, IEnumerable<ReactionType>? reaction = null, bool? isBig = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SetMessageReactionArgs(chatId, messageId)
		{
			Reaction = reaction,
			IsBig = isBig
		};
		return await client.CallMethodAsync<bool>(MethodNames.SetMessageReaction, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to change the chosen reactions on a message. Service messages can't be reacted to. Automatically forwarded messages from a channel to its discussion group have the same available reactions as messages in the channel. In albums, bots must react to the first message. Returns True on success.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="messageId">Identifier of the target message.</param>
	/// <param name="reaction">New list of reaction types to set on the message. Currently, as non-premium users, bots can set up to one reaction per message. A custom emoji reaction can be used if it is either already present on the message or explicitly allowed by chat administrators.</param>
	/// <param name="isBig">Pass True to set the reaction with a big animation.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> SetMessageReactionAsync(this ITelegramBotClient client, string chatId, int messageId, IEnumerable<ReactionType>? reaction = null, bool? isBig = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SetMessageReactionArgs(chatId, messageId)
		{
			Reaction = reaction,
			IsBig = isBig
		};
		return await client.CallMethodAsync<bool>(MethodNames.SetMessageReaction, args, cancellationToken).ConfigureAwait(false);
	}
}
