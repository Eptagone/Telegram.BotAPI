// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the users whose identifiers were shared with the bot using a KeyboardButtonRequestUsers button.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class UsersShared
{
	/// <summary>
	/// Identifier of the request
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int RequestId { get; set; }
	/// <summary>
	/// Identifiers of the shared users. These numbers may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting them. But they have at most 52 significant bits, so 64-bit integers or double-precision float types are safe for storing these identifiers. The bot may not have access to the users and could be unable to use these identifiers, unless the users are already known to the bot by some other means.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserIds)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<long> UserIds { get; set; }
}
