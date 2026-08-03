using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ConfirmationTrackingData
{
    [JsonPropertyName("status")]
    public required Status110 Status { get; init; }

    /// <summary>
    /// The type of the tracking event.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>confirmation</b>: the transfer passed Adyen's internal review.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type834 Type { get; init; }
}
