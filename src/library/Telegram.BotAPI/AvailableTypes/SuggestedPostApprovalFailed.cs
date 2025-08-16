// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about the failed approval of a suggested post. Currently, only caused by insufficient user funds at the time of approval.
/// </summary>
public class SuggestedPostApprovalFailed
{
    /// <summary>
    /// Optional. Message containing the suggested post whose approval has failed. Note that the <see cref="Message"/> object in this field will not contain the <em>reply_to_message</em> field even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedPostMessage)]
    public Message? SuggestedPostMessage { get; set; }

    /// <summary>
    /// Expected price of the post
    /// </summary>
    [JsonPropertyName(PropertyNames.Price)]
    public SuggestedPostPrice Price { get; set; } = null!;
}
