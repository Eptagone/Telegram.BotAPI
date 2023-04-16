// Copyright (c) 2023 Quetzal Rivera.
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
	public static Message SendContact(this BotClient? bot, SendContactArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.RPC<Message>(MethodNames.SendContact, args);
	}
	/// <summary>Use this method to send phone contacts. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>Message Object.</returns>
	public static async Task<Message> SendContactAsync(this BotClient? bot, SendContactArgs args, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.RPCA<Message>(MethodNames.SendContact, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendContact(this BotClient? api, long chatId, string phoneNumber, string firstName, [Optional] int? messageThreadId, [Optional] string? lastName, [Optional] string? vcard, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return api.RPC<Message>(MethodNames.SendContact, args);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendContact(this BotClient? api, string chatId, string phoneNumber, string firstName, [Optional] int? messageThreadId, [Optional] string? lastName, [Optional] string? vcard, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return api.RPC<Message>(MethodNames.SendContact, args);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendContactAsync(this BotClient? api, long chatId, string phoneNumber, string firstName, [Optional] int? messageThreadId, [Optional] string? lastName, [Optional] string? vcard, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return await api.RPCA<Message>(MethodNames.SendContact, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send phone contacts. On success, the sent Message is returned.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="phoneNumber">Contact's phone number.</param>
	/// <param name="firstName">Contact's first name.</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="lastName">Contact's last name.</param>
	/// <param name="vcard">Additional data about the contact in the form of a vCard, 0-2048 bytes.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
	/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
	/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendContactAsync(this BotClient? api, string chatId, string phoneNumber, string firstName, [Optional] int? messageThreadId, [Optional] string? lastName, [Optional] string? vcard, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new SendContactArgs(chatId, phoneNumber, firstName)
		{
			MessageThreadId = messageThreadId,
			LastName = lastName,
			Vcard = vcard,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyToMessageId = replyToMessageId,
			AllowSendingWithoutReply = allowSendingWithoutReply,
			ReplyMarkup = replyMarkup
		};
		return await api.RPCA<Message>(MethodNames.SendContact, args, cancellationToken).ConfigureAwait(false);
	}
}
