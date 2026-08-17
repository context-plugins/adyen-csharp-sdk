using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Enable Service Response message.
/// </summary>
public record EnableServiceResponse2
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }
}
