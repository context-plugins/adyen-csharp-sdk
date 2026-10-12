using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListNetworkTokensResponse
{
    /// <summary>
    /// List of network tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTokens")]
    public IReadOnlyList<NetworkToken>? NetworkTokens { get; init; }
}
