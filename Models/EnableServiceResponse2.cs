using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Enable Service Response message.
/// </summary>
public record EnableServiceResponse2
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
