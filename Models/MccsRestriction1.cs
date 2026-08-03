using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// List of merchant category codes (MCCs) and the operation.
/// <para>
/// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
/// </para>
/// </summary>
public record MccsRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// List of merchant category codes (MCCs).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<string>? Value { get; init; }
}
