using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PulseResponseInfo
{
    /// <summary>
    /// The type of transactions processed over this payment method.
    ///  Allowed values:
    /// - <b>pos</b> for in-person payments.
    /// - <b>billpay</b> for subscription payments, both the initial payment and the later recurring payments. These transactions have <c>recurringProcessingModel</c> <b>Subscription</b>.
    /// - <b>ecom</b> for all other card not present transactions. This includes non-recurring transactions and transactions with <c>recurringProcessingModel</c> <b>CardOnFile</b> or <b>UnscheduledCardOnFile</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingType")]
    public ProcessingType? ProcessingType { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
