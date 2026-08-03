using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources linked to the allowed origin.
/// </summary>
public record Links21
{
    [JsonPropertyName("self")]
    public required Self Self { get; init; }
}
