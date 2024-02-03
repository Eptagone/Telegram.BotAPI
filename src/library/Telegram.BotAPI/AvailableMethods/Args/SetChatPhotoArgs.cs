// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetChatPhoto" method.
/// </summary>
public class SetChatPhotoArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetChatPhotoArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="photo">New chat photo, uploaded using multipart/form-data</param>
    public SetChatPhotoArgs(long chatId, InputFile photo)
    {
        this.ChatId = chatId;
        this.Photo = photo ?? throw new ArgumentNullException(nameof(photo));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SetChatPhotoArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="photo">New chat photo, uploaded using multipart/form-data</param>
    public SetChatPhotoArgs(string chatId, InputFile photo)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Photo = photo ?? throw new ArgumentNullException(nameof(photo));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// New chat photo, uploaded using multipart/form-data
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public InputFile Photo { get; set; }
}
