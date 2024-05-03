// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Defines all the types of updates that can be received.
/// </summary>
public sealed class UpdateTypes
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public const string Message = PropertyNames.Message;
    public const string EditedMessage = PropertyNames.EditedMessage;
    public const string ChannelPost = PropertyNames.ChannelPost;
    public const string EditedChannelPost = PropertyNames.EditedChannelPost;
    public const string BusinessConnection = PropertyNames.BusinessConnection;
    public const string BusinessMessage = PropertyNames.BusinessMessage;
    public const string EditedBusinessMessage = PropertyNames.EditedBusinessMessage;
    public const string DeletedBusinessMessages = PropertyNames.DeletedBusinessMessages;
    public const string MessageReaction = PropertyNames.MessageReaction;
    public const string MessageReactionCount = PropertyNames.MessageReactionCount;
    public const string InlineQuery = PropertyNames.InlineQuery;
    public const string ChosenInlineResult = PropertyNames.ChosenInlineResult;
    public const string CallbackQuery = PropertyNames.CallbackQuery;
    public const string ShippingQuery = PropertyNames.ShippingQuery;
    public const string PreCheckoutQuery = PropertyNames.PreCheckoutQuery;
    public const string Poll = PropertyNames.Poll;
    public const string PollAnswer = PropertyNames.PollAnswer;
    public const string MyChatMember = PropertyNames.MyChatMember;
    public const string ChatMember = PropertyNames.ChatMember;
    public const string ChatJoinRequest = PropertyNames.ChatJoinRequest;
    public const string ChatBoost = PropertyNames.ChatBoost;
    public const string RemovedChatBoost = PropertyNames.RemovedChatBoost;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
