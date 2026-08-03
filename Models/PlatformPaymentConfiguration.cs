using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PlatformPaymentConfiguration
{
    /// <summary>
    /// Specifies at what time a sales day ends for this account.
    /// <para>
    /// Possible values: Time in <b>"HH:MM"</b> format. <b>HH</b> ranges from <b>00</b> to <b>07</b>. <b>MM</b> must be <b>00</b>.
    /// </para>
    /// <para>
    /// Default value: <b>"00:00"</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesDayClosingTime")]
    public DateTimeOffset? SalesDayClosingTime { get; init; }

    /// <summary>
    /// Specifies after how many business days the funds in a settlement batch are made available in this balance account. Requires Custom Sales Day Payout to be enabled for your balance account. Contact your account manager or implementation manager to enable this.
    /// <para>
    /// Possible values: <b>1</b> to <b>20</b>, or <b>null</b>.
    /// </para>
    /// <para>
    /// Default value: <b>null</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementDelayDays")]
    public int? SettlementDelayDays { get; init; }
}
