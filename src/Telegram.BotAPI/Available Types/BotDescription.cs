// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>
	/// This object represents the bot's description.
	/// </summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class BotDescription
	{
		/// <summary>
		/// Initialize a new instance of the <see cref="BotDescription"/> class.
		/// </summary>
		public BotDescription()
		{
			this.Description = string.Empty;
		}

		/// <summary>
		/// The bot's description
		/// </summary>
		[JsonPropertyName(PropertyNames.Description)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Description { get; set; }
	}
}
