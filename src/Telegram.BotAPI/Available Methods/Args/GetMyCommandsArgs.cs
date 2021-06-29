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
    public sealed class GetMyCommandsArgs
    {
        /// <summary>Inititalize a new instance of <see cref="GetMyCommandsArgs"/>.</summary>
        /// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
        /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string.</param>
        public GetMyCommandsArgs([Optional] BotCommandScope scope, [Optional] string languageCode)
        {
            Scope = scope;
            LanguageCode = languageCode;
        }

        /// <summary>Optional. A <see cref="BotCommandScope"/> object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</summary>
        [JsonPropertyName(PropertyNames.Scope)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BotCommandScope Scope { get; set; }
        /// <summary>Optional. A two-letter ISO 639-1 language code or an empty string.</summary>
        [JsonPropertyName(PropertyNames.LanguageCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LanguageCode { get; set; }
    }
}
