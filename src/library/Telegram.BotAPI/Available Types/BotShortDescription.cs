// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the bot's short description.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class BotShortDescription
{
	/// <summary>
	/// Initialize a new instance of the <see cref="BotShortDescription"/> class.
	/// </summary>
	public BotShortDescription()
	{
		this.ShortDescription = string.Empty;
	}

	/// <summary>
	/// The bot's short description
	/// </summary>
	[JsonPropertyName(PropertyNames.ShortDescription)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ShortDescription { get; set; }
}
