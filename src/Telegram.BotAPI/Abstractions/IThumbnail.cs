// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
	/// <summary>Defines a property that implements a class or value type to add thumbnail for result.</summary>
	public interface IThumbnail<T>
	{
		///<summary>Thumbnail.</summary>
		public T Thumb { get; set; }
	}
}
