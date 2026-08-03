using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountHolderTransactionListRequest
{
    /// <summary>
    /// The code of the account holder that owns the account(s) of which retrieve the transaction list.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// A list of accounts to include in the transaction list. If left blank, the last fifty (50) transactions for all accounts of the account holder will be included.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionListsPerAccount")]
    public IReadOnlyList<TransactionListForAccount>? TransactionListsPerAccount { get; init; }

    /// <summary>
    /// A list of statuses to include in the transaction list. If left blank, all transactions will be included.
    /// &gt;Permitted values:
    /// &gt;* <c>PendingCredit</c> - a pending balance credit.
    /// &gt;* <c>CreditFailed</c> - a pending credit failure; the balance will not be credited.
    /// &gt;* <c>Credited</c> - a credited balance.
    /// &gt;* <c>PendingDebit</c> - a pending balance debit (e.g., a refund).
    /// &gt;* <c>CreditClosed</c> - a pending credit closed; the balance will not be credited.
    /// &gt;* <c>CreditSuspended</c> - a pending credit closed; the balance will not be credited.
    /// &gt;* <c>DebitFailed</c> - a pending debit failure; the balance will not be debited.
    /// &gt;* <c>Debited</c> - a debited balance (e.g., a refund).
    /// &gt;* <c>DebitReversedReceived</c> - a pending refund reversal.
    /// &gt;* <c>DebitedReversed</c> - a reversed refund.
    /// &gt;* <c>ChargebackReceived</c> - a received chargeback request.
    /// &gt;* <c>Chargeback</c> - a processed chargeback.
    /// &gt;* <c>ChargebackReversedReceived</c> - a pending chargeback reversal.
    /// &gt;* <c>ChargebackReversed</c> - a reversed chargeback.
    /// &gt;* <c>Converted</c> - converted.
    /// &gt;* <c>ManualCorrected</c> - manual booking/adjustment by Adyen.
    /// &gt;* <c>Payout</c> - a payout.
    /// &gt;* <c>PayoutReversed</c> - a reversed payout.
    /// &gt;* <c>PendingFundTransfer</c> - a pending transfer of funds from one account to another.
    /// &gt;* <c>FundTransfer</c> - a transfer of funds from one account to another.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionStatuses")]
    public IReadOnlyList<TransactionStatus>? TransactionStatuses { get; init; }
}
