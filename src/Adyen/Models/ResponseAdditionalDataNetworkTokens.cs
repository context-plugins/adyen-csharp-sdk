using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataNetworkTokens
{
    /// <summary>
    /// Indicates whether a network token is available for the specified card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkToken.available")]
    public string? NetworkTokenAvailable { get; init; }

    /// <summary>
    /// The Bank Identification Number of a tokenized card, which is the first six digits of a card number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkToken.bin")]
    public string? NetworkTokenBin { get; init; }

    /// <summary>
    /// The last four digits of a network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkToken.tokenSummary")]
    public string? NetworkTokenTokenSummary { get; init; }
}
