using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CalculateGrantOfferRequest
{
    /// <summary>
    /// The financing amount that the user selected from a dynamic offer. Adyen uses this amount to calculate a preliminary offer.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
