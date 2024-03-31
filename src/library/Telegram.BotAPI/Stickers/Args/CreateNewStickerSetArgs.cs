// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "CreateNewStickerSet" method.
/// </summary>
public class CreateNewStickerSetArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateNewStickerSetArgs"/> class.
    /// </summary>
    /// <param name="userId">User identifier of created sticker set owner</param>
    /// <param name="name">Short name of sticker set, to be used in <em>t.me/addstickers/</em> URLs (e.g., <em>animals</em>). Can contain only English letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in <em>"_by_&lt;bot_username&gt;"</em>. <em>&lt;bot_username&gt;</em> is case insensitive. 1-64 characters.</param>
    /// <param name="title">Sticker set title, 1-64 characters</param>
    /// <param name="stickers">A JSON-serialized list of 1-50 initial stickers to be added to the sticker set</param>
    public CreateNewStickerSetArgs(long userId, string name, string title, IEnumerable<InputSticker> stickers)
    {
        this.UserId = userId;
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
        this.Title = title ?? throw new ArgumentNullException(nameof(title));
        this.Stickers = stickers ?? throw new ArgumentNullException(nameof(stickers));
    }

    /// <summary>
    /// User identifier of created sticker set owner
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Short name of sticker set, to be used in <em>t.me/addstickers/</em> URLs (e.g., <em>animals</em>). Can contain only English letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in <em>"_by_&lt;bot_username&gt;"</em>. <em>&lt;bot_username&gt;</em> is case insensitive. 1-64 characters.
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; }

    /// <summary>
    /// Sticker set title, 1-64 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; }

    /// <summary>
    /// A JSON-serialized list of 1-50 initial stickers to be added to the sticker set
    /// </summary>
    [JsonPropertyName(PropertyNames.Stickers)]
    public IEnumerable<InputSticker> Stickers { get; set; }

    /// <summary>
    /// Type of stickers in the set, pass “regular”, “mask”, or “custom_emoji”. By default, a regular sticker set is created.
    /// </summary>
    [JsonPropertyName(PropertyNames.StickerType)]
    public string? StickerType { get; set; }

    /// <summary>
    /// Pass <em>True</em> if stickers in the sticker set must be repainted to the color of text when used in messages, the accent color if used as emoji status, white on chat photos, or another appropriate color based on context; for custom emoji sticker sets only
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedsRepainting)]
    public bool? NeedsRepainting { get; set; }
}
