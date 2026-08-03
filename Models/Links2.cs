using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Links2
{
    [JsonPropertyName("self")]
    public required Self Self { get; init; }
}
