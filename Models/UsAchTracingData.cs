using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UsAchTracingData
{
    /// <summary>
    /// The ACH trace number. This is a unique 15-digit identifier assigned to transfers processed by <see href="https://fiscal.treasury.gov/payments-from-government/automated-clearing-house-ach">ACH</see>.
    /// </summary>
    [JsonPropertyName("traceNumber")]
    public required string TraceNumber { get; init; }

    /// <summary>
    /// <b>usAch</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "usAch";
}
