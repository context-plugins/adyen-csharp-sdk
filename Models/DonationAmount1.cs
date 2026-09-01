using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The default amount for donations.
/// </summary>
public record DonationAmount1
{
    /// <summary>
    /// The donation amounts in minor units. The list must contain at least one amount and no more than three amounts.
    /// </summary>
    [JsonPropertyName("amounts")]
    [MinLength(1)]
    [MaxLength(3)]
    public required IReadOnlyList<long> Amounts { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    [RegularExpression("^[A-Z]{3}$")]
    public required string CurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
