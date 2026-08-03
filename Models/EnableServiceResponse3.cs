using System.Text.Json.Serialization;

namespace Adyen.Models;

public record EnableServiceResponse3
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
