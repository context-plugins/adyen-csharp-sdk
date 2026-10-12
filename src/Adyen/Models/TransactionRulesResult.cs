using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionRulesResult
{
    /// <summary>
    /// The advice given by the Risk analysis.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("advice")]
    public string? Advice { get; init; }

    /// <summary>
    /// Indicates whether the transaction passed the evaluation for all hardblock rules
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allHardBlockRulesPassed")]
    public bool? AllHardBlockRulesPassed { get; init; }

    /// <summary>
    /// The score of the Risk analysis.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public int? Score { get; init; }

    /// <summary>
    /// Array containing all the transaction rules that the transaction triggered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggeredTransactionRules")]
    public IReadOnlyList<TransactionEventViolation>? TriggeredTransactionRules { get; init; }
}
