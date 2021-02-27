// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>Interface for objects that includes the thumb property.</summary>
    public interface IThumb<T>
    {
        ///<summary>Thumbnail.</summary>
        public T Thumb { get; set; }
    }
}
