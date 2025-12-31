// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "RepostStory" method.
/// </summary>
public class RepostStoryArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RepostStoryArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="fromChatId">Unique identifier of the chat which posted the story that should be reposted</param>
    /// <param name="fromStoryId">Unique identifier of the story that should be reposted</param>
    /// <param name="activePeriod">Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em></param>
    public RepostStoryArgs(string businessConnectionId, long fromChatId, int fromStoryId, int activePeriod)
    {
        this.BusinessConnectionId = businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.FromChatId = fromChatId;
        this.FromStoryId = fromStoryId;
        this.ActivePeriod = activePeriod;
    }

    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// Unique identifier of the chat which posted the story that should be reposted
    /// </summary>
    [JsonPropertyName(PropertyNames.FromChatId)]
    public long FromChatId { get; set; }

    /// <summary>
    /// Unique identifier of the story that should be reposted
    /// </summary>
    [JsonPropertyName(PropertyNames.FromStoryId)]
    public int FromStoryId { get; set; }

    /// <summary>
    /// Period after which the story is moved to the archive, in seconds; must be one of <em>6 * 3600</em>, <em>12 * 3600</em>, <em>86400</em>, or <em>2 * 86400</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.ActivePeriod)]
    public int ActivePeriod { get; set; }

    /// <summary>
    /// Pass <em>True</em> to keep the story accessible after it expires
    /// </summary>
    [JsonPropertyName(PropertyNames.PostToChatPage)]
    public bool? PostToChatPage { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the content of the story must be protected from forwarding and screenshotting
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }
}
