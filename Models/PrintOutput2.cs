using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information to print and how to process it.
/// </summary>
public record PrintOutput2
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
    /// Message response awaited by the initiator of the Request. Allows various types and synchronisation of requests for Print or Sound.
    /// Possible values:
    /// * <b>Immediate</b>
    /// * <b>NotRequired</b>
    /// * <b>PrintEnd</b>
    /// * <b>SoundEnd</b>
    /// </summary>
    [JsonPropertyName("ResponseMode")]
    public required ResponseMode1 ResponseMode { get; init; }

    /// <summary>
    /// Type of the print integrated in other prints. Allows a separated printing (paper cut if available), or integration with the sale receipt or other print. If the printing is integrated, the response is always immediate, even if the <c>ResponseMode</c> is set to <c>PrintEnd</c>.
    /// </summary>
    [JsonPropertyName("IntegratedPrintFlag")]
    public bool? IntegratedPrintFlag { get; init; } = false;

    /// <summary>
    /// Indicates that the cardholder payment receipt requires a physical signature by the Customer.
    /// </summary>
    [JsonPropertyName("RequiredSignatureFlag")]
    public bool? RequiredSignatureFlag { get; init; } = false;

    /// <summary>
    /// Content to display or print. This is a sequence of elements if they have different formats.
    /// </summary>
    [JsonPropertyName("OutputContent")]
    public required OutputContent3 OutputContent { get; init; }
}
