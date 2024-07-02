// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes paid media. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="PaidMediaPreview"/></description></item>
/// <item><description><see cref="PaidMediaPhoto"/></description></item>
/// <item><description><see cref="PaidMediaVideo"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(PaidMediaConverter))]
public abstract class PaidMedia
{
    /// <summary>
    /// Type of the paid media
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
