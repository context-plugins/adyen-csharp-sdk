using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListMandatesResponse
{
    [JsonPropertyName("link")]
    public required Link Link { get; init; }

    /// <summary>
    /// Contains a list of the mandates.
    /// </summary>
    [JsonPropertyName("mandates")]
    public required IReadOnlyList<Mandate> Mandates { get; init; }
}
