using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Counterparty12
{
    /// <summary>
    /// The unique identifier of the balance account where the funds are disbursed. The balance account must belong to the specified account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the transfer instrument where the funds are disbursed. The transfer instrument must belong to the legal entity of the specified account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }
}
