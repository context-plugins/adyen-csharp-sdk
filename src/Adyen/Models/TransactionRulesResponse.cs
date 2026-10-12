using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionRulesResponse
{
    /// <summary>
    /// List of transaction rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRules")]
    public IReadOnlyList<TransactionRule>? TransactionRules { get; init; }
}
