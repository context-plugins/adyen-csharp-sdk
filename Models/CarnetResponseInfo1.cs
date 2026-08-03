using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>carnet</b> details
/// </summary>
public record CarnetResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
