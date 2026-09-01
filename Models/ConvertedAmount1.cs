using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Amount after a currency conversion.
/// </summary>
public record ConvertedAmount1
{
    /// <summary>
    /// Value of an amount.
    /// </summary>
    [JsonPropertyName("AmountValue")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public required double AmountValue { get; init; }

    /// <summary>
    /// Currency of a monetary amount.
    /// </summary>
    [JsonPropertyName("Currency")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public required string Currency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
