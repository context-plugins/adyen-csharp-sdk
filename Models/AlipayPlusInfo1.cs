using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>alipay_plus</b>.
/// </summary>
public record AlipayPlusInfo1
{
    /// <summary>
    /// The currency used for settlement. Defaults to USD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementCurrencyCode")]
    public string? SettlementCurrencyCode { get; init; }
}
