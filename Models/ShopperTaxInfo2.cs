using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The tax info of the shopper
/// </summary>
public record ShopperTaxInfo2
{
    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code associated with the provided tax identification number.
    /// Currently used only for Indian PA-CB tax verification, when applicable.
    /// </summary>
    [JsonPropertyName("taxCountryCode")]
    [MaxLength(2)]
    public required string TaxCountryCode { get; init; }

    /// <summary>
    /// The shopper’s tax identification number.
    /// </summary>
    [JsonPropertyName("taxIdentificationNumber")]
    [MaxLength(20)]
    public required string TaxIdentificationNumber { get; init; }
}
