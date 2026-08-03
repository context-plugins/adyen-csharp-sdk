using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
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

    [JsonPropertyName("Device")]
    public required Device11 Device { get; init; }

    [JsonPropertyName("InfoQualify")]
    public required InfoQualify1 InfoQualify { get; init; }

    [JsonPropertyName("OutputContent")]
    public required OutputContent2 OutputContent { get; init; }

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
}
