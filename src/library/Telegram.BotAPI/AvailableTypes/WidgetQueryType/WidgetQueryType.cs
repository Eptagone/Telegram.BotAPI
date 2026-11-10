// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the type of a query from a widget. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="WidgetQueryTypeData"/></description></item>
/// <item><description><see cref="WidgetQueryTypeSignData"/></description></item>
/// <item><description><see cref="WidgetQueryTypeSentTransaction"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(WidgetQueryTypeConverter))]
public abstract class WidgetQueryType
{
    /// <summary>
    /// Type of the query
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
