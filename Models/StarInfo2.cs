using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>star</b>.
/// </summary>
public record StarInfo2
{
    /// <summary>
    /// The type of transactions processed over this payment method.
    ///  Allowed values:
    /// - <b>pos</b> for in-person payments.
    /// - <b>billpay</b> for subscription payments, both the initial payment and the later recurring payments. These transactions have <c>recurringProcessingModel</c> <b>Subscription</b>.
    /// - <b>ecom</b> for all other card not present transactions. This includes non-recurring transactions and transactions with <c>recurringProcessingModel</c> <b>CardOnFile</b> or <b>UnscheduledCardOnFile</b>.
    /// </summary>
    [JsonPropertyName("processingType")]
    public required ProcessingType ProcessingType { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo1? TransactionDescription { get; init; }
}
