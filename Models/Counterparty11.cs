using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Contains information about the party that receives the payment funds.
/// </summary>
public record Counterparty11
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
