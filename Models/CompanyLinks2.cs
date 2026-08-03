using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources connected with this company.
/// </summary>
public record CompanyLinks2
{
    /// <summary>
    /// List of allowed origins.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apiCredentials")]
    public Href2? ApiCredentials { get; init; }

    [JsonPropertyName("self")]
    public required Self Self { get; init; }

    /// <summary>
    /// List of allowed origins.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("users")]
    public Href2? Users { get; init; }

    /// <summary>
    /// List of allowed origins.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhooks")]
    public Href2? Webhooks { get; init; }
}
