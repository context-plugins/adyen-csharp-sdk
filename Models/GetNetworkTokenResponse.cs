using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetNetworkTokenResponse
{
    [JsonPropertyName("token")]
    public required NetworkToken Token { get; init; }
}
