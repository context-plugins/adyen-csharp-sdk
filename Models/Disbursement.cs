using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Disbursement
{
    /// <summary>
    /// The unique identifier of the account holder that received the disbursement.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    public required string AccountHolderId { get; init; }

    /// <summary>
    /// Contains information about the amount of the disbursement.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// The unique identifier of the balance account that received the disbursement.
    /// </summary>
    [JsonPropertyName("balanceAccountId")]
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// Contains information about the balances of the disbursement.
    /// </summary>
    [JsonPropertyName("balances")]
    public required CapitalBalance Balances { get; init; }

    /// <summary>
    /// Contains information about the fee that your user must pay for the disbursement.
    /// </summary>
    [JsonPropertyName("fee")]
    public required Fee22 Fee { get; init; }

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

    /// <summary>
    /// Contains information about the basis points configured for repaying the disbursement.
    /// </summary>
    [JsonPropertyName("repayment")]
    public required DisbursementRepayment2 Repayment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
