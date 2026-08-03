using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information to identify the counterparty.
/// </summary>
public record MandateBankAccount2
{
    [JsonPropertyName("accountHolder")]
    public required MandatePartyIdentification AccountHolder { get; init; }

    [JsonPropertyName("accountIdentification")]
    public required MandateAccountIdentification2 AccountIdentification { get; init; }
}
