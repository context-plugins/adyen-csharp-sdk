using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// List of token requestor IDs and the operation.
/// <para>
/// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
/// </para>
/// </summary>
public record TokenRequestorsRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<string>? Value { get; init; }
}
