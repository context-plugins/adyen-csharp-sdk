using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DisablePermitRequest
{
    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The permit token to disable.
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; init; }
}
