using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// If Result is Success, contains all the totals, classified as required by the Sale in the message request. At least, transaction totals are provided per Acquirer, Acquirer Settlement, and Card Brand.
/// Result of the Sale to POI Reconciliation processing.
/// </summary>
public record TransactionTotals
{
    /// <summary>
    /// Type of payment instrument.
    /// Possible values:
    /// * <b>Card</b>
    /// * <b>Cash</b>
    /// * <b>Check</b>
    /// * <b>Mobile</b>
    /// * <b>StoredValue</b>
    /// </summary>
    [JsonPropertyName("PaymentInstrumentType")]
    public required PaymentInstrumentType11 PaymentInstrumentType { get; init; }

    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AcquirerID")]
    public int? AcquirerId { get; init; }

    /// <summary>
    /// Identifier of a reconciliation period with a payment or loyalty host.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("HostReconciliationID")]
    [RegularExpression("^.+$")]
    public string? HostReconciliationId { get; init; }

    /// <summary>
    /// Type of payment or loyalty card.
    /// If configured to present totals per card brand, and Response.Result is Success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardBrand")]
    [RegularExpression("^.+$")]
    public string? CardBrand { get; init; }

    /// <summary>
    /// Identification of a POI System or a POI Terminal for the Sale to POI protocol.
    /// Sent if requested in the message request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIID")]
    [RegularExpression("^.+$")]
    public string? Poiid { get; init; }

    /// <summary>
    /// Identification of a Sale System or a Sale Terminal for the Sale to POI protocol.
    /// Sent if requested in the message request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleID")]
    [RegularExpression("^.+$")]
    public string? SaleId { get; init; }

    /// <summary>
    /// Identification of the Cashier or Operator.
    /// Sent if requested in the message request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OperatorID")]
    [RegularExpression("^.+$")]
    public string? OperatorId { get; init; }

    /// <summary>
    /// Shift number.
    /// Sent if requested in the message request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ShiftNumber")]
    [RegularExpression("^.+$")]
    public string? ShiftNumber { get; init; }

    /// <summary>
    /// Identification of a group of transaction on a POI Terminal, having the same Sale features.
    /// Sent if requested in the message request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalsGroupID")]
    [RegularExpression("^.{1,16}$")]
    public string? TotalsGroupId { get; init; }

    /// <summary>
    /// Currency of a monetary amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentCurrency")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public string? PaymentCurrency { get; init; }

    /// <summary>
    /// Totals of the payment transaction during the reconciliation period.
    /// If both <c>TransactionCount</c> and <c>TransactionAmount</c> are not equal to zero.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentTotals")]
    public IReadOnlyList<PaymentTotals>? PaymentTotals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
