using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// An object containing the details of the receiving party of the grant.
/// </summary>
public record GrantCounterparty
{
    /// <summary>
    /// The unique identifier of the account holder that receives the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderId")]
    public string? AccountHolderId { get; init; }

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
