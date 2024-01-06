// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to send phone contacts. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static Message SendContact(this ITelegramBotClient bot, SendContactArgs args)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.CallMethod<Message>(MethodNames.SendContact, args);
	}
	/// <summary>Use this method to send phone contacts. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static async Task<Message> SendContactAsync(this ITelegramBotClient bot, SendContactArgs args, CancellationToken cancellationToken = default)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<Message>(MethodNames.SendContact, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendContact(this ITelegramBotClient client, long chatId, string phoneNumber, string firstName, int? messageThreadId = null, string? lastName = null, string? vcard = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendContact, args);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendContact(this ITelegramBotClient client, string chatId, string phoneNumber, string firstName, int? messageThreadId = null, string? lastName = null, string? vcard = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendContact, args);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendContactAsync(this ITelegramBotClient client, long chatId, string phoneNumber, string firstName, int? messageThreadId = null, string? lastName = null, string? vcard = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendContact, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendContactAsync(this ITelegramBotClient client, string chatId, string phoneNumber, string firstName, int? messageThreadId = null, string? lastName = null, string? vcard = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendContact, args, cancellationToken).ConfigureAwait(false);
	}
}
