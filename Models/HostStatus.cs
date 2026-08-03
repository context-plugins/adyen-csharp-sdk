using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Indicate the reachability of the host by the POI Terminal.
/// State of a Host.
/// </summary>
public record HostStatus
{
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [JsonPropertyName("AcquirerID")]
    public required int AcquirerId { get; init; }

    /// <summary>
    /// Indicate if a Host is reachable.
    /// </summary>
    [JsonPropertyName("IsReachableFlag")]
    public bool? IsReachableFlag { get; init; } = true;
}
