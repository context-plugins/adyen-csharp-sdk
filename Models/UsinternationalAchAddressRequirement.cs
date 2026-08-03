using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UsinternationalAchAddressRequirement
{
    /// <summary>
    /// Specifies that you must provide a complete street address for International ACH (IAT) transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// <b>usInternationalAchAddressRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type383 Type { get; init; }
}
