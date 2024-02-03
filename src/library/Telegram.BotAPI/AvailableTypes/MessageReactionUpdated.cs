// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a change of a reaction on a message performed by a user.
/// </summary>
public class MessageReactionUpdated
{
    /// <summary>
    /// The chat containing the message the user reacted to
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Unique identifier of the message inside the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// Optional. The user that changed the reaction, if the user isn't anonymous
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User? User { get; set; }

    /// <summary>
    /// Optional. The chat on behalf of which the reaction was changed, if the user is anonymous
    /// </summary>
    [JsonPropertyName(PropertyNames.ActorChat)]
    public Chat? ActorChat { get; set; }

    /// <summary>
    /// Date of the change in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }

    /// <summary>
    /// Previous list of reaction types that were set by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.OldReaction)]
    public IEnumerable<ReactionType> OldReaction { get; set; } = null!;

    /// <summary>
    /// New list of reaction types that have been set by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.NewReaction)]
    public IEnumerable<ReactionType> NewReaction { get; set; } = null!;
}
