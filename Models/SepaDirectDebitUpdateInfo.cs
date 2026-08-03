using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SepaDirectDebitUpdateInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
