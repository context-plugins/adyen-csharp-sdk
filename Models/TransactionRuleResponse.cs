using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionRuleResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRule")]
    public TransactionRule? TransactionRule { get; init; }
}
