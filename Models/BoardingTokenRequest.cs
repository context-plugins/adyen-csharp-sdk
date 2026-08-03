using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BoardingTokenRequest
{
    /// <summary>
    /// The boardingToken request token.
    /// </summary>
    [JsonPropertyName("boardingRequestToken")]
    public required string BoardingRequestToken { get; init; }
}
