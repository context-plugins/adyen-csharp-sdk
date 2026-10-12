using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DisableResult
{
    /// <summary>
    /// Depending on whether a specific recurring detail was in the request, result is either [detail-successfully-disabled] or [all-details-successfully-disabled].
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public string? Response { get; init; }
}
