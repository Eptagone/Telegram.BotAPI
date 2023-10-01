// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

public sealed partial class BotClient
{
	internal static readonly JsonSerializerOptions DefaultSerializerOptions = new()
	{
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
	};

	private const string applicationJson = "application/json";
	private const string multipartFormData = "multipart/form-data";

	/// <summary>Default HttpClient for bot requets.</summary>
	public static HttpClient? DefaultHttpClient { get; private set; }

	/// <summary>Set the default HttpClient for bot requets.</summary>
	/// <param name="client"><see cref="HttpClient"/> for http requets.</param>
	/// <exception cref="ArgumentNullException">Thrown when client is null.</exception>
	public static HttpClient SetHttpClient([Optional] HttpClient client)
	{
		DefaultHttpClient = client ?? new HttpClient();
		AddJsonMultipart(DefaultHttpClient);
		return DefaultHttpClient;
	}

	private static HttpClient? AddJsonMultipart(HttpClient? client)
	{
		if (client == null)
		{
			return null;
		}
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
		var response = this.GetRequestAsync<T>(method);
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
		using var request = new HttpRequestMessage(HttpMethod.Get, this.BuildUrl(method));
		return await this.SendRequestAsync<T>(request, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/></param>
	/// <param name="args">json parameters</param>
	/// <param name="serializeOptions">Options to control serialization behavior.</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	public BotResponse<T> PostRequest<T>(string method, object args, [Optional] JsonSerializerOptions serializeOptions)
	{
		var response = this.PostRequestAsync<T>(method, args, serializeOptions);
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
		return await this.PostRequestAsync<T>(method, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Makes a bot request using HTTP POST and returns the response.</summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/></param>
	/// <param name="args">json parameters</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
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
	public async Task<BotResponse<T>> PostRequestAsync<T>(string method, Stream args, [Optional] CancellationToken cancellationToken)
	{
		using var request = new HttpRequestMessage(HttpMethod.Post, this.BuildUrl(method))
		{
			Content = new StreamContent(args)
		};
		request.Content.Headers.ContentType = new MediaTypeHeaderValue(applicationJson);
		return await this.SendRequestAsync<T>(request, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>Makes a bot request using HTTP POST and Multipart Form Data and returns the response.</summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="method">Method name. See <see cref="MethodNames"/>.</param>
	/// <param name="args">Parameters encoded using multipart/form-data.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <returns><see cref="BotResponse{T}"/></returns>
	public async Task<BotResponse<T>> PostRequestAsyncMultipartFormData<T>(string method, MultipartFormDataContent args, CancellationToken cancellationToken)
	{
		using var request = new HttpRequestMessage(HttpMethod.Post, this.BuildUrl(method))
		{
			Content = args
		};
		return await this.SendRequestAsync<T>(request, cancellationToken).ConfigureAwait(false);
	}

	internal async Task<BotResponse<T>> SendRequestAsync<T>(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		var response = await this.httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
		try
		{
			response.EnsureSuccessStatusCode();
			var streamResponse = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
			var botResponse = await JsonSerializer.DeserializeAsync<BotResponse<T>>(streamResponse, DefaultSerializerOptions, cancellationToken: cancellationToken);
			return botResponse!;
		}
		catch (HttpRequestException exp)
		{
			if (response.Content.Headers.ContentType.MediaType == applicationJson)
			{
				var streamResponse = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
				var botResponse = await JsonSerializer.DeserializeAsync<BotResponse<T>>(streamResponse, DefaultSerializerOptions, cancellationToken: cancellationToken);
				return botResponse!;
			}
			else
			{
				throw new BotRequestException(exp, response);
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

	/// <summary>RPC</summary>
	/// <typeparam name="T">return type.</typeparam>
	/// <param name="method">method name</param>
	internal T RPC<T>(string method)
	{
		var response = this.GetRequest<T>(method);
		if (response.Ok)
		{
			return response.Result;
		}
		else
		{
			if (this.IgnoreBotExceptions)
			{
				return default(T);
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
		var response = await this.GetRequestAsync<T>(method, cancellationToken).ConfigureAwait(false);
		if (response.Ok == true)
		{
			return response.Result;
		}
		else
		{
			if (this.IgnoreBotExceptions)
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
	internal T RPC<T>(string method, object args)
	{
		var response = this.PostRequest<T>(method, args);
		if (response.Ok)
		{
			return response.Result;
		}
		else
		{
			if (this.IgnoreBotExceptions)
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
		var response = this.PostRequest<T>(method, args);
		if (response.Ok)
		{
			return response.Result;
		}
		else
		{
			if (this.IgnoreBotExceptions)
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
	internal async Task<T> RPCA<T>(string method, object args, [Optional] CancellationToken cancellationToken)
	{
		var response = await this.PostRequestAsync<T>(method, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		if (response.Ok)
		{
			return response.Result;
		}
		else
		{
			if (this.IgnoreBotExceptions)
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
		var response = await this.PostRequestAsync<T>(method, args, cancellationToken).ConfigureAwait(false);
		if (response.Ok == true)
		{
			return response.Result;
		}
		else
		{
			if (this.IgnoreBotExceptions)
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
	internal T RPCF<T>(string method, object args)
	{
		if (args is IMultipartForm mf)
		{
			if (!mf.UseMultipart())
			{
				return this.RPC<T>(method, args);
			}
		}
		var rpcf = this.RPCAF<T>(method, args, default);
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
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	internal async Task<T> RPCAF<T>(string method, object args, [Optional] CancellationToken cancellationToken)
	{
		// If the method is a multipart form and it say don't use multipart, use the normal RPCA method
		if (args is IMultipartForm mf && !mf.UseMultipart())
		{
			return await this.RPCA<T>(method, args, cancellationToken).ConfigureAwait(false);
		}

		// Create a new MultipartFormDataContent
		using var content = new MultipartFormDataContent(Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks);

		// Get the properties of the object
		var properties = args.GetType().GetProperties();

		// Iterate over the properties
		foreach (var property in properties)
		{
			// Get the value of the property
			var value = property.GetValue(args);

			// If value is null, skip it
			if (value == null)
			{
				continue;
			}

			// If the value is an array of AttachedFile. Attach all files.
			if (value is IEnumerable<AttachedFile> attachedfiles)
			{
				foreach (var attachedfile in attachedfiles)
				{
					content.Add(attachedfile.File.Content, attachedfile.Name, attachedfile.File.Filename);
				}
			}
			else
			{
				// Verify the property has the JsonPropertyName attribute
				var attribute = (JsonPropertyNameAttribute?)property.GetCustomAttribute(typeof(JsonPropertyNameAttribute));
				// If the property has json attributes, process.
				if (attribute != null)
				{
					// Get the name of the property.
					var pname = attribute.Name;

					// If the value is a basic type, then, add it to the content.
					if (value is string || value is bool || value.IsNumber())
					{
						content.Add(new StringContent(value.ToString(), Encoding.UTF8), pname);
					}
					// If the value is an InputFile, process it.
					else if (value is InputFile file)
					{
						content.Add(file.Content, pname, file.Filename);
					}
					// If the value is another kind of value (object or array), serialize it.
					else
					{
						string jvalue = JsonSerializer.Serialize(value, value.GetType(), DefaultSerializerOptions);
						content.Add(new StringContent(jvalue, Encoding.UTF8), pname);
					}
				}
			}
		}

		var response = await this.PostRequestAsyncMultipartFormData<T>(method, content, cancellationToken).ConfigureAwait(false);
		content.Dispose();
		if (response.Ok == true)
		{
			return response.Result;
		}
		else
		{
			if (this.IgnoreBotExceptions)
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
