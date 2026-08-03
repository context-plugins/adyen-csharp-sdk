using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CupResponseInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
