// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Inline mode</summary>
    public static partial class InlineModeExtensions
    {
        /// <summary>Use this method to set the result of an interaction with a Web App and send a corresponding message on behalf of the user to the chat from which the query originated. On success, a SentWebAppMessage object is returned.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="webAppQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="result">A JSON-serialized object describing the message to be sent.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static SentWebAppMessage AnswerWebAppQuery(this BotClient api, string webAppQueryId, InlineQueryResult result)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AnswerWebAppQueryArgs(webAppQueryId, result);
            return api.RPC<SentWebAppMessage>(MethodNames.AnswerWebAppQuery, args);
        }

        /// <summary>Use this method to set the result of an interaction with a Web App and send a corresponding message on behalf of the user to the chat from which the query originated. On success, a SentWebAppMessage object is returned.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="webAppQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="result">A JSON-serialized object describing the message to be sent.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<SentWebAppMessage> AnswerWebAppQueryAsync(this BotClient api, string webAppQueryId, InlineQueryResult result, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AnswerWebAppQueryArgs(webAppQueryId, result);
            return await api.RPCA<SentWebAppMessage>(MethodNames.AnswerWebAppQuery, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
