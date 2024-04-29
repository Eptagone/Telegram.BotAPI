// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The reaction is based on a custom emoji.
/// </summary>
public class ReactionTypeCustomEmoji : ReactionType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReactionTypeCustomEmoji"/> class.
    /// </summary>
    /// <param name="customEmojiId">Custom emoji identifier</param>
    public ReactionTypeCustomEmoji(string customEmojiId)
    {
        this.CustomEmojiId = customEmojiId ?? throw new ArgumentNullException(nameof(customEmojiId));
    }

    /// <summary>
    /// Type of the reaction, always “custom_emoji”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "custom_emoji";

    /// <summary>
    /// Custom emoji identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomEmojiId)]
    public string CustomEmojiId { get; set; }
}
