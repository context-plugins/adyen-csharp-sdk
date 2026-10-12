using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The response returned when you calculate an amount in a different currency.
/// </summary>
public record CalculateRateResponse
{
    /// <summary>
    /// An array of objects, where each object returns a currency and value for which you performed an exchange calculation. You can use the calculated amounts in your payment requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeCalculations")]
    public IReadOnlyList<CalculateRateResponseItem>? ExchangeCalculations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
