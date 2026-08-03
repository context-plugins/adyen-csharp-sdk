using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BankAccountV3
{
    [JsonPropertyName("accountHolder")]
    public required PartyIdentification AccountHolder { get; init; }

    /// <summary>
    /// Contains the bank account details. The fields required in this object depend on the country of the bank account and the currency of the transfer.
    /// </summary>
    [JsonPropertyName("accountIdentification")]
    public required AccountIdentification1 AccountIdentification { get; init; }

    /// <summary>
    /// The unique token that identifies the stored bank account details of the counterparty for a payout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    public string? StoredPaymentMethodId { get; init; }
}
