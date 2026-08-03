using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources connected with this user.
/// </summary>
public record Links11
{
    [JsonPropertyName("self")]
    public required Self Self { get; init; }
}
