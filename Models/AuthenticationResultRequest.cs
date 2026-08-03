using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AuthenticationResultRequest
{
    /// <summary>
    /// The merchant account identifier, with which the authentication was processed.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The pspReference identifier for the transaction.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }
}
