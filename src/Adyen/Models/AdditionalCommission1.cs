using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Defines whether to book an additional commission for payments to your user's balance account. The commission amount can be defined as a fixed amount (specified in minor units), a percentage (specified in basis points), or both.
/// </summary>
public record AdditionalCommission1
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
