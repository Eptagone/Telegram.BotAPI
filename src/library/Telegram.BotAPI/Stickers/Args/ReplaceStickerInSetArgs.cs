// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "ReplaceStickerInSet" method.
/// </summary>
public class ReplaceStickerInSetArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReplaceStickerInSetArgs"/> class.
    /// </summary>
    /// <param name="userId">User identifier of the sticker set owner</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="oldSticker">File identifier of the replaced sticker</param>
    /// <param name="sticker">A JSON-serialized object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set remains unchanged.</param>
    public ReplaceStickerInSetArgs(long userId, string name, string oldSticker, InputSticker sticker)
    {
        this.UserId = userId;
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
        this.OldSticker = oldSticker ?? throw new ArgumentNullException(nameof(oldSticker));
        this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
    }

    /// <summary>
    /// User identifier of the sticker set owner
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Sticker set name
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; }

    /// <summary>
    /// File identifier of the replaced sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.OldSticker)]
    public string OldSticker { get; set; }

    /// <summary>
    /// A JSON-serialized object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set remains unchanged.
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public InputSticker Sticker { get; set; }
}
