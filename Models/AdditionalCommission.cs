using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalCommission
{
    /// <summary>
    /// Unique identifier of the balance account to which the additional commission is booked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

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
