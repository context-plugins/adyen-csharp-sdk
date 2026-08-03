using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CalculateGrantOfferRequest
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
