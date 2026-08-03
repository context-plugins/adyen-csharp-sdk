using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Sofort details.
/// </summary>
public record SofortInfo2
{
    /// <summary>
    /// Sofort currency code. For example, <b>EUR</b>.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public required string CurrencyCode { get; init; }

    /// <summary>
    /// Sofort logo. Format: Base64-encoded string.
    /// </summary>
    [JsonPropertyName("logo")]
    public required string Logo { get; init; }
}
