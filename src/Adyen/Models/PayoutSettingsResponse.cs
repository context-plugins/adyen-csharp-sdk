using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PayoutSettingsResponse
{
    /// <summary>
    /// The list of payout accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<PayoutSettings>? Data { get; init; }
}
