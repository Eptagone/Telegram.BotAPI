// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Collections;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

public partial class TelegramBotClient : ITelegramBotClient
{
    internal static readonly JsonSerializerOptions SerializerOptions =
        new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

    private async Task<TResult?> CallApiMethodAndGetResultAsync<TResult>(
        string method,
        object? args = null,
        CancellationToken cancellationToken = default
    )
    {
        BotResponse<TResult>? response = null;

        do
        {
            if (response is not null)
            {
                int retryAfter = response.Parameters?.RetryAfter ?? 1;
                await Task.Delay(retryAfter * 1000, cancellationToken).ConfigureAwait(false);
            }

            response = await this.CallApiMethodAsync<TResult>(method, args, cancellationToken)
                .ConfigureAwait(false);
        }
        // Try again and again if the error code is 429 (Too Many Requests and AutoRetryOnRateLimit is true)
        while (response.ErrorCode == 429 && this.options.AutoRetryOnRateLimit);

        if (response.Ok)
        {
            return response.Result;
        }

        if (this.options.IgnoreBotExceptions)
        {
            return default;
        }

        if (response.ErrorCode is null || response.Description is null)
        {
            throw new JsonException("Cannot deserialize the response error.");
        }

        throw new BotRequestException(
            (int)response.ErrorCode,
            response.Description,
            response.Parameters
        );
    }

    private async Task<BotResponse<TReturn>> CallApiMethodAsync<TReturn>(
        string method,
        object? args = null,
        CancellationToken cancellationToken = default
    )
    {
        string requestUri = this.options.UseTestEnvironment
            ? $"bot{this.options.BotToken}/test/{method}"
            : $"bot{this.options.BotToken}/{method}";

        if (this.httpClient.BaseAddress?.AbsoluteUri != this.options.ServerAddress)
        {
            requestUri = $"{this.options.ServerAddress}/{requestUri}";
        }

        HttpRequestMessage requestMessage;

        if (args is null)
        {
            requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        }
        else if (args.GetType().IsPrimitive || args is string)
        {
            throw new ArgumentException("The method arguments must be an object.");
        }
        else if (args is Stream streamArgs)
        {
            StreamContent content = new(streamArgs);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = content,
            };
        }
        else if (ArgsHasFiles(args))
        {
            MultipartFormDataContent content = CreateFormDataFromObject(args);
            requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = content,
            };
        }
        else
        {
            MemoryStream stream = new();
            await JsonSerializer
                .SerializeAsync(stream, args, args.GetType(), SerializerOptions, cancellationToken)
                .ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            StreamContent content = new(stream);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = content,
            };
        }

        HttpResponseMessage? response = await this
            .httpClient.SendAsync(requestMessage, cancellationToken)
            .ConfigureAwait(false);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException)
        {
            if (response.Content.Headers.ContentType.MediaType != "application/json")
            {
                throw;
            }
        }

        Stream? responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        BotResponse<TReturn>? botResponse = await JsonSerializer
            .DeserializeAsync<BotResponse<TReturn>>(
                responseStream,
                SerializerOptions,
                cancellationToken
            )
            .ConfigureAwait(false);

        return botResponse ?? throw new JsonException("Cannot deserialize the response.");
    }

    private static MultipartFormDataContent CreateFormDataFromObject(object args)
    {
        MultipartFormDataContent content = new(Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks);

        // If the value is an enumerable, add each item to the content.
        if (args is IDictionary<string, object> dictionary)
        {
            foreach (KeyValuePair<string, object> item in dictionary)
            {
                if (item.Value is null)
                {
                    continue;
                }

                if (item.Value.GetType().IsPrimitive || item.Value is string)
                {
                    content.Add(new StringContent(item.Value.ToString()), item.Key);
                }
                else
                {
                    switch (item.Value)
                    {
                        case InputFile inputFile:
                            content.Add(inputFile.Content, item.Key, inputFile.Filename);
                            break;
                        case IDictionary<string, InputFile> files:
                        {
                            foreach (KeyValuePair<string, InputFile> file in files)
                            {
                                content.Add(file.Value.Content, file.Key, file.Value.Filename);
                            }

                            break;
                        }
                        default:
                        {
                            string json = JsonSerializer.Serialize(item.Value, SerializerOptions);
                            content.Add(new StringContent(json, Encoding.UTF8), item.Key);
                            break;
                        }
                    }
                }
            }
        }
        else
        {
            PropertyInfo[] properties = args.GetType().GetProperties();

            foreach (PropertyInfo? property in properties)
            {
                object? value = property.GetValue(args);
                if (value is null)
                {
                    continue;
                }

                JsonPropertyNameAttribute? jsonAttribute =
                    property.GetCustomAttribute<JsonPropertyNameAttribute>();
                if (jsonAttribute is not null)
                {
                    if (value.GetType().IsPrimitive || value is string)
                    {
                        content.Add(new StringContent(value.ToString()), jsonAttribute.Name);
                    }
                    else if (value is InputFile inputFile)
                    {
                        content.Add(inputFile.Content, jsonAttribute.Name, inputFile.Filename);
                    }
                    else
                    {
                        string json = JsonSerializer.Serialize(value, SerializerOptions);
                        content.Add(new StringContent(json, Encoding.UTF8), jsonAttribute.Name);
                    }
                }
                else
                {
                    if (value is not IDictionary<string, InputFile> files)
                    {
                        continue;
                    }

                    foreach (KeyValuePair<string, InputFile> file in files)
                    {
                        content.Add(file.Value.Content, file.Key, file.Value.Filename);
                    }
                }
            }
        }

        return content;
    }

    private static bool ArgsHasFiles(object args)
    {
        if (args is IEnumerable)
        {
            if (args is not IDictionary<string, object> items)
            {
                return false;
            }

            foreach (KeyValuePair<string, object> item in items)
            {
                switch (item.Value)
                {
                    case IDictionary<string, InputFile> files when files.Any():
                    case InputFile:
                        return true;
                }
            }
        }
        else
        {
            PropertyInfo[] properties = args.GetType().GetProperties();

            foreach (PropertyInfo? property in properties)
            {
                object? value = property.GetValue(args);
                if (value is null || value.GetType().IsPrimitive || value is string)
                {
                    continue;
                }

                switch (value)
                {
                    case InputFile:
                    case IDictionary<string, InputFile> files when files.Any():
                        return true;
                }
            }
        }

        return false;
    }
}
