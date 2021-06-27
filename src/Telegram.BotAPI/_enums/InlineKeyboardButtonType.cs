// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>inlinekeyboardbutton Type</summary>
    public enum InlineKeyboardButtonType
    {
        /// <summary>Unknown button.</summary>
        Unknown,
        /// <summary>Url button.</summary>
        Url,
        /// <summary>Login Url button.</summary>
        LoginUrl,
        /// <summary>CallbackData button.</summary>
        CallbackData,
        /// <summary>SwitchInlineQuery button.</summary>
        SwitchInlineQuery,
        /// <summary>SwitchInlineQueryCurrentChat button.</summary>
        SwitchInlineQueryCurrentChat,
        /// <summary>CallbackGame button.</summary>
        CallbackGame,
        /// <summary>Pay button.</summary>
        Pay
    }
}
