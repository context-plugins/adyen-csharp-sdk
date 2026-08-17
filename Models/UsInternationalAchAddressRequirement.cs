using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UsInternationalAchAddressRequirement
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
    public string Type { get; } = "usInternationalAchAddressRequirement";
}
