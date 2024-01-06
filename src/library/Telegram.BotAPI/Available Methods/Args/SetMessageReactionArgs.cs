// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// SetMessageReaction method arguments.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetMessageReactionArgs
{
	/// <summary>
	/// Initializes a new instance of SetMessageReactionArgs with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the target message</param>
	public SetMessageReactionArgs(long chatId, int messageId)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Initializes a new instance of SetMessageReactionArgs with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the target message</param>
	public SetMessageReactionArgs(string chatId, int messageId)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Identifier of the target message
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int MessageId { get; set; }
	/// <summary>
	/// New list of reaction types to set on the message. Currently, as non-premium users, bots can set up to one reaction per message. A custom emoji reaction can be used if it is either already present on the message or explicitly allowed by chat administrators.
	/// </summary>
	[JsonPropertyName(PropertyNames.Reaction)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<ReactionType>? Reaction { get; set; }
	/// <summary>
	/// Pass True to set the reaction with a big animation
	/// </summary>
	[JsonPropertyName(PropertyNames.IsBig)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsBig { get; set; }

}
