// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>Defines a property to know if the current object should be serialized as a multipart form.</summary>
    public interface IMultipartForm
    {
        /// <summary>True, if the current object must be treated as multipart form.</summary>
        bool UseMultipart();
    }
}
