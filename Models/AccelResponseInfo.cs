using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccelResponseInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingType")]
    public ProcessingType? ProcessingType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
