using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// It conveys the result of the print, parallel to the message request, except if response not required and absent.
/// Content of the Print Response message.
/// </summary>
public record PrintResponse
{
    /// <summary>
    /// Qualification of the document to print to the Cashier or the Customer. Allows the manager of the printer, Sale or POI Terminal, to send information to a physical printer or to use the paper type accordingly.
    /// Possible values:
    /// * <b>CashierReceipt</b>
    /// * <b>CustomerReceipt</b>
    /// * <b>Document</b>
    /// * <b>Journal</b>
    /// * <b>SaleReceipt</b>
    /// * <b>Voucher</b>
    /// </summary>
    [JsonPropertyName("DocumentQualifier")]
    public required DocumentQualifier2 DocumentQualifier { get; init; }

    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
