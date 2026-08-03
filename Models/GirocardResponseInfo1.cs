using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>girocard</b> details
/// </summary>
public record GirocardResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
