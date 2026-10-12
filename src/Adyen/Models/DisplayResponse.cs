using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the display, parallel to the message request, except if response not required and absent.
/// Content of the Display Response message.
/// </summary>
public record DisplayResponse
{
    /// <summary>
    /// Information related to the result the output (display, print, input).
    /// One per DisplayOutput item of the request, and in the same order.
    /// </summary>
    [JsonPropertyName("OutputResult")]
    public required IReadOnlyList<OutputResult> OutputResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
