// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
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
            ErrorCode = errorCode;
            Description = description;
            Parameters = parameters;
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
            ErrorCode = (int)httpResponseMessage.StatusCode;
            Description = httpRequestException.Message;
            ResponseMessage = httpResponseMessage;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as BotRequestException);
        }

        public bool Equals(BotRequestException other)
        {
            return other != null &&
                   EqualityComparer<IDictionary>.Default.Equals(Data, other.Data) &&
                   HelpLink == other.HelpLink &&
                   HResult == other.HResult &&
                   EqualityComparer<Exception>.Default.Equals(InnerException, other.InnerException) &&
                   Message == other.Message &&
                   Source == other.Source &&
                   StackTrace == other.StackTrace &&
                   EqualityComparer<MethodBase>.Default.Equals(TargetSite, other.TargetSite) &&
                   ErrorCode == other.ErrorCode &&
                   Description == other.Description &&
                   EqualityComparer<ResponseParameters>.Default.Equals(Parameters, other.Parameters) &&
                   EqualityComparer<HttpResponseMessage>.Default.Equals(ResponseMessage, other.ResponseMessage);
        }

        public override int GetHashCode()
        {
            int hashCode = -840958873;
            hashCode = hashCode * -1521134295 + EqualityComparer<IDictionary>.Default.GetHashCode(Data);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HelpLink);
            hashCode = hashCode * -1521134295 + HResult.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Exception>.Default.GetHashCode(InnerException);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StackTrace);
            hashCode = hashCode * -1521134295 + EqualityComparer<MethodBase>.Default.GetHashCode(TargetSite);
            hashCode = hashCode * -1521134295 + ErrorCode.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<ResponseParameters>.Default.GetHashCode(Parameters);
            hashCode = hashCode * -1521134295 + EqualityComparer<HttpResponseMessage>.Default.GetHashCode(ResponseMessage);
            return hashCode;
        }

        public static bool operator ==(BotRequestException left, BotRequestException right)
        {
            return EqualityComparer<BotRequestException>.Default.Equals(left, right);
        }

        public static bool operator !=(BotRequestException left, BotRequestException right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
