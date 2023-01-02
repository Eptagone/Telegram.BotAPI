// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.UpdatingMessages
{
	public static partial class UpdatingMessagesExtensions
	{
		/// <summary>Use this method to edit captions of messages.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
		public static Message EditMessageCaption(this BotClient? bot, EditMessageCaptionArgs args)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}
			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}
			return bot.RPC<Message>(MethodNames.EditMessageCaption, args);
		}

		/// <summary>Use this method to edit captions of messages.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
		public static async Task<Message> EditMessageCaptionAsync(this BotClient? bot, EditMessageCaptionArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}
			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}
			return await bot.RPCA<Message>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}
		/// <summary>Use this method to edit captions of messages.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
		/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
		public static T EditMessageCaption<T>(this BotClient? bot, EditMessageCaptionArgs args)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}
			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}
			return bot.RPC<T>(MethodNames.EditMessageCaption, args);
		}
		/// <summary>Use this method to edit captions of messages.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		/// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
		/// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
		public static async Task<T> EditMessageCaptionAsync<T>(this BotClient? bot, EditMessageCaptionArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}
			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}
			return await bot.RPCA<T>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message EditMessageCaption(this BotClient? api, long chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<Message>(MethodNames.EditMessageCaption, args);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message EditMessageCaption(this BotClient? api, string chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<Message>(MethodNames.EditMessageCaption, args);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> EditMessageCaptionAsync(this BotClient? api, long chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<Message>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> EditMessageCaptionAsync(this BotClient? api, string chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<Message>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message EditMessageCaption(this BotClient? api, string inlineMessageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new EditMessageCaptionArgs(inlineMessageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<Message>(MethodNames.EditMessageCaption, args);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<Message> EditMessageCaptionAsync(this BotClient? api, string inlineMessageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new EditMessageCaptionArgs(inlineMessageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<Message>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}

		// Generics

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static T EditMessageCaption<T>(this BotClient? api, long chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}

			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<T>(MethodNames.EditMessageCaption, args);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static T EditMessageCaption<T>(this BotClient? api, string chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}
			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<T>(MethodNames.EditMessageCaption, args);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<T> EditMessageCaptionAsync<T>(this BotClient? api, long chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}
			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<T>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Required if inline_message_id is not specified. Identifier of the message to edit.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<T> EditMessageCaptionAsync<T>(this BotClient? api, string chatId, int messageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}
			var args = new EditMessageCaptionArgs(chatId, messageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<T>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static T EditMessageCaption<T>(this BotClient? api, string inlineMessageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}
			var args = new EditMessageCaptionArgs(inlineMessageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return api.RPC<T>(MethodNames.EditMessageCaption, args);
		}

		/// <summary>Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="inlineMessageId">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
		/// <param name="caption">New caption of the message, 0-1024 characters after entities parsing.</param>
		/// <param name="parseMode">Mode for parsing entities in the message caption. See formatting options for more details.</param>
		/// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
		/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<T> EditMessageCaptionAsync<T>(this BotClient? api, string inlineMessageId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] InlineKeyboardMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool))
			{
				throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
			}
			var args = new EditMessageCaptionArgs(inlineMessageId)
			{
				Caption = caption,
				ParseMode = parseMode,
				CaptionEntities = captionEntities,
				ReplyMarkup = replyMarkup
			};
			return await api.RPCA<T>(MethodNames.EditMessageCaption, args, cancellationToken).ConfigureAwait(false);
		}
	}
}