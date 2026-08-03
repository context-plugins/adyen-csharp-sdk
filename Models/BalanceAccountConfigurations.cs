using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BalanceAccountConfigurations
{
    /// <summary>
    /// Contains a list of the Balance Account payout schedules.
    /// </summary>
    [JsonPropertyName("balanceAccountPayoutSchedules")]
    public required IReadOnlyList<BalanceAccountConfiguration> BalanceAccountPayoutSchedules { get; init; }

    [JsonPropertyName("link")]
    public required Link Link { get; init; }
}
