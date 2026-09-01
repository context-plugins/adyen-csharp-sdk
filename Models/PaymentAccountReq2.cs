using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data related to the account pointed by the payment card.
/// </summary>
public record PaymentAccountReq2
{
    /// <summary>
    /// Type of cardholder account used for the transaction. Allows a cardholder to select the type of account used for the transaction.
    /// Possible values:
    /// * <b>CardTotals</b>
    /// * <b>Checking</b>
    /// * <b>CreditCard</b>
    /// * <b>Default</b>
    /// * <b>EpurseCard</b>
    /// * <b>Investment</b>
    /// * <b>Savings</b>
    /// * <b>Universal</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AccountType")]
    public AccountType12? AccountType { get; init; }

    /// <summary>
    /// Identification of a transaction for the Sale System or the POI System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public TransactionIdType? CardAcquisitionReference { get; init; }

    /// <summary>
    /// Data related to the instrument of payment for the transaction.
    /// Sent in the result of the payment transaction. For a card, it could also be sent in the <c>CardAcquisition</c> response, to be processed by the Sale System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData? PaymentInstrumentData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
