using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information related to the result the output (display, print, input).
/// If DisplayOutput present in the request.
/// </summary>
public record OutputResult1
{
    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier or the Customer.
    /// Copy.
    /// Possible values:
    /// * <b>CashierDisplay</b>
    /// * <b>CashierInput</b>
    /// * <b>CustomerDisplay</b>
    /// * <b>CustomerInput</b>
    /// </summary>
    [JsonPropertyName("Device")]
    public required Device3 Device { get; init; }

    /// <summary>
    /// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
    /// Copy.
    /// Possible values:
    /// * <b>CustomerAssistance</b>
    /// * <b>Display</b>
    /// * <b>Document</b>
    /// * <b>Error</b>
    /// * <b>Input</b>
    /// * <b>POIReplication</b>
    /// * <b>Receipt</b>
    /// * <b>Sound</b>
    /// * <b>Status</b>
    /// * <b>Voucher</b>
    /// </summary>
    [JsonPropertyName("InfoQualify")]
    public required InfoQualify3 InfoQualify { get; init; }

    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
