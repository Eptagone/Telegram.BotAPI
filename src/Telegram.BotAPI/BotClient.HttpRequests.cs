// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    public sealed partial class BotClient : IEquatable<BotClient>
    {
        internal static readonly JsonSerializerOptions DefaultSerializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        private const string applicationJson = "application/json";
        private const string multipartFormData = "multipart/form-data";

        /// <summary>Default HttpClient for bot requets.</summary>
        public static HttpClient defaultHttpClient { get; private set; }

        /// <summary>Set the default HttpClient for bot requets.</summary>
        /// <param name="client"><see cref="HttpClient"/> for http requets.</param>
        /// <exception cref="ArgumentNullException">Thrown when client is null.</exception>
        public static void SetHttpClient([Optional] HttpClient client)
        {
            defaultHttpClient = client ?? new HttpClient();
            AddJsonMultipart(defaultHttpClient);
        }

        private static HttpClient AddJsonMultipart(HttpClient client)
        {
            if (!client.DefaultRequestHeaders.Accept.Any(u => u.MediaType == applicationJson))
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(applicationJson));
            }
            if (!client.DefaultRequestHeaders.Accept.Any(u => u.MediaType == multipartFormData))
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(multipartFormData));
            }
            return client;
        }

        /// <summary>Makes a bot request using HTTP GET and returns the response.</summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="method">Method name. See <see cref="MethodNames"/></param>
        /// <returns><see cref="BotResponse{T}"/></returns>
        public BotResponse<T> GetRequest<T>(string method)
        {
            var response = GetRequestAsync<T>(method);
            try
            {
                return response.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }

        /// <summary>Makes a bot request using HTTP GET and returns the response.</summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="method">Method name. See <see cref="MethodNames"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns><see cref="BotResponse{T}"/></returns>
        public async Task<BotResponse<T>> GetRequestAsync<T>(string method, [Optional] CancellationToken cancellationToken)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.telegram.org/bot{Token}/{method}");
            return await SendRequestAsync<T>(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="method">Method name. See <see cref="MethodNames"/></param>
        /// <param name="args">json parameters</param>
        /// <param name="serializeOptions">Options to control serialization behavior.</param>
        /// <returns><see cref="BotResponse{T}"/></returns>
        public BotResponse<T> PostRequest<T>(string method, object args, [Optional] JsonSerializerOptions serializeOptions)
        {
            var response = PostRequestAsync<T>(method, args, serializeOptions);
            try
            {
                return response.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }

        /// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="method">Method name. See <see cref="MethodNames"/></param>
        /// <param name="args">json parameters</param>
        /// <param name="serializeOptions">Options to control serialization behavior.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns><see cref="BotResponse{T}"/></returns>
        public async Task<BotResponse<T>> PostRequestAsync<T>(string method, object args, [Optional] JsonSerializerOptions serializeOptions, [Optional] CancellationToken cancellationToken)
        {
            if (args == default)
            {
                throw new ArgumentException(nameof(args));
            }
            if (serializeOptions == default)
            {
                serializeOptions = DefaultSerializerOptions;
            }
            var stream = await Tools.SerializeAsStreamAsync(args, serializeOptions, cancellationToken)
                .ConfigureAwait(false);
            return await PostRequestAsync<T>(method, stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="method">Method name. See <see cref="MethodNames"/></param>
        /// <param name="args">json parameters</param>
        /// <returns><see cref="BotResponse{T}"/></returns>
        public BotResponse<T> PostRequest<T>(string method, Stream args)
        {
            var response = PostRequestAsync<T>(method, args);
            try
            {
                return response.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }

        /// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="method">Method name. See <see cref="MethodNames"/></param>
        /// <param name="args">json parameters</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns><see cref="BotResponse{T}"/></returns>
        public async Task<BotResponse<T>> PostRequestAsync<T>(string method, Stream args, [Optional] CancellationToken cancellationToken)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, $"https://api.telegram.org/bot{Token}/{method}")
            {
                Content = new StreamContent(args)
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue(applicationJson);
            return await SendRequestAsync<T>(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Makes a bot request using HTTP POST and Multipart Form Data and returns the response.</summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="method">Method name. See <see cref="MethodNames"/>.</param>
        /// <param name="args">Parameters encoded using multipart/form-data.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns><see cref="BotResponse{T}"/></returns>
        public async Task<BotResponse<T>> PostRequestAsyncMultipartFormData<T>(string method, MultipartFormDataContent args, CancellationToken cancellationToken)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, $"https://api.telegram.org/bot{Token}/{method}")
            {
                Content = args
            };
            return await SendRequestAsync<T>(request, cancellationToken).ConfigureAwait(false);
        }

        internal async Task<BotResponse<T>> SendRequestAsync<T>(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            try
            {
                response.EnsureSuccessStatusCode();
                var streamResponse = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                return await JsonSerializer.DeserializeAsync<BotResponse<T>>(streamResponse, cancellationToken: cancellationToken);
            }
            catch (HttpRequestException exp)
            {
                if (response.Content.Headers.ContentType.MediaType == applicationJson)
                {
                    var streamResponse = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                    return await JsonSerializer.DeserializeAsync<BotResponse<T>>(streamResponse, cancellationToken: cancellationToken);
                }
                else
                {
                    throw new BotRequestException(exp, response);
                }
            }
        }

        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        internal T RPC<T>(string method)
        {
            var response = GetRequest<T>(method);
            if (response.Ok)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description, response.Parameters);
                }
            }
        }

        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCA<T>(string method, [Optional] CancellationToken cancellationToken)
        {
            var response = await GetRequestAsync<T>(method, cancellationToken).ConfigureAwait(false);
            if (response.Ok == true)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description, response.Parameters);
                }
            }
        }

        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="options">Provides options to be used with JsonSerializer.Serialize.</param>
        internal T RPC<T>(string method, object args, [Optional] JsonSerializerOptions options)
        {
            var response = PostRequest<T>(method, args, options);
            if (response.Ok)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description, response.Parameters);
                }
            }
        }

        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        internal T RPC<T>(string method, Stream args)
        {
            var response = PostRequest<T>(method, args);
            if (response.Ok)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description, response.Parameters);
                }
            }
        }

        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCA<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] CancellationToken cancellationToken)
        {
            var response = await PostRequestAsync<T>(method, args, serializeoptions, cancellationToken: cancellationToken).ConfigureAwait(false);
            if (response.Ok)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description, response.Parameters);
                }
            }
        }

        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCA<T>(string method, Stream args, [Optional] CancellationToken cancellationToken)
        {
            var response = await PostRequestAsync<T>(method, args, cancellationToken).ConfigureAwait(false);
            if (response.Ok == true)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description, response.Parameters);
                }
            }
        }

        /// <summary>RPC for files</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        internal T RPCF<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions)
        {
            var rpcf = RPCAF<T>(method, args, serializeoptions, default);
            try
            {
                return rpcf.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }

        /// <summary>RPC async for files</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCAF<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] CancellationToken cancellationToken)
        {
            var properties = args.GetType().GetProperties();
            using var content = new MultipartFormDataContent(Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks);
            foreach (var prop in properties)
            {
                var value = prop.GetValue(args);
                if (value != default)
                {
                    var jsonattribs = (JsonPropertyNameAttribute[])prop.GetCustomAttributes(typeof(JsonPropertyNameAttribute), false);
                    if (jsonattribs.Length > 0)
                    {
                        var pname = jsonattribs[0].Name;
                        if (value.GetType() == typeof(InputFile))
                        {
                            var file = (InputFile)value;
                            content.Add(file.Content, pname, file.Filename);
                        }
                        else
                        {
                            if (value is string || value is bool || value.IsNumber())
                            {
                                var asjkasj = value.ToString();
                                var scon = new { Name = pname, Content = new StringContent(value.ToString(), Encoding.UTF8) };
                                content.Add(scon.Content, scon.Name);
                            }
                            else
                            {
                                string jvalue = JsonSerializer.Serialize(value, value.GetType(), serializeoptions);
                                var scon = new { Name = pname, Content = new StringContent(jvalue, Encoding.UTF8) };
                                content.Add(scon.Content, scon.Name);
                            }
                        }
                    }
                    else
                    {
                        if (args is IAttachFiles)
                        {
                            var attachfiles = (args as IAttachFiles).AttachFiles;
                            foreach (var attachfile in attachfiles)
                            {
                                content.Add(attachfile.File.Content, attachfile.Name, attachfile.File.Filename);
                            }
                        }
                    }
                }
            }
            var response = await PostRequestAsyncMultipartFormData<T>(method, content, cancellationToken).ConfigureAwait(false);
            content.Dispose();
            if (response.Ok == true)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description, response.Parameters);
                }
            }
        }
    }
}
