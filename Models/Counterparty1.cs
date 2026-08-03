using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the party that receives the payment funds.
/// </summary>
public record Counterparty1
{
    [JsonPropertyName("accountHolder")]
    public required AccountHolder AccountHolder { get; init; }

    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification1 AccountIdentification { get; init; }
}
