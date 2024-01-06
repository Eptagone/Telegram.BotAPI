// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// This object represents an incoming update.
/// At most one of the optional parameters can be present in any given update.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Update
{
	/// <summary>
	/// The update's unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you're using webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order. If there are no new updates for at least a week, then identifier of the next update will be chosen randomly instead of sequentially.
	/// </summary>
	[JsonPropertyName(PropertyNames.UpdateId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int UpdateId { get; set; }
	/// <summary>
	/// Optional. New incoming message of any kind - text, photo, sticker, etc.
	/// </summary>
	[JsonPropertyName(PropertyNames.Message)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? Message { get; set; }
	/// <summary>
	/// Optional. New version of a message that is known to the bot and was edited
	/// </summary>
	[JsonPropertyName(PropertyNames.EditedMessage)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? EditedMessage { get; set; }
	/// <summary>
	/// Optional. New incoming channel post of any kind - text, photo, sticker, etc.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChannelPost)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? ChannelPost { get; set; }
	/// <summary>
	/// Optional. New version of a channel post that is known to the bot and was edited
	/// </summary>
	[JsonPropertyName(PropertyNames.EditedChannelPost)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? EditedChannelPost { get; set; }
	/// <summary>
	/// Optional. A reaction to a message was changed by a user. The bot must be an administrator in the chat and must explicitly specify "message_reaction" in the list of allowed_updates to receive these updates. The update isn't received for reactions set by bots.
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageReaction)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MessageReactionUpdated? MessageReaction { get; set; }
	/// <summary>
	/// Optional. Reactions to a message with anonymous reactions were changed. The bot must be an administrator in the chat and must explicitly specify "message_reaction_count" in the list of allowed_updates to receive these updates.
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageReactionCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MessageReactionCountUpdated? MessageReactionCount { get; set; }
	/// <summary>
	/// Optional. New incoming inline query
	/// </summary>
	[JsonPropertyName(PropertyNames.InlineQuery)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InlineQuery? InlineQuery { get; set; }
	/// <summary>
	/// Optional. The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChosenInlineResult)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChosenInlineResult? ChosenInlineResult { get; set; }
	/// <summary>
	/// Optional. New incoming callback query
	/// </summary>
	[JsonPropertyName(PropertyNames.CallbackQuery)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CallbackQuery? CallbackQuery { get; set; }
	/// <summary>
	/// Optional. New incoming shipping query. Only for invoices with flexible price
	/// </summary>
	[JsonPropertyName(PropertyNames.ShippingQuery)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ShippingQuery? ShippingQuery { get; set; }
	/// <summary>
	/// Optional. New incoming pre-checkout query. Contains full information about checkout
	/// </summary>
	[JsonPropertyName(PropertyNames.PreCheckoutQuery)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public PreCheckoutQuery? PreCheckoutQuery { get; set; }
	/// <summary>
	/// Optional. New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot
	/// </summary>
	[JsonPropertyName(PropertyNames.Poll)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Poll? Poll { get; set; }
	/// <summary>
	/// Optional. A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.
	/// </summary>
	[JsonPropertyName(PropertyNames.PollAnswer)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public PollAnswer? PollAnswer { get; set; }
	/// <summary>
	/// Optional. The bot's chat member status was updated in a chat. For private chats, this update is received only when the bot is blocked or unblocked by the user.
	/// </summary>
	[JsonPropertyName(PropertyNames.MyChatMember)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatMemberUpdated? MyChatMember { get; set; }
	/// <summary>
	/// Optional. A chat member's status was updated in a chat. The bot must be an administrator in the chat and must explicitly specify "chat_member" in the list of allowed_updates to receive these updates.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatMember)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatMemberUpdated? ChatMember { get; set; }
	/// <summary>
	/// Optional. A request to join the chat has been sent. The bot must have the can_invite_users administrator right in the chat to receive these updates.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatJoinRequest)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatJoinRequest? ChatJoinRequest { get; set; }
	/// <summary>
	/// Optional. A chat boost was added or changed. The bot must be an administrator in the chat to receive these updates.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatBoost)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatBoostUpdated? ChatBoost { get; set; }
	/// <summary>
	/// Optional. A boost was removed from a chat. The bot must be an administrator in the chat to receive these updates.
	/// </summary>
	[JsonPropertyName(PropertyNames.RemovedChatBoost)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatBoostRemoved? RemovedChatBoost { get; set; }
}
