using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BoardingTokenResponse
{
    /// <summary>
    /// The boarding token that allows the Payments App to board.
    /// </summary>
    [JsonPropertyName("boardingToken")]
    public required string BoardingToken { get; init; }

    /// <summary>
    /// The unique identifier of the Payments App instance.
    /// </summary>
    [JsonPropertyName("installationId")]
    public required string InstallationId { get; init; }
}
