using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Commission
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
