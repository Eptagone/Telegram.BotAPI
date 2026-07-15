// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class RichMessagesExtensions
{
    /// <summary>
    /// Use this method to stream a partial rich message to a user while the message is being generated. Note that the streamed draft is ephemeral and acts as a temporary 30-second preview - once the output is finalized, you <strong>must</strong> call <a href="https://core.telegram.org/bots/api#sendrichmessage">sendRichMessage</a> with the complete message to persist it in the user's chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendRichMessageDraft" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendRichMessageDraft(this ITelegramBotClient client, SendRichMessageDraftArgs args) =>
        client.SendRichMessageDraftAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stream a partial rich message to a user while the message is being generated. Note that the streamed draft is ephemeral and acts as a temporary 30-second preview - once the output is finalized, you <strong>must</strong> call <a href="https://core.telegram.org/bots/api#sendrichmessage">sendRichMessage</a> with the complete message to persist it in the user's chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendRichMessageDraft" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendRichMessageDraftAsync(this ITelegramBotClient client, SendRichMessageDraftArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SendRichMessageDraft, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to stream a partial rich message to a user while the message is being generated. Note that the streamed draft is ephemeral and acts as a temporary 30-second preview - once the output is finalized, you <strong>must</strong> call <a href="https://core.telegram.org/bots/api#sendrichmessage">sendRichMessage</a> with the complete message to persist it in the user's chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat</param>
    /// <param name="draftId">Unique identifier of the message draft; must be non-zero. Changes to drafts with the same identifier are animated.</param>
    /// <param name="richMessage">The partial message to be streamed. Direct upload of new files isn't supported.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread</param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendRichMessageDraft(this ITelegramBotClient client, long chatId, int draftId, InputRichMessage richMessage, int? messageThreadId = null, IDictionary<string, InputFile>? files = null) =>
        client.SendRichMessageDraftAsync(chatId, draftId, richMessage, messageThreadId, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stream a partial rich message to a user while the message is being generated. Note that the streamed draft is ephemeral and acts as a temporary 30-second preview - once the output is finalized, you <strong>must</strong> call <a href="https://core.telegram.org/bots/api#sendrichmessage">sendRichMessage</a> with the complete message to persist it in the user's chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat</param>
    /// <param name="draftId">Unique identifier of the message draft; must be non-zero. Changes to drafts with the same identifier are animated.</param>
    /// <param name="richMessage">The partial message to be streamed. Direct upload of new files isn't supported.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread</param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendRichMessageDraftAsync(this ITelegramBotClient client, long chatId, int draftId, InputRichMessage richMessage, int? messageThreadId = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.DraftId, draftId },
            { PropertyNames.RichMessage, richMessage ?? throw new ArgumentNullException(nameof(richMessage)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (files is not null)
        {
            foreach (var file in files)
            {
                args.Add(file.Key, file.Value);
            }
        }

        return client.CallMethodAsync<bool>(MethodNames.SendRichMessageDraft, args, cancellationToken);
    }
}
