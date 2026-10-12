using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The request to calculate an amount in a different currency.
/// </summary>
public record CalculateRateRequest
{
    /// <summary>
    /// An array of objects, where each object defines a currency and value for which you want to perform an exchange calculation.
    /// </summary>
    [JsonPropertyName("exchangeCalculations")]
    [MinLength(1)]
    [MaxLength(1000)]
    public required IReadOnlyList<CalculateRateRequestItem> ExchangeCalculations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
