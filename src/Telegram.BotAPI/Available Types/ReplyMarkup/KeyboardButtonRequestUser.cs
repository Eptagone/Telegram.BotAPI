// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object defines the criteria used to request a suitable user. The identifier of the selected user will be shared with the bot when the corresponding button is pressed.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class KeyboardButtonRequestUser
{
	/// <summary>
	/// Initialize a new instance of the <see cref="KeyboardButtonRequestUser"/> class.
	/// </summary>
	/// <param name="requestId">Signed 32-bit identifier of the request, which will be received back in the UserShared object. Must be unique within the message.</param>
	public KeyboardButtonRequestUser(int requestId)
	{
		RequestId = requestId;
	}

	/// <summary>
	/// Signed 32-bit identifier of the request, which will be received back in the UserShared object. Must be unique within the message
	/// </summary>
	[JsonPropertyName(PropertyNames.RequestId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int RequestId { get; }
	/// <summary>
	/// Optional. Pass True to request a bot, pass False to request a regular user. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserIsBot)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? UserIsBot { get; set; }
	/// <summary>
	/// Optional. Pass True to request a premium user, pass False to request a non-premium user. If not specified, no additional restrictions are applied.
	/// </summary>
	[JsonPropertyName(PropertyNames.UserIsPremium)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? UserIsPremium { get; set; }

}
