using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the input or the result of the outputs, parallel to the message request, except if response not required and absent.
/// Content of the Input Response message.
/// </summary>
public record InputResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputResult")]
    public OutputResult2? OutputResult { get; init; }

    [JsonPropertyName("InputResult")]
    public required InputResult InputResult { get; init; }
}
