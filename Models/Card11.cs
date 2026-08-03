using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the counterparty card.
/// </summary>
public record Card11
{
    [JsonPropertyName("cardHolder")]
    public required PartyIdentification CardHolder { get; init; }

    [JsonPropertyName("cardIdentification")]
    public required CardIdentification CardIdentification { get; init; }
}
