using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AffirmResponseInfo
{
    /// <summary>
    /// Affirm public API key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicApiKey")]
    public string? PublicApiKey { get; init; }
}
