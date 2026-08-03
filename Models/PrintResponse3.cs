using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PrintResponse3
{
    [JsonPropertyName("DocumentQualifier")]
    public required DocumentQualifier2 DocumentQualifier { get; init; }

    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }
}
