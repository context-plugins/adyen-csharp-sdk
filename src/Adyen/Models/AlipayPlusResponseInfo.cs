using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AlipayPlusResponseInfo
{
    /// <summary>
    /// The currency used for settlement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementCurrencyCode")]
    public string? SettlementCurrencyCode { get; init; }
}
