// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class GamesExtensions
{
    /// <summary>
    /// Use this method to set the score of the specified user in a game message. On success, if the message is not an inline message, the <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Returns an error, if the new score is not greater than the user's current score in the chat and <em>force</em> is <em>False</em>.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetGameScore" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static TResult SetGameScore<TResult>(this ITelegramBotClient client, SetGameScoreArgs args) =>
        client.SetGameScoreAsync<TResult>(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set the score of the specified user in a game message. On success, if the message is not an inline message, the <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Returns an error, if the new score is not greater than the user's current score in the chat and <em>force</em> is <em>False</em>.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetGameScore" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<TResult> SetGameScoreAsync<TResult>(this ITelegramBotClient client, SetGameScoreArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<TResult>(MethodNames.SetGameScore, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to set the score of the specified user in a game message. On success, if the message is not an inline message, the <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Returns an error, if the new score is not greater than the user's current score in the chat and <em>force</em> is <em>False</em>.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier</param>
    /// <param name="score">New score, must be non-negative</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the sent message</param>
    /// <param name="force">Pass <em>True</em> if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters</param>
    /// <param name="disableEditMessage">Pass <em>True</em> if the game message should not be automatically edited to include the current scoreboard</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SetGameScore(this ITelegramBotClient client, long userId, int score, long chatId, int messageId, bool? force = null, bool? disableEditMessage = null) =>
        client.SetGameScoreAsync(userId, score, chatId, messageId, force, disableEditMessage).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set the score of the specified user in a game message. On success, if the message is not an inline message, the <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Returns an error, if the new score is not greater than the user's current score in the chat and <em>force</em> is <em>False</em>.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier</param>
    /// <param name="score">New score, must be non-negative</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the sent message</param>
    /// <param name="force">Pass <em>True</em> if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters</param>
    /// <param name="disableEditMessage">Pass <em>True</em> if the game message should not be automatically edited to include the current scoreboard</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SetGameScoreAsync(this ITelegramBotClient client, long userId, int score, long chatId, int messageId, bool? force = null, bool? disableEditMessage = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.Score, score },
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId }
        };
        if (force is not null)
        {
            args.Add(PropertyNames.Force, force);
        }
        if (disableEditMessage is not null)
        {
            args.Add(PropertyNames.DisableEditMessage, disableEditMessage);
        }

        return client.CallMethodAsync<Message>(MethodNames.SetGameScore, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to set the score of the specified user in a game message. On success, if the message is not an inline message, the <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Returns an error, if the new score is not greater than the user's current score in the chat and <em>force</em> is <em>False</em>.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier</param>
    /// <param name="score">New score, must be non-negative</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="force">Pass <em>True</em> if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters</param>
    /// <param name="disableEditMessage">Pass <em>True</em> if the game message should not be automatically edited to include the current scoreboard</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetGameScore(this ITelegramBotClient client, long userId, int score, string inlineMessageId, bool? force = null, bool? disableEditMessage = null) =>
        client.SetGameScoreAsync(userId, score, inlineMessageId, force, disableEditMessage).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set the score of the specified user in a game message. On success, if the message is not an inline message, the <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Returns an error, if the new score is not greater than the user's current score in the chat and <em>force</em> is <em>False</em>.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier</param>
    /// <param name="score">New score, must be non-negative</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="force">Pass <em>True</em> if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters</param>
    /// <param name="disableEditMessage">Pass <em>True</em> if the game message should not be automatically edited to include the current scoreboard</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetGameScoreAsync(this ITelegramBotClient client, long userId, int score, string inlineMessageId, bool? force = null, bool? disableEditMessage = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.Score, score },
            { PropertyNames.InlineMessageId, inlineMessageId ?? throw new ArgumentNullException(nameof(inlineMessageId)) }
        };
        if (force is not null)
        {
            args.Add(PropertyNames.Force, force);
        }
        if (disableEditMessage is not null)
        {
            args.Add(PropertyNames.DisableEditMessage, disableEditMessage);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetGameScore, args, cancellationToken);
    }
}
