// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Telegram.BotAPI.AvailableTypes;
using System.Text.Json.Serialization;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SetMyCommands method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class DeleteMyCommandsArgs
    {
        /// <summary>Inititalize a new instance of <see cref="DeleteMyCommandsArgs"/>.</summary>
        /// <param name="scope">A <see cref="IBotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
        /// <param name="languageCode">A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</param>
        public DeleteMyCommandsArgs([Optional] IBotCommandScope scope, [Optional] string languageCode)
        {
            Scope = scope;
            LanguageCode = languageCode;
        }

        /// <summary>Optional. A <see cref="IBotCommandScope"/> object, describing scope of users for which the commands are relevant. Defaults to <see cref="BotCommandScopeDefault"/>.</summary>
        [JsonPropertyName(PropertyNames.Scope)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IBotCommandScope Scope { get; set; }
        /// <summary>Optional. A two-letter ISO 639-1 language code. If empty, commands will be applied to all users from the given scope, for whose language there are no dedicated commands.</summary>
        [JsonPropertyName(PropertyNames.LanguageCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LanguageCode { get; set; }
    }
}
