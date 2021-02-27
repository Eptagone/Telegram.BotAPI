// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>Interface for objects that includes thumb url, thumb width and thumb height properties.</summary>
    public interface IThumbUWH
    {
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
        public string ThumbUrl { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        public uint ThumbWidth { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        public uint ThumbHeight { get; set; }
    }
}
