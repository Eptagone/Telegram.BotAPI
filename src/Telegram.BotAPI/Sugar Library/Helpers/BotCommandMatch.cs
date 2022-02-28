// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>This object represents the result of a bot command match.</summary>
    public sealed class BotCommandMatch
    {
        /// <summary>Initialize a new instance of <see cref="BotCommandMatch"/>.</summary>
        internal BotCommandMatch()
        {
            Name = string.Empty;
            Params = string.Empty;
        }
        /// <summary>Initialize a new instance of <see cref="BotCommandMatch"/>.</summary>
        /// <param name="name">Command name.</param>
        /// <param name="params">Command parameters.</param>
        internal BotCommandMatch(string name, string @params)
        {
            Success = true;
            Name = name;
            Params = @params;
        }

        /// <summary>Gets a value indicating whether the match is successful.</summary>
        /// <returns>true if the match is successful; otherwise, false.</returns>
        public bool Success { get; }
        /// <summary>Command name.</summary>
        public string Name { get; }
        /// <summary>Command parameters.</summary>
        public string Params { get; }
    }
}
