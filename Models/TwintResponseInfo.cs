using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TwintResponseInfo
{
    /// <summary>
    /// Twint logo. Format: Base64-encoded string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }
}
