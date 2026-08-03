using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the Enable Service processing.
/// Content of the Enable Service Response message.
/// </summary>
public record EnableServiceResponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
