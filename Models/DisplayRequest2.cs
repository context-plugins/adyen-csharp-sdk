using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Display Request message.
/// </summary>
public record DisplayRequest2
{
    /// <summary>
    /// Information to display and the way to process the display.
    /// Complete display content for output devices. At most one DisplayOutput per Device/ InfoQualify pair.
    /// </summary>
    [JsonPropertyName("DisplayOutput")]
    public required IReadOnlyList<DisplayOutput> DisplayOutput { get; init; }
}
