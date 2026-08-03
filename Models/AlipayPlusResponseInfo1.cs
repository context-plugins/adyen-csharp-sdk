using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>alipay_plus</b> details
/// </summary>
public record AlipayPlusResponseInfo1
{
    /// <summary>
    /// The currency used for settlement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementCurrencyCode")]
    public string? SettlementCurrencyCode { get; init; }
}
