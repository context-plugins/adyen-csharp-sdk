using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Counterparty
{
    [JsonPropertyName("accountHolder")]
    public required AccountHolder AccountHolder { get; init; }

    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification1 AccountIdentification { get; init; }
}
