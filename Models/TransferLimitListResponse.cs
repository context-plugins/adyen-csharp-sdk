using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record TransferLimitListResponse
{
    /// <summary>
    /// List of available transfer limits.
    /// </summary>
    [JsonPropertyName("transferLimits")]
    public required IReadOnlyList<TransferLimit> TransferLimits { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
