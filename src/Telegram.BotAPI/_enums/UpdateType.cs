// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>Available update types.</summary>
    public enum UpdateType
    {
        /// <summary>Unknown update</summary>
        Unknown,
        /// <summary>Message update</summary>
        Message,
        /// <summary>Edited message update</summary>
        EditedMessage,
        /// <summary>Channel post update</summary>
        ChannelPost,
        /// <summary>Edited channel post update</summary>
        EditedChannelPost,
        /// <summary>Inline query update</summary>
        InlineQuery,
        /// <summary>Chosen inline result update</summary>
        ChosenInlineResult,
        /// <summary>Callback query update</summary>
        CallbackQuery,
        /// <summary>Shipping query update</summary>
        ShippingQuery,
        /// <summary>Pre checkout query update</summary>
        PreCheckoutQuery,
        /// <summary>Poll update</summary>
        Poll,
        /// <summary>Poll answer update</summary>
        PollAnswer,
        /// <summary>My chat member update</summary>
        MyChatMember,
        /// <summary>Chat member update</summary>
        ChatMember,
        /// <summary>Chat join request update</summary>
        ChatJoinRequest
    }
}
