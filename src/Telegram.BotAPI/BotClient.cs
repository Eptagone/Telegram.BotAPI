// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

#region AUTHOR
//--------------------------------------------------------------------------
// @author: Quetzal Rivera          @email: QuetzalDeveloper@outlook.com
// Project name: Telegram.BotAPI       Date of creation: 13-12-2019
// Description: Library to access and interact with the Telegram Bot API.
// Review History:
// Creation: Creation   |   Date: 13-12-2019
// ________________________________________________________________________
//--------------------------------------------------------------------------
#endregion

using System.Net.Http;

namespace Telegram.BotAPI
{
	/// <summary>Telegram Bot Client.</summary>
	public sealed partial class BotClient
	{
		/// <summary>Bot base url for download files. {0} = BotToken, {1} = FilePath</summary>
		public const string BaseFilesUrl = "https://api.telegram.org/file/bot{0}/{1}";
		private readonly HttpClient httpClient;

		/// <summary>Initialize a Telegram Bot Client.</summary>
		/// <param name="botToken">Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</param>
		/// <param name="httpClient">Provide a specific HttpClient for this instance of BotClient.</param>
		/// <exception cref="ArgumentNullException">Thrown when accessToken is null or empty.</exception>
		public BotClient(string botToken, [Optional] HttpClient httpClient)
		{
			if (string.IsNullOrEmpty(botToken))
			{
				throw new ArgumentNullException(nameof(botToken));
			}
			this.Token = botToken;
			if (httpClient == default)
			{
				this.httpClient = DefaultHttpClient ?? SetHttpClient();
			}
			else
			{
				this.httpClient = AddJsonMultipart(httpClient);
			}
		}

		/// <summary>Initialize a Telegram Bot Client.</summary>
		/// <param name="botToken">Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</param>
		/// <param name="ignoreBotExceptions">Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/>.</param>
		/// <param name="httpClient">Provide a specific HttpClient for this instance of BotClient.</param>
		/// <exception cref="ArgumentNullException">Thrown when accessToken is null or empty.</exception>
		public BotClient(string botToken, bool ignoreBotExceptions, [Optional] HttpClient httpClient) : this(botToken, httpClient)
		{
			this.IgnoreBotExceptions = ignoreBotExceptions;
		}

		/// <summary>Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</summary>
		public string Token { get; }
		/// <summary>Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/>.</summary>
		public bool IgnoreBotExceptions { get; }
	}
}
