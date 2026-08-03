using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>pulse</b>.
/// </summary>
public record PulseInfo2
{
    [JsonPropertyName("processingType")]
    public required ProcessingType ProcessingType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
