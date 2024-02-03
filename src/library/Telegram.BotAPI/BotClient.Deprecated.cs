// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Net.Http;
using System.Text.Json;

namespace Telegram.BotAPI;

public sealed partial class BotClient : TelegramBotClient
{
	/// <summary>
	/// Default HttpClient for bot requets.
	/// </summary>
	public static HttpClient? DefaultHttpClient { get; private set; }

	/// <summary>
	/// Set the default HttpClient for bot requets.
	/// </summary>
	/// <param name="client"><see cref="HttpClient"/> for http requets.</param>
	/// <exception cref="ArgumentNullException">Thrown when client is null.</exception>
	public static HttpClient SetHttpClient(HttpClient? client = null)
	{
		DefaultHttpClient = client ?? new HttpClient();
		return DefaultHttpClient;
	}

	/// <summary>
	/// Makes a bot request using HTTP GET and returns the response.
	/// </summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/></param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	[Obsolete("Use IBotClient.CallApi<T> instead.")]
	public BotResponse<T> GetRequest<T>(string method) =>
		this.GetRequestAsync<T>(method).GetAwaiter().GetResult();

	/// <summary>
	/// Makes a bot request using HTTP GET and returns the response.
	/// </summary>
	/// <typeparam name="T">Response type.</typeparam>,
	/// <param name="method">Method name. See <see cref="MethodNames"/></param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	[Obsolete("Use ITelegramBotClient.CallApiAsync<T> instead.")]
	public Task<BotResponse<T>> GetRequestAsync<T>(
		string method,
		CancellationToken cancellationToken = default
	) =>
		((ITelegramBotClient)this).CallMethodDirectAsync<T>(
			method,
			cancellationToken: cancellationToken
		);

	/// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/></param>
	/// <param name="args">json parameters</param>
	/// <param name="serializeOptions">Options to control serialization behavior.</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	[Obsolete("Use IBotClient.CallApi<T> instead.")]
	public BotResponse<T> PostRequest<T>(
		string method,
		object args,
		[Optional] JsonSerializerOptions serializeOptions
	) => this.PostRequestAsync<T>(method, args, serializeOptions).Result;

	/// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/></param>
	/// <param name="args">json parameters</param>
	/// <param name="serializeOptions">Options to control serialization behavior.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	[Obsolete("Use ITelegramBotClient.CallApiAsync<T> instead.")]
	public async Task<BotResponse<T>> PostRequestAsync<T>(
		string method,
		object args,
		[Optional] JsonSerializerOptions? serializeOptions,
		CancellationToken cancellationToken = default
	)
	{
		var stream = await Tools
			.SerializeAsStreamAsync(args, serializeOptions ?? SerializerOptions, cancellationToken)
			.ConfigureAwait(false);
		return await this.PostRequestAsync<T>(method, stream, cancellationToken)
			.ConfigureAwait(false);
	}

	/// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/></param>
	/// <param name="args">json parameters</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	[Obsolete("Use IBotClient.CallApi<T> instead.")]
	public BotResponse<T> PostRequest<T>(string method, Stream args)
	{
		var response = this.PostRequestAsync<T>(method, args);
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
	[Obsolete("Use ITelegramBotClient.CallApiAsync<T> instead.")]
	public Task<BotResponse<T>> PostRequestAsync<T>(
		string method,
		Stream args,
		CancellationToken cancellationToken = default
	) => ((ITelegramBotClient)this).CallMethodDirectAsync<T>(method, args, cancellationToken);

	/// <summary>Makes a bot request using HTTP POST and Multipart Form Data and returns the response.</summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/>.</param>
	/// <param name="args">Parameters encoded using multipart/form-data.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	[Obsolete("Use ITelegramBotClient.CallApiAsync<T> instead.")]
	public async Task<BotResponse<T>> PostRequestAsyncMultipartFormData<T>(
		string method,
		MultipartFormDataContent args,
		CancellationToken cancellationToken
	)
	{
		using var request = new HttpRequestMessage(HttpMethod.Post, this.BuildUrl(method))
		{
			Content = args
		};
		return await this.SendRequestAsync<T>(request, cancellationToken).ConfigureAwait(false);
	}

	internal async Task<BotResponse<T>> SendRequestAsync<T>(
		HttpRequestMessage request,
		CancellationToken cancellationToken
	)
	{
		var response = await this
			.httpClient.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);
		try
		{
			response.EnsureSuccessStatusCode();
			var streamResponse = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
			var botResponse = await JsonSerializer.DeserializeAsync<BotResponse<T>>(
				streamResponse,
				SerializerOptions,
				cancellationToken: cancellationToken
			);
			return botResponse!;
		}
		catch (HttpRequestException)
		{
			if (response.Content.Headers.ContentType.MediaType == "application/json")
			{
				var streamResponse = await response
					.Content.ReadAsStreamAsync()
					.ConfigureAwait(false);
				var botResponse = await JsonSerializer.DeserializeAsync<BotResponse<T>>(
					streamResponse,
					SerializerOptions,
					cancellationToken: cancellationToken
				);
				return botResponse!;
			}
			else
			{
				throw;
			}
		}
	}

	/// <summary>
	/// Build the url for the request.
	/// </summary>
	/// <param name="method">The method name.</param>
	/// <returns>The url for the request.</returns>
	private string BuildUrl(string method)
	{
		var prefix = this.UseTestEnvironment ? "/test" : string.Empty;
		return $"{this.ServerAddress}/bot{this.Token}{prefix}/{method}";
	}
}
