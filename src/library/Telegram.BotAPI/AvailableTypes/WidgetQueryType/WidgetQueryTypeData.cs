// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The query contains data for the bot.
/// </summary>
public class WidgetQueryTypeData : WidgetQueryType
{
    /// <summary>
    /// Type of the query, always “data”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "data";

    /// <summary>
    /// Optional. TON wallet card of the user who sent the query, if it was sent to the bot along with the query
    /// </summary>
    [JsonPropertyName(PropertyNames.WalletCard)]
    public TonWalletCard? WalletCard { get; set; }
}
