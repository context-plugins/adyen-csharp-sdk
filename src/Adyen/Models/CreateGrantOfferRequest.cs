using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record CreateGrantOfferRequest
{
    /// <summary>
    /// The financing amount that the user selected from the dynamic offer. Adyen uses this amount to create a static offer.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
