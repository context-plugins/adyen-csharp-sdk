using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The external reason for the transfer status.
/// </summary>
public record ExternalReason1
{
    /// <summary>
    /// The reason code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The description of the reason code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The namespace for the reason code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }
}
