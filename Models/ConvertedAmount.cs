using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record ConvertedAmount
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
}
