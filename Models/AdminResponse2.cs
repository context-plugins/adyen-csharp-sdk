using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Admin Response message.
/// </summary>
public record AdminResponse2
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
