// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// This <a href="https://core.telegram.org/bots/api#available-types">object</a> represents an incoming update.<br />At most <strong>one</strong> of the optional parameters can be present in any given update.
/// </summary>
public class Update
{
    /// <summary>
    /// The update's unique identifier. Update identifiers start from a certain positive number and increase sequentially. This identifier becomes especially handy if you're using <a href="https://core.telegram.org/bots/api#setwebhook">webhooks</a>, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order. If there are no new updates for at least a week, then identifier of the next update will be chosen randomly instead of sequentially.
    /// </summary>
    [JsonPropertyName(PropertyNames.UpdateId)]
    public int UpdateId { get; set; }

    /// <summary>
    /// Optional. New incoming message of any kind - text, photo, sticker, etc.
    /// </summary>
    [JsonPropertyName(PropertyNames.Message)]
    public Message? Message { get; set; }

    /// <summary>
    /// Optional. New version of a message that is known to the bot and was edited. This update may at times be triggered by changes to message fields that are either unavailable or not actively used by your bot.
    /// </summary>
    [JsonPropertyName(PropertyNames.EditedMessage)]
    public Message? EditedMessage { get; set; }

    /// <summary>
    /// Optional. New incoming channel post of any kind - text, photo, sticker, etc.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChannelPost)]
    public Message? ChannelPost { get; set; }

    /// <summary>
    /// Optional. New version of a channel post that is known to the bot and was edited. This update may at times be triggered by changes to message fields that are either unavailable or not actively used by your bot.
    /// </summary>
    [JsonPropertyName(PropertyNames.EditedChannelPost)]
    public Message? EditedChannelPost { get; set; }

    /// <summary>
    /// Optional. The bot was connected to or disconnected from a business account, or a user edited an existing connection with the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnection)]
    public BusinessConnection? BusinessConnection { get; set; }

    /// <summary>
    /// Optional. New message from a connected business account
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessMessage)]
    public Message? BusinessMessage { get; set; }

    /// <summary>
    /// Optional. New version of a message from a connected business account
    /// </summary>
    [JsonPropertyName(PropertyNames.EditedBusinessMessage)]
    public Message? EditedBusinessMessage { get; set; }

    /// <summary>
    /// Optional. Messages were deleted from a connected business account
    /// </summary>
    [JsonPropertyName(PropertyNames.DeletedBusinessMessages)]
    public BusinessMessagesDeleted? DeletedBusinessMessages { get; set; }

    /// <summary>
    /// Optional. A reaction to a message was changed by a user. The bot must be an administrator in the chat and must explicitly specify <em>"message_reaction"</em> in the list of <em>allowed_updates</em> to receive these updates. The update isn't received for reactions set by bots.
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageReaction)]
    public MessageReactionUpdated? MessageReaction { get; set; }

    /// <summary>
    /// Optional. Reactions to a message with anonymous reactions were changed. The bot must be an administrator in the chat and must explicitly specify <em>"message_reaction_count"</em> in the list of <em>allowed_updates</em> to receive these updates. The updates are grouped and can be sent with delay up to a few minutes.
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageReactionCount)]
    public MessageReactionCountUpdated? MessageReactionCount { get; set; }

    /// <summary>
    /// Optional. New incoming <a href="https://core.telegram.org/bots/api#inline-mode">inline</a> query
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineQuery)]
    public InlineQuery? InlineQuery { get; set; }

    /// <summary>
    /// Optional. The result of an <a href="https://core.telegram.org/bots/api#inline-mode">inline</a> query that was chosen by a user and sent to their chat partner. Please see our documentation on the <a href="https://core.telegram.org/bots/inline#collecting-feedback">feedback collecting</a> for details on how to enable these updates for your bot.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChosenInlineResult)]
    public ChosenInlineResult? ChosenInlineResult { get; set; }

    /// <summary>
    /// Optional. New incoming callback query
    /// </summary>
    [JsonPropertyName(PropertyNames.CallbackQuery)]
    public CallbackQuery? CallbackQuery { get; set; }

    /// <summary>
    /// Optional. New incoming shipping query. Only for invoices with flexible price
    /// </summary>
    [JsonPropertyName(PropertyNames.ShippingQuery)]
    public ShippingQuery? ShippingQuery { get; set; }

    /// <summary>
    /// Optional. New incoming pre-checkout query. Contains full information about checkout
    /// </summary>
    [JsonPropertyName(PropertyNames.PreCheckoutQuery)]
    public PreCheckoutQuery? PreCheckoutQuery { get; set; }

    /// <summary>
    /// Optional. New poll state. Bots receive only updates about manually stopped polls and polls, which are sent by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.Poll)]
    public Poll? Poll { get; set; }

    /// <summary>
    /// Optional. A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.
    /// </summary>
    [JsonPropertyName(PropertyNames.PollAnswer)]
    public PollAnswer? PollAnswer { get; set; }

    /// <summary>
    /// Optional. The bot's chat member status was updated in a chat. For private chats, this update is received only when the bot is blocked or unblocked by the user.
    /// </summary>
    [JsonPropertyName(PropertyNames.MyChatMember)]
    public ChatMemberUpdated? MyChatMember { get; set; }

    /// <summary>
    /// Optional. A chat member's status was updated in a chat. The bot must be an administrator in the chat and must explicitly specify <em>"chat_member"</em> in the list of <em>allowed_updates</em> to receive these updates.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatMember)]
    public ChatMemberUpdated? ChatMember { get; set; }

    /// <summary>
    /// Optional. A request to join the chat has been sent. The bot must have the <em>can_invite_users</em> administrator right in the chat to receive these updates.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatJoinRequest)]
    public ChatJoinRequest? ChatJoinRequest { get; set; }

    /// <summary>
    /// Optional. A chat boost was added or changed. The bot must be an administrator in the chat to receive these updates.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatBoost)]
    public ChatBoostUpdated? ChatBoost { get; set; }

    /// <summary>
    /// Optional. A boost was removed from a chat. The bot must be an administrator in the chat to receive these updates.
    /// </summary>
    [JsonPropertyName(PropertyNames.RemovedChatBoost)]
    public ChatBoostRemoved? RemovedChatBoost { get; set; }
}
