// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.
/// <list type="bullet">
/// <item><description><see cref="InlineKeyboardMarkup"/></description></item>
/// <item><description><see cref="ReplyKeyboardMarkup"/></description></item>
/// <item><description><see cref="ReplyKeyboardRemove"/></description></item>
/// <item><description><see cref="ForceReply"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(ReplyMarkupConverter))]
public abstract class ReplyMarkup
{
}
