using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalProductsResponse
{
    /// <summary>
    /// Terminal products that can be ordered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<TerminalProduct>? Data { get; init; }
}
