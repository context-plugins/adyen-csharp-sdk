using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Defines your platform's commission for the processed payments as a fixed amount (specified in minor units), a percentage (specified in basis points), or both. The commission is booked to your platform's liable balance account.
/// </summary>
public record Commission1
{
    /// <summary>
    /// A fixed commission fee, in minor units.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixedAmount")]
    public long? FixedAmount { get; init; }

    /// <summary>
    /// A variable commission fee, in basis points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variablePercentage")]
    public long? VariablePercentage { get; init; }
}
