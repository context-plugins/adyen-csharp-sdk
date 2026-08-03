using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>twint</b> details
/// </summary>
public record TwintResponseInfo2
{
    /// <summary>
    /// Twint logo. Format: Base64-encoded string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }
}
