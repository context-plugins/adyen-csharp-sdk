using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information to display and how to process it.
/// Contains a complete display operation for a Display or an Input Device type. For the Input Devices, Diagnosis and <c>EnableService</c>, <c>ResponseRequiredFlag</c>, and <c>MinimumDisplayTime</c> shall be absent.
/// </summary>
public record DisplayOutput
{
    /// <summary>
    /// Indicates if the message response is required.
    /// </summary>
    [JsonPropertyName("ResponseRequiredFlag")]
    public bool? ResponseRequiredFlag { get; init; } = true;

    /// <summary>
    /// Number of seconds the message has to be displayed.
    /// </summary>
    [JsonPropertyName("MinimumDisplayTime")]
    [Minimum(0)]
    [Maximum(999)]
    public int? MinimumDisplayTime { get; init; } = 0;

    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, in terms of class of information to output (display, print, or store), or input (keyboard) for the Cashier or the Customer.
    /// Possible values:
    /// * <b>CashierDisplay</b>
    /// * <b>CashierInput</b>
    /// * <b>CustomerDisplay</b>
    /// * <b>CustomerInput</b>
    /// </summary>
    [JsonPropertyName("Device")]
    public required Device11 Device { get; init; }

    /// <summary>
    /// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer. Allows the manager of the device, Sale or POI Terminal, to send the information to a particular physical device or to present the information accordingly.
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
    public required InfoQualify1 InfoQualify { get; init; }

    /// <summary>
    /// Content to display or print.
    /// </summary>
    [JsonPropertyName("OutputContent")]
    public required OutputContent1 OutputContent { get; init; }

    /// <summary>
    /// An entry of the menu to present to the Cashier. It conveys the message text and parameters of the menu entry. This output data could be only provided for an input command, in order to choose an entryof the menu.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MenuEntry")]
    public IReadOnlyList<MenuEntry>? MenuEntry { get; init; }

    /// <summary>
    /// Vendor-specific signature of the text message to display or print.
    /// If protection has to be provided to the vendor on the text to display or print.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputSignature")]
    [RegularExpression("^.+$")]
    public string? OutputSignature { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
