using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Card4
{
    /// <summary>
    /// Contains information about the cardholder.
    /// </summary>
    [JsonPropertyName("cardHolder")]
    public required PartyIdentification1 CardHolder { get; init; }

    /// <summary>
    /// Contains the identification details of the card.
    /// </summary>
    [JsonPropertyName("cardIdentification")]
    public required CardIdentification3 CardIdentification { get; init; }
}
