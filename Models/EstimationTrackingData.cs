using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record EstimationTrackingData
{
    /// <summary>
    /// The estimated time the beneficiary should have access to the funds.
    /// </summary>
    [JsonPropertyName("estimatedArrivalTime")]
    public required DateTimeOffset EstimatedArrivalTime { get; init; }

    /// <summary>
    /// The type of tracking event.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>estimation</b>: the estimated date and time of when the funds will be credited has been determined.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "estimation";
}
