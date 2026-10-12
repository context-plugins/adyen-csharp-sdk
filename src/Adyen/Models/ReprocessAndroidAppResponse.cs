using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ReprocessAndroidAppResponse
{
    /// <summary>
    /// The result of the reprocess.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Message")]
    public string? Message { get; init; }
}
