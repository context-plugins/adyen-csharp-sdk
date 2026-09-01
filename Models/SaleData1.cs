using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data related to the Sale System.
/// </summary>
public record SaleData1
{
    /// <summary>
    /// Identification of the Cashier or Operator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OperatorID")]
    [RegularExpression("^.+$")]
    public string? OperatorId { get; init; }

    /// <summary>
    /// Language of the Cashier or Operator.
    /// If different from the Login.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OperatorLanguage")]
    [RegularExpression("^[a-z]{2,2}$")]
    public string? OperatorLanguage { get; init; }

    /// <summary>
    /// Shift number.
    /// If different from the Login, see Login SaleData.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ShiftNumber")]
    [RegularExpression("^.+$")]
    public string? ShiftNumber { get; init; }

    /// <summary>
    /// Identification of a Sale transaction.
    /// </summary>
    [JsonPropertyName("SaleTransactionID")]
    public required TransactionIdType1 SaleTransactionId { get; init; }

    /// <summary>
    /// Identification of a Sale global transaction for a sequence of related POI transactions.
    /// If payment reservation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleReferenceID")]
    [RegularExpression("^.+$")]
    public string? SaleReferenceId { get; init; }

    /// <summary>
    /// Information related to the software and hardware features of the Sale Terminal.
    /// If content is not empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleTerminalData")]
    public SaleTerminalData1? SaleTerminalData { get; init; }

    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment
    ///  mean of the customer. It allows, for a merchant, to use a token for a transaction
    ///  only or for a longer period.
    /// Possible values:
    /// * <b>Customer</b>
    /// * <b>Transaction</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TokenRequestedType")]
    public TokenRequestedType1? TokenRequestedType { get; init; }

    /// <summary>
    /// Additional and optional identification of a customer order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CustomerOrderID")]
    [RegularExpression("^.+$")]
    public string? CustomerOrderId { get; init; }

    /// <summary>
    /// List of customer order open, closed or both to be sent in the response messages.
    /// Possible values:
    /// * <b>Both</b>
    /// * <b>Closed</b>
    /// * <b>Open</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CustomerOrderReq")]
    public IReadOnlyList<CustomerOrderReq>? CustomerOrderReq { get; init; }

    /// <summary>
    /// Sale information intended for the POI.
    /// Stored with the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleToPOIData")]
    [RegularExpression("^.+$")]
    public string? SaleToPoiData { get; init; }

    /// <summary>
    /// Sale information intended for the Acquirer.
    /// Send to the Acquirer if present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleToAcquirerData")]
    [RegularExpression("^.+$")]
    public string? SaleToAcquirerData { get; init; }

    /// <summary>
    /// Sale information intended for the Issuer.
    /// Send to the Acquirer if present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleToIssuerData")]
    public SaleToIssuerData1? SaleToIssuerData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
