using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InternalReviewTrackingData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason11? Reason { get; init; }

    [JsonPropertyName("status")]
    public required Status44 Status { get; init; }

    /// <summary>
    /// The type of tracking event.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>internalReview</b>: the transfer was flagged because it does not comply with Adyen's risk policy.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type90 Type { get; init; }
}
