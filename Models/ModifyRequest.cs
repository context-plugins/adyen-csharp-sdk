using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ModifyRequest
{
    /// <summary>
    /// This field contains additional data, which may be required for a particular payout request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The PSP reference received in the <c>/submitThirdParty</c> response.
    /// </summary>
    [JsonPropertyName("originalReference")]
    public required string OriginalReference { get; init; }
}
