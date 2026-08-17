using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetNetworkTokenResponse
{
    /// <summary>
    /// The details of the network token.
    /// </summary>
    [JsonPropertyName("token")]
    public required NetworkToken2 Token { get; init; }
}
