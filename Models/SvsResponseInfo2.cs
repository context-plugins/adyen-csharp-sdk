using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>svs</b> details
/// </summary>
public record SvsResponseInfo2
{
    /// <summary>
    /// The merchant ID (MID) that the acquirer recognizes you by.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisationMid")]
    public string? AuthorisationMid { get; init; }

    /// <summary>
    /// The three-character ISO currency code, example <b>USD</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; init; }
}
