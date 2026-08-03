using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>accel</b>.
/// </summary>
public record AccelInfo1
{
    [JsonPropertyName("processingType")]
    public required ProcessingType ProcessingType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
