using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InternalReviewTrackingData
{
    /// <summary>
    /// The reason why the transfer failed Adyen's internal review.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>refusedForRegulatoryReasons</b>: the transfer does not comply with Adyen's risk policy. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact the Support Team</see>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason11? Reason { get; init; }

    /// <summary>
    /// The status of the transfer.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>pending</b>: the transfer is under internal review by Adyen.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>failed</b>: the transfer failed Adyen's internal review. For details, see <c>reason</c>.</description></item>
    /// </list>
    /// </summary>
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
    public string Type { get; } = "internalReview";
}
