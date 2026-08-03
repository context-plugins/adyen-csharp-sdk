using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UsinstantPayoutAddressRequirement
{
    /// <summary>
    /// Specifies that you must provide complete street addresses for the party and counterParty for transactions greater than USD 3000.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// <b>usInstantPayoutAddressRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type373 Type { get; init; }
}
