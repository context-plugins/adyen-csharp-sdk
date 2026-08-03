using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Transaction
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount16? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountDetail")]
    public BankAccountDetail1? BankAccountDetail { get; init; }

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
