using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the bank account details of the counterparty. The fields required in this object depend on the country of the bank account and the currency of the transfer.
/// </summary>
public record MandateAccountIdentification2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
