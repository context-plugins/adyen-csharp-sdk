using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThreeDs2ResultRequest
{
    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The pspReference returned in the /authorise call.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }
}
