// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    /// <summary>Interface for <see cref="InputMedia"/> objects</summary>
    public interface IInputMedia : IFormattableMessage, ICaption
    {
        ///<summary>Type of the result.</summary>
        public string Type { get; }
        ///<summary>File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</summary>
        public string Media { get; set; }
    }
}
