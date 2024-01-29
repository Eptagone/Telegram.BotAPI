// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "SetStickerKeywords" method.
/// </summary>
public class SetStickerKeywordsArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetStickerKeywordsArgs"/> class.
    /// </summary>
    /// <param name="sticker">File identifier of the sticker</param>
    public SetStickerKeywordsArgs(string sticker)
    {
        this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
    }

    /// <summary>
    /// File identifier of the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public string Sticker { get; set; }

    /// <summary>
    /// A JSON-serialized list of 0-20 search keywords for the sticker with total length of up to 64 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Keywords)]
    public IEnumerable<string>? Keywords { get; set; }
}
