using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Counterparty2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public BankAccount? BankAccount { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }
}
