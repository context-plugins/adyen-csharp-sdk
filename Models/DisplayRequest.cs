using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys the data to display and the way to process the display. It contains the complete content to display. It might contain an operation (the DisplayOutput element) per Display Device type.
/// Content of the Display Request message.
/// </summary>
public record DisplayRequest
{
    /// <summary>
    /// Information to display and the way to process the display.
    /// Complete display content for output devices. At most one DisplayOutput per Device/ InfoQualify pair.
    /// </summary>
    [JsonPropertyName("DisplayOutput")]
    public required IReadOnlyList<DisplayOutput> DisplayOutput { get; init; }
}
