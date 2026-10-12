using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AllowedOrigin
{
    /// <summary>
    /// References to resources linked to the allowed origin.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links2? Links { get; init; }

    /// <summary>
    /// Domain of the allowed origin.
    /// </summary>
    [JsonPropertyName("domain")]
    public required string Domain { get; init; }

    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
