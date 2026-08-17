using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MandateBankAccount
{
    /// <summary>
    /// Contains information about the owner of the counterparty bank account.
    /// </summary>
    [JsonPropertyName("accountHolder")]
    public required MandatePartyIdentification2 AccountHolder { get; init; }

    /// <summary>
    /// Contains the bank account details of the counterparty. The fields required in this object depend on the country of the bank account and the currency of the transfer.
    /// </summary>
    [JsonPropertyName("accountIdentification")]
    public required MandateAccountIdentification2 AccountIdentification { get; init; }
}
