using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AllowedOriginsResponse
{
    /// <summary>
    /// List of allowed origins.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<AllowedOrigin>? Data { get; init; }
}
