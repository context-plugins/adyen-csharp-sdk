using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransferLimitListResponse
{
    /// <summary>
    /// List of available transfer limits.
    /// </summary>
    [JsonPropertyName("transferLimits")]
    public required IReadOnlyList<TransferLimit> TransferLimits { get; init; }
}
