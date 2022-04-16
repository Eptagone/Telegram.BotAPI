// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Represents a menu button, which launches a Web App.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class MenuButtonWebApp : MenuButton
    {
        /// <summary>
        /// Type of the button, must be web_app
        /// </summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => MenuButtonType.WebApp;
        /// <summary>
        /// Text on the button
        /// </summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery.
        /// </summary>
        [JsonPropertyName(PropertyNames.WebApp)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public WebAppInfo WebApp { get; set; }

    }
}
