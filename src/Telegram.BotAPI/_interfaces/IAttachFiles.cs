// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Collections.Generic;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    /// <summary>Defines a property that implements a class or value type to add attach files for file messages.</summary>
    public interface IAttachFiles
    {
        /// <summary>Attached files.</summary>
        public List<AttachFile> AttachFiles { get; }
    }
}
