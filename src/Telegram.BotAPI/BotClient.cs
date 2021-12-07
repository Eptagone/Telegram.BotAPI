#region AUTHOR
//--------------------------------------------------------------------------
// @author: Quetzal Rivera          @email: QuetzalDeveloper@outlook.com
// Project name: Telegram.BotAPI       Date of creation: 13-12-2019
// Description: Library to access and interact with the Telegram Bot API.
// Review History:
// Creation: Creation   |   Date: 13-12-2019
// Update: Added Bot API 5.1 support | Date: 03-09-2021
// Description: Added all methods and objects of Bot API 5.1 published on March 9, 2021
// Update: Added Bot API 5.2 support | Date: 05-27-2021
// Description: Added all methods and objects of Bot API 5.2 published on April 26, 2021
// ________________________________________________________________________
//--------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI
{
    /// <summary>Telegram Bot Client.</summary>
    public sealed partial class BotClient : IEquatable<BotClient>
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
            Token = botToken;
            if (httpClient == default)
            {
                if (defaultHttpClient == default)
                {
                    SetHttpClient();
                }
                this.httpClient = defaultHttpClient;
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
            IgnoreBotExceptions = ignoreBotExceptions;
        }
        /// <summary>Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</summary>
        public string Token { get; }
        /// <summary>Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/>.</summary>
        public bool IgnoreBotExceptions { get; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as BotClient);
        }

        public bool Equals(BotClient other)
        {
            return other != null &&
                   Token == other.Token &&
                   EqualityComparer<HttpClient>.Default.Equals(httpClient, other.httpClient) &&
                   IgnoreBotExceptions == other.IgnoreBotExceptions;
        }

        public override int GetHashCode()
        {
            int hashCode = 1252002287;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Token);
            hashCode = hashCode * -1521134295 + EqualityComparer<HttpClient>.Default.GetHashCode(httpClient);
            hashCode = hashCode * -1521134295 + IgnoreBotExceptions.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(BotClient left, BotClient right)
        {
            return EqualityComparer<BotClient>.Default.Equals(left, right);
        }

        public static bool operator !=(BotClient left, BotClient right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
