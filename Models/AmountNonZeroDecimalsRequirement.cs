using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AmountNonZeroDecimalsRequirement
{
    /// <summary>
    /// Specifies for which routes the amount in a transfer request must have no non-zero decimal places, so the transfer can only be processed if the amount consists of round numbers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// <b>amountNonZeroDecimalsRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type94 Type { get; init; }
}
