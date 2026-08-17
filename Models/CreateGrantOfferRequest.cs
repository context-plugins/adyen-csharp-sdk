using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateGrantOfferRequest
{
    /// <summary>
    /// The financing amount that the user selected from the dynamic offer. Adyen uses this amount to create a static offer.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
