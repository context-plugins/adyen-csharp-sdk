using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the <c>InputRequest</c> message. It conveys the data to display and how to process it. In addition to the display on the Input Device, it might contain an operation (the <c>DisplayOutput</c> element) per Display Device type.
/// </summary>
public record InputRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput3? DisplayOutput { get; init; }

    [JsonPropertyName("InputData")]
    public required InputData InputData { get; init; }
}
