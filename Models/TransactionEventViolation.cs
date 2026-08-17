using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionEventViolation
{
    /// <summary>
    /// An explanation about why the transaction rule failed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Contains information about the transaction rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRule")]
    public TransactionRuleReference2? TransactionRule { get; init; }

    /// <summary>
    /// Contains information about the resource to which the transaction rule applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRuleSource")]
    public TransactionRuleSource2? TransactionRuleSource { get; init; }
}
