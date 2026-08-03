using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Identity
{
    /// <summary>
    /// The complete legal name of the individual or entity.
    /// </summary>
    [JsonPropertyName("fullLegalName")]
    public required string FullLegalName { get; init; }

    /// <summary>
    /// A commonly used or human-readable name for the individual or entity.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
