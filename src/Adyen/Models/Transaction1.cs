using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Transaction1
{
    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount? Amount { get; init; }

    /// <summary>
    /// The details of the bank account to where a payout was made.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountDetail")]
    public BankAccountDetail? BankAccountDetail { get; init; }

    /// <summary>
    /// The merchant reference of a related capture.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureMerchantReference")]
    public string? CaptureMerchantReference { get; init; }

    /// <summary>
    /// The psp reference of a related capture.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capturePspReference")]
    public string? CapturePspReference { get; init; }

    /// <summary>
    /// The date on which the transaction was performed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// A description of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The code of the account to which funds were credited during an outgoing fund transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destinationAccountCode")]
    public string? DestinationAccountCode { get; init; }

    /// <summary>
    /// The psp reference of the related dispute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disputePspReference")]
    public string? DisputePspReference { get; init; }

    /// <summary>
    /// The reason code of a dispute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disputeReasonCode")]
    public string? DisputeReasonCode { get; init; }

    /// <summary>
    /// The merchant reference of a transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// The psp reference of the related authorisation or transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentPspReference")]
    public string? PaymentPspReference { get; init; }

    /// <summary>
    /// The psp reference of the related payout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutPspReference")]
    public string? PayoutPspReference { get; init; }

    /// <summary>
    /// The psp reference of a transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The code of the account from which funds were debited during an incoming fund transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceAccountCode")]
    public string? SourceAccountCode { get; init; }

    /// <summary>
    /// The status of the transaction.
    /// &gt;Permitted values: <c>PendingCredit</c>, <c>CreditFailed</c>, <c>CreditClosed</c>, <c>CreditSuspended</c>, <c>Credited</c>, <c>Converted</c>, <c>PendingDebit</c>, <c>DebitFailed</c>, <c>Debited</c>, <c>DebitReversedReceived</c>, <c>DebitedReversed</c>, <c>ChargebackReceived</c>, <c>Chargeback</c>, <c>ChargebackReversedReceived</c>, <c>ChargebackReversed</c>, <c>Payout</c>, <c>PayoutReversed</c>, <c>FundTransfer</c>, <c>PendingFundTransfer</c>, <c>ManualCorrected</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionStatus")]
    public TransactionStatus1? TransactionStatus { get; init; }

    /// <summary>
    /// The transfer code of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferCode")]
    public string? TransferCode { get; init; }
}
