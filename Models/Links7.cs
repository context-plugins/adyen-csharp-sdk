using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Reference to resources connected with the store.
/// </summary>
public record Links7
{
    [JsonPropertyName("self")]
    public required Self Self { get; init; }
}
