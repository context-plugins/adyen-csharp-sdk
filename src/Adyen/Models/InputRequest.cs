using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Content of the <c>InputRequest</c> message. It conveys the data to display and how to process it. In addition to the display on the Input Device, it might contain an operation (the <c>DisplayOutput</c> element) per Display Device type.
/// </summary>
public record InputRequest
{
    /// <summary>
    /// Information to display and the way to process the display.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput2? DisplayOutput { get; init; }

    /// <summary>
    /// Information related to an Input request. It conveys the target input logical device, the type of input command, and possible minimum and maximum length of the input. In addition, if the requestor might require to receive an Event Notification if a card is inserted in a card reader, with the <c>NotifyCardInputFlag</c>.
    /// </summary>
    [JsonPropertyName("InputData")]
    public required InputData2 InputData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
