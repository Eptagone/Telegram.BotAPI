// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "GetCustomEmojiStickers" method.
/// </summary>
public class GetCustomEmojiStickersArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetCustomEmojiStickersArgs"/> class.
    /// </summary>
    /// <param name="customEmojiIds">A JSON-serialized list of custom emoji identifiers. At most 200 custom emoji identifiers can be specified.</param>
    public GetCustomEmojiStickersArgs(IEnumerable<string> customEmojiIds)
    {
        this.CustomEmojiIds = customEmojiIds ?? throw new ArgumentNullException(nameof(customEmojiIds));
    }

    /// <summary>
    /// A JSON-serialized list of custom emoji identifiers. At most 200 custom emoji identifiers can be specified.
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomEmojiIds)]
    public IEnumerable<string> CustomEmojiIds { get; set; }
}
