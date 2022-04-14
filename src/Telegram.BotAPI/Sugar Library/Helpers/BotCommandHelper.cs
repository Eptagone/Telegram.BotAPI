// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Telegram.BotAPI
{
    /// <summary>Helper class for command detection.</summary>
    public sealed class BotCommandHelper : IBotCommandHelper
    {
        private const string COMMAND = "command";
        private const string PARAMS = "params";
        private const string BASE_COMMAND_PATTERN = @"^\/(?<command>\w*)(?:|@{0})(?:$|\s(?<params>.*))";
        // /([^"'\s]*)|"([^\n"]*)"|'([^\n']*)'/gimus
        private const string ARGS_PATTERN = @"/([^""'\s]*)|""([^\n""]*)""|'([^\n']*)'";

        private static readonly Regex rxArgs = new(ARGS_PATTERN, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
        private readonly Regex _rx;

        /// <summary>Initialize a new instance of <see cref="BotCommandHelper"/>.</summary>
        /// <param name="configuration">The bot username.</param>
        /// <param name="useRegexCompiled">Set true, if tyou want to use regex compiled option.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BotCommandHelper(IBotProperties configuration, [Optional] bool useRegexCompiled)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }
            var pattern = string.Format(CultureInfo.InvariantCulture, BASE_COMMAND_PATTERN, configuration.User.Username);
            var options = RegexOptions.IgnoreCase;
            if (useRegexCompiled)
            {
                options |= RegexOptions.Compiled;
            }
            _rx = new Regex(pattern, options);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public BotCommandMatch Match(string text)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (string.IsNullOrEmpty(text))
            {
                return new BotCommandMatch();
            }
            var match = _rx.Match(text);
            if (match.Success)
            {
                var cmd = match.Groups[COMMAND].Value;
                var @params = match.Groups[PARAMS].Value;
                return new BotCommandMatch(cmd, @params);
            }
            else
            {
                return new BotCommandMatch();
            }
        }

        /// <summary>
        /// Extract args from the command parameters.
        /// </summary>
        /// <param name="params">Command parameter string</param>
        /// <returns>An array of <see cref="string"/></returns>
        [Obsolete("This method will be removed in future versions. Please use BotCommandHelper.MatchParameters(@params) instead!")]
        public IEnumerable<string> MatchArgs(string @params) => MatchParameters(@params);
        
        /// <summary>
        /// Extract args from the command parameters.
        /// </summary>
        /// <param name="params">Command parameter string</param>
        /// <returns>An array of <see cref="string"/></returns>
        public static IEnumerable<string> MatchParameters(string @params)
        {
            var match = rxArgs.Match(@params);
            if (match.Success)
            {
                foreach (Group group in match.Groups)
                {
                    if (!string.IsNullOrEmpty(group.Value))
                    {
                        yield return group.Value;
                    }
                }
            }
        }
    }
}
