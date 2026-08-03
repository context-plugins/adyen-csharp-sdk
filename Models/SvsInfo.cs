using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SvsInfo
{
    /// <summary>
    /// The merchant ID (MID) that the acquirer recognizes you by.
    /// </summary>
    [JsonPropertyName("authorisationMid")]
    public required string AuthorisationMid { get; init; }

    /// <summary>
    /// The three-character ISO currency code, example <b>USD</b>
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public required string CurrencyCode { get; init; }
}
