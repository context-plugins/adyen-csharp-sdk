using System.Text.Json.Serialization;
using Adyen.Models.OneOf;

namespace Adyen.Models;

public record BankAccount2
{
    /// <summary>
    /// Contains the bank account details. The fields required in this object depend on the country of the bank account and the currency of the transfer.
    /// </summary>
    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification2 AccountIdentification { get; init; }
}
