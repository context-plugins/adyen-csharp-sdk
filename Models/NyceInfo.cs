using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record NyceInfo
{
    [JsonPropertyName("processingType")]
    public required ProcessingType ProcessingType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
