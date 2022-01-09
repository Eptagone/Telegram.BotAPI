// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SetMyCommands method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SetMyCommandsArgs
    {
        /// <summary>Inititalize a new instance of <see cref="SetMyCommandsArgs"/>.</summary>
        public SetMyCommandsArgs()
        {
        }

        /// <summary>Inititalize a new instance of <see cref="SetMyCommandsArgs"/>.</summary>
        /// <param name="commands">A <see cref="BotCommand"/> list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
        /// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
        /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</param>
        public SetMyCommandsArgs(IEnumerable<BotCommand> commands, [Optional] BotCommandScope scope, [Optional] string languageCode)
        {
            Commands = commands;
            Scope = scope;
            LanguageCode = languageCode;
        }

        /// <summary>A <see cref="BotCommand"/> list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</summary>
        [JsonPropertyName(PropertyNames.Commands)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<BotCommand> Commands { get; set; }
        /// <summary>Optional. A <see cref="BotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</summary>
        [JsonPropertyName(PropertyNames.Scope)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BotCommandScope Scope { get; set; }
        /// <summary>Optional. A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</summary>
        [JsonPropertyName(PropertyNames.LanguageCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LanguageCode { get; set; }
    }
}
