using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Counterparty2
{
    /// <summary>
    /// Contains the full name of the person or entity that receives the payment funds).
    /// </summary>
    [JsonPropertyName("accountHolder")]
    public required AccountHolder11 AccountHolder { get; init; }

    /// <summary>
    /// Contains the account number to which the payment funds are sent.
    /// </summary>
    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification1 AccountIdentification { get; init; }
}
