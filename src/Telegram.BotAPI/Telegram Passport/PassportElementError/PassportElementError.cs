// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Converters;

using JsonConverter = System.Text.Json.Serialization.JsonConverterAttribute;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>This object represents an error in the Telegram Passport element which was submitted that should be resolved by the user. It should be one of:<br/>
    /// • <see cref="PassportElementErrorDataField"/><br/>
    /// • <see cref="PassportElementErrorFrontSide"/><br/>
    /// • <see cref="PassportElementErrorReverseSide"/><br/>
    /// • <see cref="PassportElementErrorSelfie"/><br/>
    /// • <see cref="PassportElementErrorFile"/><br/>
    /// • <see cref="PassportElementErrorFiles"/><br/>
    /// • <see cref="PassportElementErrorTranslationFile"/><br/>
    /// • <see cref="PassportElementErrorTranslationFiles"/><br/>
    /// • <see cref="PassportElementErrorUnspecified"/><br/></summary>
    [JsonConverter(typeof(PassportElementErrorConverter))]
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class PassportElementError
    {
        /// <summary>Error source.</summary>
        [JsonPropertyName(PropertyNames.Source)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public abstract string Source { get; }
        /// <summary>The section of the user's Telegram Passport which has the issue.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public abstract string Type { get; set; }
        /// <summary>Error message.</summary>
        [JsonPropertyName(PropertyNames.Message)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }
    }
}
