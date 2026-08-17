using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the Enable Service processing.
/// Content of the Enable Service Response message.
/// </summary>
public record EnableServiceResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }
}
