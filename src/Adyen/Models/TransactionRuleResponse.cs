using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionRuleResponse
{
    /// <summary>
    /// The transaction rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRule")]
    public TransactionRule1? TransactionRule { get; init; }
}
