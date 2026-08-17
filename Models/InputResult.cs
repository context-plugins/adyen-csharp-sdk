using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InputResult
{
    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, in terms of class of information to output (display, print or store), or input (keyboard) for the Cashier or the Customer.
    /// Possible values:
    /// * <b>CashierDisplay</b>
    /// * <b>CashierInput</b>
    /// * <b>CustomerDisplay</b>
    /// * <b>CustomerInput</b>
    /// </summary>
    [JsonPropertyName("Device")]
    public required Device4 Device { get; init; }

    /// <summary>
    /// Qualification of the information to send to an output logical device, to display or print to the Cashier or the Customer.
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
    public required InfoQualify2 InfoQualify { get; init; }

    /// <summary>
    /// Result of a message request processing.
    /// If Result is Success, <c>ErrorCondition</c> is absent or not used in the processing of the message. In the other cases, the <c>ErrorCondition</c> has to be present and can refine the processing of the message response. <c>AdditionalResponse</c> gives more information about the success or the failure of the message request processing, for logging without real time involvements.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response1 Response { get; init; }

    /// <summary>
    /// Data entered by the user, related to the input command.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Input")]
    public Input2? Input { get; init; }
}
