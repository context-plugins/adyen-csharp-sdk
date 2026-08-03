using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Bin Group Details
/// </summary>
public record BinDetail1
{
    /// <summary>
    /// The country where the card was issued.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerCountry")]
    public string? IssuerCountry { get; init; }
}
