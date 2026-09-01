using System;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data related to the payment transaction.
/// If one data element is present.
/// </summary>
public record PaymentData1
{
    /// <summary>
    /// Type of payment transaction. Elements requested by the Sale System that are related to the payment only.
    /// Possible values:
    /// * <b>CashAdvance</b>
    /// * <b>CashDeposit</b>
    /// * <b>Completion</b>
    /// * <b>FirstReservation</b>
    /// * <b>Instalment</b>
    /// * <b>IssuerInstalment</b>
    /// * <b>Normal</b>
    /// * <b>OneTimeReservation</b>
    /// * <b>PaidOut</b>
    /// * <b>Recurring</b>
    /// * <b>Refund</b>
    /// * <b>UpdateReservation</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentType")]
    public PaymentType1? PaymentType { get; init; }

    /// <summary>
    /// Indicates if the payment of the Sale transaction is split. Allows the POI to decline payment means that cannot accept split payment.
    /// </summary>
    [JsonPropertyName("SplitPaymentFlag")]
    public bool? SplitPaymentFlag { get; init; } = false;

    /// <summary>
    /// Requested validity date for the reservation. Allows a specific period for the reservation according to the need of the Merchant for the first reservation and the reservation updates as well.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RequestedValidityDate")]
    public DateTimeOffset? RequestedValidityDate { get; init; }

    /// <summary>
    /// Identification of a transaction for the Sale System or the POI System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionReference")]
    public TransactionIdType? CardAcquisitionReference { get; init; }

    /// <summary>
    /// Information related an instalment transaction. To request an instalment to the issuer, or to make individual instalments of a payment transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Instalment")]
    public Instalment1? Instalment { get; init; }

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
