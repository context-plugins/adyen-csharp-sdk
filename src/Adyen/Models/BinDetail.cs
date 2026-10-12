using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BinDetail
{
    /// <summary>
    /// The country where the card was issued.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerCountry")]
    public string? IssuerCountry { get; init; }
}
