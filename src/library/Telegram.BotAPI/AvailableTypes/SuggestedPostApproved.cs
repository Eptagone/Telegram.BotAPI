// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about the approval of a suggested post.
/// </summary>
public class SuggestedPostApproved
{
    /// <summary>
    /// Optional. Message containing the suggested post. Note that the <see cref="Message"/> object in this field will not contain the <em>reply_to_message</em> field even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedPostMessage)]
    public Message? SuggestedPostMessage { get; set; }

    /// <summary>
    /// Optional. Amount paid for the post
    /// </summary>
    [JsonPropertyName(PropertyNames.Price)]
    public SuggestedPostPrice? Price { get; set; }

    /// <summary>
    /// Date when the post will be published
    /// </summary>
    [JsonPropertyName(PropertyNames.SendDate)]
    public int SendDate { get; set; }
}
