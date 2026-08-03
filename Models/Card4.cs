using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Card4
{
    [JsonPropertyName("cardHolder")]
    public required PartyIdentification CardHolder { get; init; }

    [JsonPropertyName("cardIdentification")]
    public required CardIdentification CardIdentification { get; init; }
}
