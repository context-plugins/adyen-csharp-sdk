using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content of the TransactionStatus Request message.
/// It conveys Information requested for status of the last or current Payment, Loyalty or Reversal transaction.
/// </summary>
public record TransactionStatusRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MessageReference")]
    public MessageReference1? MessageReference { get; init; }

    /// <summary>
    /// Request to reprint the POI receipt(s). Allows reprinting a receipt with a <c>TransactionStatus</c> message
    /// </summary>
    [JsonPropertyName("ReceiptReprintFlag")]
    public bool? ReceiptReprintFlag { get; init; } = false;

    /// <summary>
    /// Qualification of the document to print to the Cashier or the Customer. Allows the manager of the printer, Sale or POI Terminal, to send the information to a particular physical printer or to use the paper type accordingly.
    /// Possible values:
    /// * <b>CashierReceipt</b>
    /// * <b>CustomerReceipt</b>
    /// * <b>Document</b>
    /// * <b>Journal</b>
    /// * <b>SaleReceipt</b>
    /// * <b>Voucher</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DocumentQualifier")]
    public IReadOnlyList<DocumentQualifier>? DocumentQualifier { get; init; }
}
