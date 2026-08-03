using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MandateBankAccount
{
    [JsonPropertyName("accountHolder")]
    public required MandatePartyIdentification AccountHolder { get; init; }

    [JsonPropertyName("accountIdentification")]
    public required MandateAccountIdentification2 AccountIdentification { get; init; }
}
