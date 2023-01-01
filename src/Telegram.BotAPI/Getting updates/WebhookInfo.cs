// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Telegram.BotAPI.GettingUpdates
{
	/// <summary>Contains information about the current status of a webhook.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class WebhookInfo : IEquatable<WebhookInfo?>
	{
		/// <summary>
		/// Webhook URL, may be empty if webhook is not set up.
		/// </summary>
		[JsonPropertyName(PropertyNames.Url)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Url { get; set; } = null!;
		/// <summary>
		/// True, if a custom certificate was provided for webhook certificate checks.
		/// </summary>
		[JsonPropertyName(PropertyNames.HasCustomCertificate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool HasCustomCertificate { get; set; }
		/// <summary>
		/// Number of updates awaiting delivery.
		/// </summary>
		[JsonPropertyName(PropertyNames.PendingUpdateCount)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint PendingUpdateCount { get; set; }
		/// <summary>
		/// Optional. Currently used webhook IP address.
		/// </summary>
		[JsonPropertyName(PropertyNames.IpAddress)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? IpAddress { get; set; }
		/// <summary>
		/// Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook
		/// </summary>
		[JsonPropertyName(PropertyNames.LastErrorDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? LastErrorDate { get; set; }
		/// <summary>
		/// Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook.
		/// </summary>
		[JsonPropertyName(PropertyNames.LastErrorMessage)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? LastErrorMessage { get; set; }
		/// <summary>
		/// Optional. Unix time of the most recent error that happened when trying to synchronize available updates with Telegram datacenters.
		/// </summary>
		[JsonPropertyName(PropertyNames.LastSynchronizationErrorDate)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? LastSynchronizationErrorDate { get; set; }
		/// <summary>
		/// Optional. Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery.
		/// </summary>
		[JsonPropertyName(PropertyNames.MaxConnections)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? MaxConnections { get; set; }
		/// <summary>
		/// Optional. A list of update types the bot is subscribed to. Defaults to all update types except chat_member.
		/// </summary>
		[JsonPropertyName(PropertyNames.AllowedUpdates)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<string>? AllowedUpdates { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as WebhookInfo);
		}
		/// <inheritdoc/>
		public bool Equals(WebhookInfo? other)
		{
			return other != null &&
				   this.Url == other.Url &&
				   this.HasCustomCertificate == other.HasCustomCertificate &&
				   this.PendingUpdateCount == other.PendingUpdateCount &&
				   this.IpAddress == other.IpAddress &&
				   this.LastErrorDate == other.LastErrorDate &&
				   this.LastErrorMessage == other.LastErrorMessage &&
				   this.LastSynchronizationErrorDate == other.LastSynchronizationErrorDate &&
				   this.MaxConnections == other.MaxConnections &&
				   EqualityComparer<IEnumerable<string>?>.Default.Equals(this.AllowedUpdates, other.AllowedUpdates);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 561235898;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Url);
			hashCode = hashCode * -1521134295 + this.HasCustomCertificate.GetHashCode();
			hashCode = hashCode * -1521134295 + this.PendingUpdateCount.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.IpAddress);
			hashCode = hashCode * -1521134295 + this.LastErrorDate.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.LastErrorMessage);
			hashCode = hashCode * -1521134295 + this.LastSynchronizationErrorDate.GetHashCode();
			hashCode = hashCode * -1521134295 + this.MaxConnections.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<string>?>.Default.GetHashCode(this.AllowedUpdates);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(WebhookInfo? left, WebhookInfo? right)
		{
#pragma warning disable CS8604 // Possible null reference argument.
			return EqualityComparer<WebhookInfo>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
		}
		/// <inheritdoc/>
		public static bool operator !=(WebhookInfo? left, WebhookInfo? right)
		{
			return !(left == right);
		}

	}
}
