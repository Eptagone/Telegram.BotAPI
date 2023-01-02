// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Collections;
using System.Net.Http;
using System.Reflection;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
	/// <summary>Exception generated when a request to Telegram Bot API got an error response.</summary>
	public sealed class BotRequestException : Exception, IEquatable<BotRequestException>
	{
		///<summary>Error code.</summary>
		public int ErrorCode { get; }
		///<summary>Error description.</summary>
		public string Description { get; }
		///<summary>Parameters.</summary>
		public ResponseParameters Parameters { get; }

		/// <summary>The original http response. Only available if the http response message could not be read as a valid BotRequest.</summary>
		public HttpResponseMessage ResponseMessage { get; }

		/// <summary>Initializes a new instance of the <see cref="BotRequestException"/> class with the specified error code and description message.</summary>
		/// <param name="errorCode">Error code.</param>
		/// <param name="description">Description.</param>
		/// <param name="parameters">Parameters.</param>
		public BotRequestException(int errorCode, string description, ResponseParameters parameters) : base(description)
		{
			this.ErrorCode = errorCode;
			this.Description = description;
			this.Parameters = parameters;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BotRequestException"/> class.
		/// </summary>
		/// <param name="httpRequestException">The http request exception that is the cause of the current exception.</param>
		/// <param name="httpResponseMessage">The failed http response.</param>
		public BotRequestException(HttpRequestException httpRequestException, HttpResponseMessage httpResponseMessage) : base("The response message cannot be read as a valid Bot Response.", httpRequestException)
		{
			if (httpRequestException == null)
			{
				throw new ArgumentNullException(nameof(httpRequestException));
			}
			if (httpResponseMessage == null)
			{
				throw new ArgumentNullException(nameof(httpResponseMessage));
			}
			this.ErrorCode = (int)httpResponseMessage.StatusCode;
			this.Description = httpRequestException.Message;
			this.ResponseMessage = httpResponseMessage;
		}
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as BotRequestException);
		}
		/// <inheritdoc/>
		public bool Equals(BotRequestException? other)
		{
			return other != null &&
				   EqualityComparer<IDictionary>.Default.Equals(this.Data, other.Data) &&
				   this.HelpLink == other.HelpLink &&
				   this.HResult == other.HResult &&
				   EqualityComparer<Exception>.Default.Equals(this.InnerException, other.InnerException) &&
				   this.Message == other.Message &&
				   this.Source == other.Source &&
				   this.StackTrace == other.StackTrace &&
				   EqualityComparer<MethodBase>.Default.Equals(this.TargetSite, other.TargetSite) &&
				   this.ErrorCode == other.ErrorCode &&
				   this.Description == other.Description &&
				   EqualityComparer<ResponseParameters>.Default.Equals(this.Parameters, other.Parameters) &&
				   EqualityComparer<HttpResponseMessage>.Default.Equals(this.ResponseMessage, other.ResponseMessage);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -840958873;
			hashCode = hashCode * -1521134295 + EqualityComparer<IDictionary>.Default.GetHashCode(this.Data);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.HelpLink);
			hashCode = hashCode * -1521134295 + this.HResult.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<Exception>.Default.GetHashCode(this.InnerException);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Message);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.StackTrace);
			hashCode = hashCode * -1521134295 + EqualityComparer<MethodBase>.Default.GetHashCode(this.TargetSite);
			hashCode = hashCode * -1521134295 + this.ErrorCode.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Description);
			hashCode = hashCode * -1521134295 + EqualityComparer<ResponseParameters>.Default.GetHashCode(this.Parameters);
			hashCode = hashCode * -1521134295 + EqualityComparer<HttpResponseMessage>.Default.GetHashCode(this.ResponseMessage);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(BotRequestException? left, BotRequestException? right)
		{
			return EqualityComparer<BotRequestException>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(BotRequestException? left, BotRequestException? right)
		{
			return !(left == right);
		}

	}
}
