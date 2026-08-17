using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the bank account.
/// </summary>
public record BankAccount11
{
    /// <summary>
    /// Contains the bank account details. The fields required in this object depend on the country of the bank account and the currency of the transfer.
    /// </summary>
    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification AccountIdentification { get; init; }
}
