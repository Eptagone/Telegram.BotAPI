// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary> Defines a property that implements a class or value type to add a link to a thumbnail for the result, as well as the height and width of the thumbnail.</summary>
    public interface IExternalThumbnail
    {
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
        public string ThumbUrl { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        public uint? ThumbWidth { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        public uint? ThumbHeight { get; set; }
    }
}
