using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// *affirm** details
/// </summary>
public record AffirmResponseInfo1
{
    /// <summary>
    /// Affirm public API key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicApiKey")]
    public string? PublicApiKey { get; init; }
}
