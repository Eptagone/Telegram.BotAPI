// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Reply Markup</summary>
[JsonConverter(typeof(ReplyMarkupConverter))]
public abstract class ReplyMarkup
{
}
