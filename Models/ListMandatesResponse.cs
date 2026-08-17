using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListMandatesResponse
{
    /// <summary>
    /// Contains links to the next and previous page whenever applicable.
    /// </summary>
    [JsonPropertyName("link")]
    public required Link2 Link { get; init; }

    /// <summary>
    /// Contains a list of the mandates.
    /// </summary>
    [JsonPropertyName("mandates")]
    public required IReadOnlyList<Mandate1> Mandates { get; init; }
}
