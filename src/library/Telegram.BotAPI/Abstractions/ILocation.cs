// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Represents a point on the map. Used by <see cref="Location"/>.
/// </summary>
[Obsolete("The interface is obsolete. Don't use it.")]
public interface ILocation
{
	/// <summary>Longitude as defined by sender.</summary>
	public float Longitude { get; }
	/// <summary>Latitude as defined by sender.</summary>
	public float Latitude { get; }
	/// <summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
	public float? HorizontalAccuracy { get; set; }
	/// <summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
	public uint? LivePeriod { get; set; }
	/// <summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
	public ushort? Heading { get; set; }
	/// <summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
	public uint? ProximityAlertRadius { get; set; }
}