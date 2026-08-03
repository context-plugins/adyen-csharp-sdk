using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record PerformedTransaction
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleData")]
    public SaleData2? SaleData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIData")]
    public Poidata2? Poidata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResult")]
    public PaymentResult1? PaymentResult { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResult")]
    public IReadOnlyList<LoyaltyResult>? LoyaltyResult { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversedAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? ReversedAmount { get; init; }
}
