// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to edit public data of a shared widget created by the bot. A shared widget can be edited at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="widgetId">Unique identifier of the shared widget</param>
    /// <param name="publicData">New public data of the widget, 0-1024 bytes; pass an empty string to remove the public data</param>
    /// <param name="cacheTime">The maximum amount of time in seconds that the public data of the widget may be cached client-side; 5-3600. If omitted, then the current value is kept, which is 30 by default.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditSharedWidgetData(this ITelegramBotClient client, string widgetId, string publicData, int? cacheTime = null) =>
        client.EditSharedWidgetDataAsync(widgetId, publicData, cacheTime).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit public data of a shared widget created by the bot. A shared widget can be edited at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="widgetId">Unique identifier of the shared widget</param>
    /// <param name="publicData">New public data of the widget, 0-1024 bytes; pass an empty string to remove the public data</param>
    /// <param name="cacheTime">The maximum amount of time in seconds that the public data of the widget may be cached client-side; 5-3600. If omitted, then the current value is kept, which is 30 by default.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditSharedWidgetDataAsync(this ITelegramBotClient client, string widgetId, string publicData, int? cacheTime = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.WidgetId, widgetId ?? throw new ArgumentNullException(nameof(widgetId)) },
            { PropertyNames.PublicData, publicData ?? throw new ArgumentNullException(nameof(publicData)) }
        };
        if (cacheTime is not null)
        {
            args.Add(PropertyNames.CacheTime, cacheTime);
        }

        return client.CallMethodAsync<bool>(MethodNames.EditSharedWidgetData, args, cancellationToken);
    }
}
