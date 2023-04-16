// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Defines properties and methods for multipart form.
/// </summary>
public interface IMultipartForm
{
	/// <summary>Attached files.</summary>
	public IEnumerable<AttachedFile> AttachedFiles { get; set; }

	/// <summary>True, if the current object must be treated as multipart form.</summary>
	bool UseMultipart();
}
