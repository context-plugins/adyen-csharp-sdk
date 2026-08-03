using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DisplayRequest3
{
    /// <summary>
    /// Information to display and the way to process the display.
    /// Complete display content for output devices. At most one DisplayOutput per Device/ InfoQualify pair.
    /// </summary>
    [JsonPropertyName("DisplayOutput")]
    public required IReadOnlyList<DisplayOutput> DisplayOutput { get; init; }
}
