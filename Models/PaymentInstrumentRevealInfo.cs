using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentInstrumentRevealInfo
{
    /// <summary>
    /// The CVC2 value of the card.
    /// </summary>
    [JsonPropertyName("cvc")]
    public required string Cvc { get; init; }

    /// <summary>
    /// The expiration date of the card.
    /// </summary>
    [JsonPropertyName("expiration")]
    public required Expiry2 Expiration { get; init; }

    /// <summary>
    /// The primary account number (PAN) of the card.
    /// </summary>
    [JsonPropertyName("pan")]
    public required string Pan { get; init; }
}
