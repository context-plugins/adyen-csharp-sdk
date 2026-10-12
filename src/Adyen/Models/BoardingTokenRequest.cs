using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record BoardingTokenRequest
{
    /// <summary>
    /// The boardingToken request token.
    /// </summary>
    [JsonPropertyName("boardingRequestToken")]
    public required string BoardingRequestToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
