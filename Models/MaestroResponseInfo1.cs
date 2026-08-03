using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>maestro</b> details
/// </summary>
public record MaestroResponseInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
