// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to send an answer to a query from a widget. The query must be answered within 15 seconds. The answer is received only by the widget that sent the query and doesn't change data of the widget; use <a href="https://core.telegram.org/bots/api#editmessagewidgetdata">editMessageWidgetData</a> or <a href="https://core.telegram.org/bots/api#editsharedwidgetdata">editSharedWidgetData</a> to change it. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="widgetQueryId">Unique identifier for the query to be answered</param>
    /// <param name="data">Data to be returned to the widget, 0-1024 bytes</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerWidgetQuery(this ITelegramBotClient client, string widgetQueryId, string? data = null) =>
        client.AnswerWidgetQueryAsync(widgetQueryId, data).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send an answer to a query from a widget. The query must be answered within 15 seconds. The answer is received only by the widget that sent the query and doesn't change data of the widget; use <a href="https://core.telegram.org/bots/api#editmessagewidgetdata">editMessageWidgetData</a> or <a href="https://core.telegram.org/bots/api#editsharedwidgetdata">editSharedWidgetData</a> to change it. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="widgetQueryId">Unique identifier for the query to be answered</param>
    /// <param name="data">Data to be returned to the widget, 0-1024 bytes</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerWidgetQueryAsync(this ITelegramBotClient client, string widgetQueryId, string? data = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.WidgetQueryId, widgetQueryId ?? throw new ArgumentNullException(nameof(widgetQueryId)) }
        };
        if (data is not null)
        {
            args.Add(PropertyNames.Data, data);
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerWidgetQuery, args, cancellationToken);
    }
}
