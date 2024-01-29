// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "AddStickerToSet" method.
/// </summary>
public class AddStickerToSetArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddStickerToSetArgs"/> class.
    /// </summary>
    /// <param name="userId">User identifier of sticker set owner</param>
    /// <param name="name">Sticker set name</param>
    /// <param name="sticker">A JSON-serialized object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.</param>
    public AddStickerToSetArgs(long userId, string name, InputSticker sticker)
    {
        this.UserId = userId;
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
        this.Sticker = sticker ?? throw new ArgumentNullException(nameof(sticker));
    }

    /// <summary>
    /// User identifier of sticker set owner
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Sticker set name
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; }

    /// <summary>
    /// A JSON-serialized object with information about the added sticker. If exactly the same sticker had already been added to the set, then the set isn't changed.
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public InputSticker Sticker { get; set; }
}
