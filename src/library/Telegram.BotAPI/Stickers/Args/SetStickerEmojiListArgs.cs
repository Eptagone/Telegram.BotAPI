// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "SetStickerEmojiList" method.
/// </summary>
public class SetStickerEmojiListArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetStickerEmojiListArgs"/> class.
    /// </summary>
    /// <param name="sticker">File identifier of the sticker</param>
    /// <param name="emojiList">A JSON-serialized list of 1-20 emoji associated with the sticker</param>
    public SetStickerEmojiListArgs(string sticker, IEnumerable<string> emojiList)
    {
        this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
        this.EmojiList = emojiList ?? throw new ArgumentNullException(nameof(emojiList));
    }

    /// <summary>
    /// File identifier of the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public string Sticker { get; set; }

    /// <summary>
    /// A JSON-serialized list of 1-20 emoji associated with the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.EmojiList)]
    public IEnumerable<string> EmojiList { get; set; }
}
