using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Disbursement
{
    /// <summary>
    /// The unique identifier of the account holder that received the disbursement.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    public required string AccountHolderId { get; init; }

    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }

    /// <summary>
    /// The unique identifier of the balance account that received the disbursement.
    /// </summary>
    [JsonPropertyName("balanceAccountId")]
    public required string BalanceAccountId { get; init; }

    [JsonPropertyName("balances")]
    public required Balances Balances { get; init; }

    [JsonPropertyName("fee")]
    public required Fee2 Fee { get; init; }

    /// <summary>
    /// Contains information about the accounts that Adyen uses to collect funds related to repayments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsCollections")]
    public IReadOnlyList<FundsCollection>? FundsCollections { get; init; }

    /// <summary>
    /// The unique identifier of the grant related to the disbursement.
    /// </summary>
    [JsonPropertyName("grantId")]
    public required string GrantId { get; init; }

    /// <summary>
    /// The unique identifier of the disbursement.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("repayment")]
    public required DisbursementRepayment Repayment { get; init; }
}
