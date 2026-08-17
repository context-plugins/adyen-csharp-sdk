using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the input or the result of the outputs, parallel to the message request, except if response not required and absent.
/// Content of the Input Response message.
/// </summary>
public record InputResponse
{
    /// <summary>
    /// Information related to the result the output (display, print, input).
    /// If DisplayOutput present in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputResult")]
    public OutputResult1? OutputResult { get; init; }

    /// <summary>
    /// Contains the result and the content of the input.
    /// </summary>
    [JsonPropertyName("InputResult")]
    public required InputResult2 InputResult { get; init; }
}
