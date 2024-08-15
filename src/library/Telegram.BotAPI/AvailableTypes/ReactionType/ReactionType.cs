// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the type of a reaction. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="ReactionTypeEmoji"/></description></item>
/// <item><description><see cref="ReactionTypeCustomEmoji"/></description></item>
/// <item><description><see cref="ReactionTypePaid"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(ReactionTypeConverter))]
public abstract class ReactionType
{
    /// <summary>
    /// Type of the reaction
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
