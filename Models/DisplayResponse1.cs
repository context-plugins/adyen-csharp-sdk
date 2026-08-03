using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DisplayResponse1
{
    /// <summary>
    /// Information related to the result the output (display, print, input).
    /// One per DisplayOutput item of the request, and in the same order.
    /// </summary>
    [JsonPropertyName("OutputResult")]
    public required IReadOnlyList<OutputResult> OutputResult { get; init; }
}
