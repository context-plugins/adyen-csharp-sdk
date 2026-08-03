using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The recipient of the funds transfer. A bank account or a transfer instrument.
/// </summary>
public record Counterparty11
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
