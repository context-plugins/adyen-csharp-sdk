using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the details of the party that receives the grant.
/// </summary>
public record GrantCounterparty
{
    /// <summary>
    /// The identifier of the receiving account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderId")]
    public string? AccountHolderId { get; init; }

    /// <summary>
    /// The identifier of the balance account that belongs to the receiving account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The identifier of the transfer instrument that belongs to the legal entity of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }
}
