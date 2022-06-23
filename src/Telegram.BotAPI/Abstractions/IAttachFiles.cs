// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Collections.Generic;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    /// <summary>Defines a property that implements a class or value type to add attach files for file messages.</summary>
    public interface IAttachFiles : IMultipartForm
    {
        /// <summary>Attached files.</summary>
        public ICollection<AttachedFile> AttachedFiles { get; }
    }
}
