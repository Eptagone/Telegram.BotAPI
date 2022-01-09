// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.GettingUpdates
{
    /// <summary>Allowed updates</summary>
    public static class AllowedUpdate
    {
        /// <summary>Message update: New incoming message of any kind — text, photo, sticker, etc.</summary>
        public const string Message = CommonNames.Message;
        /// <summary>Edited message update: New version of a message that is known to the bot and was edited.</summary>
        public const string EditedMessage = CommonNames.EditedMessage;
        /// <summary>Channel post update: New version of a channel post that is known to the bot and was edited.</summary>
        public const string ChannelPost = CommonNames.ChannelPost;
        /// <summary>Edited channel post update: New version of a channel post that is known to the bot and was edited.</summary>
        public const string EditedChannelPost = CommonNames.EditedChannelPost;
        /// <summary>Inline query update. New incoming inline query.</summary>
        public const string InlineQuery = CommonNames.InlineQuery;
        /// <summary>Chosen inline result update: The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        public const string ChosenInlineResult = CommonNames.ChosenInlineResult;
        /// <summary>Callback query update: New incoming callback query.</summary>
        public const string CallbackQuery = CommonNames.CallbackQuery;
        /// <summary>Shipping query update: New incoming shipping query. Only for invoices with flexible price.</summary>
        public const string ShippingQuery = CommonNames.ShippingQuery;
        /// <summary>Pre checkout query update: New incoming pre-checkout query. Contains full information about checkout.</summary>
        public const string PreCheckoutQuery = CommonNames.PreCheckoutQuery;
        /// <summary>Poll update: New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        public const string Poll = CommonNames.Poll;
        /// <summary>Poll answer update: A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.</summary>
        public const string PollAnswer = CommonNames.PollAnswer;
        /// <summary>My chat member update: The bot's chat member status was updated in a chat. For private chats, this update is received only when the bot is blocked or unblocked by the user.</summary>
        public const string MyChatMember = CommonNames.MyChatMember;
        /// <summary>Chat member update: A chat member's status was updated in a chat. The bot must be an administrator in the chat and must explicitly specify “chat_member” in the list of allowed_updates to receive these updates.</summary>
        public const string ChatMember = CommonNames.ChatMember;
        /// <summary>Chat join request: A request to join the chat has been sent. The bot must have the can_invite_users administrator right in the chat to receive these updates.</summary>
        public const string ChatJoinRequest = CommonNames.ChatJoinRequest;
    }
}
