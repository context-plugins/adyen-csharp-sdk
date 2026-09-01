using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record BalancePlatformConfigurations
{
    /// <summary>
    /// Contains a list of the payout schedules configured in your balance platform.
    /// </summary>
    [JsonPropertyName("balancePlatformPayoutSchedules")]
    public required IReadOnlyList<BalancePlatformConfiguration> BalancePlatformPayoutSchedules { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
