using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>ideal</b> details
/// </summary>
public record IdealResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
