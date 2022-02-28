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
    public sealed class BotCommandHelper
    {
        private const string COMMAND = "command";
        private const string PARAMS = "params";
        private const string BASE_COMMAND_PATTERN = @"^\/(?<command>\w*)(?:|@{0})(?:$|\s(?<params>.*))";
        // /([^"'\s]*)|"([^\n"]*)"|'([^\n']*)'/gimus
        private const string ARGS_PATTERN = @"/([^""'\s]*)|""([^\n""]*)""|'([^\n']*)'";
        private static Regex rxArgs = new Regex(ARGS_PATTERN, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

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

        /// <summary>Extracts the command name and parameters from the specified input string using the following format:<br/><b>/commandName[@BotUsername] [Params]</b>.</summary>
        /// <param name="text">Input string. The message text.</param>
        /// <returns>A <see cref="BotCommandMatch"/> object with the result information.</returns>
        public BotCommandMatch Match(string text)
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
        /// <param name="_">Command helper.</param>
        /// <param name="params">Command parameter string</param>
        /// <returns>An array of <see cref="string"/></returns>
        public IEnumerable<string> MatchArgs(string @params)
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
