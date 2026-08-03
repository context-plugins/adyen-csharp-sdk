using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BusinessLines
{
    /// <summary>
    /// List of business lines.
    /// </summary>
    [JsonPropertyName("businessLines")]
    public required IReadOnlyList<BusinessLine> BusinessLinesValue { get; init; }
}
