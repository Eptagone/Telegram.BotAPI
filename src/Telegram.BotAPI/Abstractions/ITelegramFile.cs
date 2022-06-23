// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>Defines properties that implements a class or value type for file objects.</summary>
    public interface ITelegramFile
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        public string FileId { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        public string FileUniqueId { get; set; }
    }
}
