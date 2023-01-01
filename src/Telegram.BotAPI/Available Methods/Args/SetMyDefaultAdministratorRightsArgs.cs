// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods
{
	/// <summary>SetMyCommands method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class SetMyDefaultAdministratorRightsArgs
	{
		/// <summary>Inititalize a new instance of <see cref="SetMyDefaultAdministratorRightsArgs"/>.</summary>
		public SetMyDefaultAdministratorRightsArgs([Optional] ChatAdministratorRights? rights, [Optional] bool? forChannels)
		{
			this.Rights = rights;
			this.ForChannels = forChannels;
		}

		/// <summary>Optional. A <see cref="ChatAdministratorRights"/> object describing new default administrator rights. If not specified, the default administrator rights will be cleared.</summary>
		[JsonPropertyName(PropertyNames.Rights)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ChatAdministratorRights? Rights { get; set; }
		/// <summary>Optional. Pass True to change the default administrator rights of the bot in channels. Otherwise, the default administrator rights of the bot for groups and supergroups will be changed.</summary>
		[JsonPropertyName(PropertyNames.ForChannels)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? ForChannels { get; set; }
	}
}
