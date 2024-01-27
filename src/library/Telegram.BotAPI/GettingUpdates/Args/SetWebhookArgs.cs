// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>SetWebhook method arguments</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetWebhookArgs
{
	/// <summary>
	/// Initialize a new instance of <see cref="SetWebhookArgs"/>.
	/// </summary>
	public SetWebhookArgs()
	{
		this.Url = string.Empty;
	}
	/// <summary>
	/// Initialize a new instance of <see cref="SetWebhookArgs"/>.
	/// </summary>
	/// <param name="url">HTTPS url to send updates to. Use an empty string to remove webhook integration.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public SetWebhookArgs(string url)
	{
		this.Url = url ?? throw new ArgumentNullException(nameof(url));
	}

	/// <summary>HTTPS url to send updates to. Use an empty string to remove webhook integration.</summary>
	[JsonPropertyName(PropertyNames.Url)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Url { get; }
	/// <summary>Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</summary>
	[JsonPropertyName(PropertyNames.Certificate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputFile? Certificate { get; set; }
	/// <summary>The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS.</summary>
	[JsonPropertyName(PropertyNames.IpAddress)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? IpAddress { get; set; }
	/// <summary>Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot‘s server, and higher values to increase your bot’s throughput.</summary>
	[JsonPropertyName(PropertyNames.MaxConnections)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? MaxConnections { get; set; }
	/// <summary>List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</para></summary>
	[JsonPropertyName(PropertyNames.AllowedUpdates)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<string>? AllowedUpdates { get; set; }
	/// <summary>Pass True to drop all pending updates.</summary>
	[JsonPropertyName(PropertyNames.DropPendingUpdates)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DropPendingUpdates { get; set; }
	/// <summary>
	/// A secret token to be sent in a header “X-Telegram-Bot-Api-Secret-Token” in every webhook request, 1-256 characters. Only characters A-Z, a-z, 0-9, _ and - are allowed. The header is useful to ensure that the request comes from a webhook set by you.
	/// </summary>
	[JsonPropertyName(PropertyNames.SecretToken)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? SecretToken { get; set; }
}
