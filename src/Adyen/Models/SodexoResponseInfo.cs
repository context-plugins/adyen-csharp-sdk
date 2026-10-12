using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SodexoResponseInfo
{
    /// <summary>
    /// Sodexo merchantContactPhone
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantContactPhone")]
    public string? MerchantContactPhone { get; init; }
}
