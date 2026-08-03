using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Sofort details.
/// </summary>
public record SofortResponseInfo2
{
    /// <summary>
    /// Sofort currency code. For example, <b>EUR</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; init; }

    /// <summary>
    /// Sofort logo. Format: Base64-encoded string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }
}
