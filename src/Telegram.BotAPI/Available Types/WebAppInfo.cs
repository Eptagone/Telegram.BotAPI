// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Contains information about a Web App.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class WebAppInfo : IEquatable<WebAppInfo>
{
	/// <summary>
	/// Initialize a new instance of the <see cref="WebAppInfo"/> class.
	/// </summary>
	public WebAppInfo()
	{
		this.Url = null!;
	}
	/// <summary>
	/// Initialize a new instance of the <see cref="WebAppInfo"/> class.
	/// </summary>
	/// <param name="url">An HTTPS URL of a Web App to be opened with additional data as specified in Initializing Web Apps.</param>
	public WebAppInfo(string url)
	{
		this.Url = url ?? throw new ArgumentNullException(nameof(url));
	}

	/// <summary>An HTTPS URL of a Web App to be opened with additional data as specified in Initializing Web Apps.</summary>
	[JsonPropertyName(PropertyNames.Url)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Url { get; set; }

	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as WebAppInfo);
	}
	/// <inheritdoc/>
	public bool Equals(WebAppInfo? other)
	{
		return other != null &&
			   this.Url == other.Url;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return -1915121810 + EqualityComparer<string>.Default.GetHashCode(this.Url);
	}
	/// <inheritdoc/>
	public static bool operator ==(WebAppInfo? left, WebAppInfo? right)
	{
		return EqualityComparer<WebAppInfo>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(WebAppInfo? left, WebAppInfo? right)
	{
		return !(left == right);
	}

}
