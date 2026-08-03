using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Third-party developed platform used to initiate payment requests. For example, Magento, Zuora, etc.
/// </summary>
public record ExternalPlatform
{
    /// <summary>
    /// External platform integrator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("integrator")]
    public string? Integrator { get; init; }

    /// <summary>
    /// Name of the field. For example, Name of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Version of the field. For example, Version of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }
}
