using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AlipayPlusInfo
{
    /// <summary>
    /// The currency used for settlement. Defaults to USD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementCurrencyCode")]
    public string? SettlementCurrencyCode { get; init; }
}
