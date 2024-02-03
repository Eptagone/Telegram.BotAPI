// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Games;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class GamesExtensions
{
    /// <summary>
    /// Use this method to get data for high score tables. Will return the score of the specified user and several of their neighbors in a game. Returns an Array of <see cref="GameHighScore"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Target user id</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the sent message</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<GameHighScore> GetGameHighScores(this ITelegramBotClient client, long userId, long? chatId = null, int? messageId = null, string? inlineMessageId = null) =>
        client.GetGameHighScoresAsync(userId, chatId, messageId, inlineMessageId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get data for high score tables. Will return the score of the specified user and several of their neighbors in a game. Returns an Array of <see cref="GameHighScore"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Target user id</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the sent message</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<GameHighScore>> GetGameHighScoresAsync(this ITelegramBotClient client, long userId, long? chatId = null, int? messageId = null, string? inlineMessageId = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId }
        };
        if (chatId is not null)
        {
            args.Add(PropertyNames.ChatId, chatId);
        }
        if (messageId is not null)
        {
            args.Add(PropertyNames.MessageId, messageId);
        }
        if (inlineMessageId is not null)
        {
            args.Add(PropertyNames.InlineMessageId, inlineMessageId);
        }

        return client.CallMethodAsync<IEnumerable<GameHighScore>>(MethodNames.GetGameHighScores, args, cancellationToken);
    }
}
