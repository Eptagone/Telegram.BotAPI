// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The query contains data signed by a TON wallet of the user who sent the query. The data is signed for the domain <em>bot&lt;bot_id&gt;</em>, where <em>&lt;bot_id&gt;</em> is the identifier of the bot.
/// </summary>
public class WidgetQueryTypeSignData : WidgetQueryType
{
    /// <summary>
    /// Type of the query, always “sign_data”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "sign_data";

    /// <summary>
    /// The wallet that signed the data
    /// </summary>
    [JsonPropertyName(PropertyNames.Wallet)]
    public WidgetQueryWallet Wallet { get; set; } = null!;

    /// <summary>
    /// JSON-serialized signed data
    /// </summary>
    [JsonPropertyName(PropertyNames.SignData)]
    public string SignData { get; set; } = null!;
}
