// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object defines the criteria used to request suitable users. The identifiers of the selected users will be shared with the bot when the corresponding button is pressed. More about requesting users »
/// </summary>
/// <param name="requestId">Signed 32-bit identifier of the request that will be received back in the UsersShared object. Must be unique within the message</param>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class KeyboardButtonRequestUsers(int requestId)
{
	/// <summary>
	/// Signed 32-bit identifier of the request that will be received back in the UsersShared object. Must be unique within the message
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int RequestId { get; set; } = requestId;
	/// <summary>
	/// Optional. Pass True to request bots, pass False to request regular users. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserIsBot)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? UserIsBot { get; set; }
	/// <summary>
	/// Optional. Pass True to request premium users, pass False to request non-premium users. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserIsPremium)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? UserIsPremium { get; set; }
	/// <summary>
	/// Optional. The maximum number of users to be selected; 1-10. Defaults to 1.
	/// </summary>
	[JsonPropertyName(PropertyNames.MaxQuantity)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ushort? MaxQuantity { get; set; }
}
