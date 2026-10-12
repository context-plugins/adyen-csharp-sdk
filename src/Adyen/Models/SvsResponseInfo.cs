using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SvsResponseInfo
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
