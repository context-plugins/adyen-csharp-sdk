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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRule")]
    public TransactionRuleReference? TransactionRule { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRuleSource")]
    public TransactionRuleSource? TransactionRuleSource { get; init; }
}
