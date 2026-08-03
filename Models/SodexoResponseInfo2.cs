using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>sodexo</b> details
/// </summary>
public record SodexoResponseInfo2
{
    /// <summary>
    /// Sodexo merchantContactPhone
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantContactPhone")]
    public string? MerchantContactPhone { get; init; }
}
