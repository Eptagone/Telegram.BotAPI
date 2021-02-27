// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>Interface for file objects.</summary>
    public interface IFile
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        public string FileId { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        public string FileUniqueId { get; set; }
    }
}
